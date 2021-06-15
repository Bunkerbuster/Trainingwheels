using CommanderGQL.Data;
using CommanderGQL.Model;
using HotChocolate;
using HotChocolate.Data;
using System.Linq;


namespace CommanderGQL.GraphQL
{
    public class Query
    {
        [UseDbContext(typeof(AppDBContext))]
        //[UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Platform> GetPlatforms([ScopedService] AppDBContext Context)
        {
            return Context.Platforms;
        }

        [UseDbContext(typeof(AppDBContext))]
        //[UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Command> GetCommand([ScopedService] AppDBContext Context)
        {
            return Context.Commands;
        }

    }
}
