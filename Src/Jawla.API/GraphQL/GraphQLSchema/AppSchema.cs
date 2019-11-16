using GraphQL;
using GraphQL.Types;
using Jawla.API.GraphQL.GraphQLQueries;

namespace Jawla.API.GraphQL.GraphQLSchema
{
    public class AppSchema : Schema
    {
        public AppSchema(IDependencyResolver resolver)
       : base(resolver)
        {
            Query = resolver.Resolve<AppQuery>();
        }
    }
}
