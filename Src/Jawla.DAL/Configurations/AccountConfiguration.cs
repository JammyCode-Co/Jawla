using Jawla.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Jawla.DAL.Configurations
{
    class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        private Guid _id;

        public AccountConfiguration(Guid id)
        {
            _id = id;
        }

        public void Configure(EntityTypeBuilder<Account> builder)
        {
        }
    }
}
