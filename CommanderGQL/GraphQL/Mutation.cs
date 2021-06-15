using CommanderGQL.Data;
using CommanderGQL.GraphQL.Commands;
using CommanderGQL.GraphQL.PlatForms;
using CommanderGQL.Model;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Subscriptions;
using System.Threading;
using System.Threading.Tasks;

namespace CommanderGQL.GraphQL
{
    public class Mutation
    {
        [UseDbContext(typeof(AppDBContext))]
        public async Task<AddPlatformPayload> AddPlatformAsync(AddPlatformInput input
            , [ScopedService] AppDBContext Context
            , [Service] ITopicEventSender eventSender
            , CancellationToken cancellationToken
            )
        {
            var platform = new Platform
            {
                Name = input.Name
            };

            Context.Platforms.Add(platform);
            await Context.SaveChangesAsync(cancellationToken);
            await eventSender.SendAsync(nameof(Subscription.OnPlatformAdded), platform, cancellationToken);

            return new AddPlatformPayload(platform);
        }

        [UseDbContext(typeof(AppDBContext))]
        public async Task<AddCommandPayload> AddCommandAsync(
            AddCommandInput input
            , [ScopedService] AppDBContext Context
          )
        {
            var Command = new Command
            {
                HowTo = input.HowTo,
                CommandLine = input.CommandLine,
                PlatformId = input.PlatformId
            };

            Context.Commands.Add(Command);
            await Context.SaveChangesAsync();

            return new AddCommandPayload(Command);
        }
    }
}
