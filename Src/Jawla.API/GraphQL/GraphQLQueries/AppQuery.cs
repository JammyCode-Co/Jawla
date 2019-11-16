using GraphQL.Types;
using Jawla.API.GraphQL.GraphQLTypes;

namespace Jawla.API.GraphQL.GraphQLQueries
{
    public class AppQuery: ObjectGraphType
    {
        public AppQuery(Jawla.Domain.Interfaces.IAccountRepository repository)
        {
            Field<ListGraphType<AccountType>>(
               "accounts",
               resolve: context => repository.GetAccounts()
           );
        }
    }
}
