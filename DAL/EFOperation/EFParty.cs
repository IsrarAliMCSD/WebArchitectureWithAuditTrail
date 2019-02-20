using DAOCLASSLib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EFOperation
{
    public class EFParty
    {
        public Model1 context;
        bool result = false;
        int userId = 0;
        public EFParty()
        {
            context = new Model1();
            //context.Configuration.ProxyCreationEnabled = true;
            //context.Configuration.LazyLoadingEnabled = true;

        }
        public IEnumerable<Party> GetAllParties()
        {
            return context.Parties.Where(a => a.IsActive == true).ToList();
        }
    }
}
