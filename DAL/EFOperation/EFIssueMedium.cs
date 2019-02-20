using DAOCLASSLib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.EFOperation
{
    public class EFIssueMedium
    {
        public Model1 context;
        bool result = false;
        int userId = 0;
        public EFIssueMedium()
        {
            context = new Model1();
            //context.Configuration.ProxyCreationEnabled = true;
            //context.Configuration.LazyLoadingEnabled = true;

        }
        public IEnumerable<IssueMedium> GetAllIssueMedium()
        {
            return context.IssueMediums.Where(a => a.IsActive == true).ToList();
        }
    }
}
