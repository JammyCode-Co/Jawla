using GraphQL.Types;
using Jawla.Domain.Dto;

namespace Jawla.API.GraphQL.GraphQLTypes
{
    public class AccountType: ObjectGraphType<Account>
    {
        public AccountType()
        {
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Id property from the account object.");
            Field(x => x.FirstName).Description("First Name property from the account object.");
            Field(x => x.LastName).Description("Last Name property from the account object.");
            Field(x => x.Email).Description("Email property from the account object.");
        }
    }
}
