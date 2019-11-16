using GraphQL.Types;
using Jawla.API.GraphQL.GraphQLTypes;

namespace Jawla.API.GraphQL.GraphQLQueries
{
    public class AppQuery: ObjectGraphType
    {
        public AppQuery(Jawla.BLL.Services.Account.IAccountRepository repository)
        {
            Field<ListGraphType<AccountType>>(
               "accounts",
               resolve: context => repository.GetAccounts()
           );
        }
    }
}
