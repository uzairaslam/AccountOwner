using Entities;
using Entities.Models;
using Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Repository
{
    public class OwnerRepository : RepositoryBase<Owner>, IOwnerRepository
    {
        public OwnerRepository(RepositoryContext context) : base(context)
        {

        }

        public IEnumerable<Owner> GetAllOwners()
        {
            return FindAll().OrderBy(o => o.Name).ToList();
        }
    }
}
