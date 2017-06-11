using _2014118287_ENT;
using _2014118287_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014118287_PER.Repositories
{
    public class AdministrativoRepository : Repository<Administrativo>, IAdministrativoRepository
    {
        public AdministrativoRepository(DbContext context) : base(context)
        {
        }
    }
}
