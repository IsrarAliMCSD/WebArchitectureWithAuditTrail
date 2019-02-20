using DAOCLASSLib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EFOperation
{
    public class EFEventType
    {
        public Model1 context;
        bool result = false;
        int userId = 0;
        public EFEventType()
        {
            context = new Model1();
            //context.Configuration.ProxyCreationEnabled = true;
            //context.Configuration.LazyLoadingEnabled = true;

        }
        public IEnumerable<EventType> GetAllEventType()
        {
            return context.EventTypes.Where(a => a.IsActive == true).ToList();
        }
    }
}
