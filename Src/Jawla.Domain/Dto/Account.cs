using System;
using System.Collections.Generic;
using System.Text;

namespace Jawla.Domain.Dto
{
    public class Account
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
    }
}
