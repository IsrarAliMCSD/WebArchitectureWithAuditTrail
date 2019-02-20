using DAL.EFOperation;
using DAOCLASSLib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.BALOperation
{
    public class BALIssueMedium
    {
        public EFIssueMedium efIssueMedium;
        public BALIssueMedium()
        {
            efIssueMedium = new EFIssueMedium();
        }
        public IEnumerable<IssueMedium> GetAllIssueMedium()
        {
            return efIssueMedium.GetAllIssueMedium();
        }
    }
}
