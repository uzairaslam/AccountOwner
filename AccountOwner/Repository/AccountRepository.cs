using Entities;
using Entities.Models;
using Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(RepositoryContext context) : base(context)
        {

        }
    }
}
