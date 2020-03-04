using Entities;
using Entities.Models;
using Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class OwnerRepository : RepositoryBase<Owner>, IOwnerRepository
    {
        public OwnerRepository(RepositoryContext context) : base(context)
        {

        }
    }
}
