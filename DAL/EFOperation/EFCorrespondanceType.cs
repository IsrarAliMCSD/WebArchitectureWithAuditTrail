using DAOCLASSLib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EFOperation
{
    public class EFCorrespondanceType
    {
        public Model1 context;
        bool result = false;
        int userId = 0;
        public EFCorrespondanceType()
        {
            context = new Model1();
            //context.Configuration.ProxyCreationEnabled = true;
            //context.Configuration.LazyLoadingEnabled = true;

        }
        public IEnumerable<CorrespondanceType> GetAllCorrespondanceType()
        {
            return context.CorrespondanceTypes.Where(a => a.IsActive == true).ToList();
        }
    }
}
