using DAL.EFOperation;
using DAOCLASSLib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.BALOperation
{
    public class BALEventType
    {
        public EFEventType eventType;
        public BALEventType()
        {
            eventType = new EFEventType();
        }
        public IEnumerable<EventType> GetAllEventType()
        {
            return eventType.GetAllEventType();

        }
    }
}
