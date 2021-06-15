using CommanderGQL.Data;
using CommanderGQL.Model;
using HotChocolate;
using HotChocolate.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommanderGQL.GraphQL.PlatForms
{
    public class PlatformType : ObjectType<Platform>
    {
        protected override void Configure(IObjectTypeDescriptor<Platform> descriptor)
        {
            descriptor.Description("Represents any software or service that has a command line interface");
            descriptor.Field(p => p.LicenseKey).Ignore();
            descriptor.Field(p => p.Name).Description("Name Description Hello World");

            descriptor
                .Field(p => p.Commands)
                .ResolveWith<Resolvers>(p => p.GetCommands(default!, default!))
                .UseDbContext<AppDBContext>()
                .Description("THis is the List of availble commands for this platform");
        }

        private class Resolvers
        {
            public IQueryable<Command> GetCommands(Platform platform, [ScopedService] AppDBContext context)
            {
                return context.Commands.Where(p => p.PlatformId == platform.Id);
            }
        }
    }
}
