using CommanderGQL.Data;
using CommanderGQL.Model;
using HotChocolate;
using HotChocolate.Types;
using System.Linq;

namespace CommanderGQL.GraphQL.Commands
{
    public class CommandType :  ObjectType<Command>
    {
        protected override void Configure(IObjectTypeDescriptor<Command> descriptor)
        {
            descriptor.Description("Represents any executable command");

            descriptor
                .Field(p => p.Platform)
                .ResolveWith<Resolvers>(p => p.GetPlatform(default!, default!))
                .UseDbContext<AppDBContext>()
                .Description("This is the platform to wich the command belongs");
        }

        private class Resolvers
        {
            public Platform GetPlatform(Command command, [ScopedService] AppDBContext context)
            {
                return context.Platforms.FirstOrDefault(p => p.Id == command.PlatformId);
            }
        }
    }
}
