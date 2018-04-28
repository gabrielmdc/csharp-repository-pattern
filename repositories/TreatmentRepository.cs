using System;
using System.Collections.Generic;
using System.Linq;
using RepositoryPattern.models;

namespace RepositoryPattern.repositories
{
    class TreatmentRepository : Repository<Treatment>, ITreatmentRepository
    {
        public MyContext MyContext
        {
            get { return Context as MyContext; }
        }

        public TreatmentRepository(MyContext context) : base(context)
        {
        }
    }
}
