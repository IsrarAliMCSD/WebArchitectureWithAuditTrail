using DAL.EFOperation;
using DAOCLASSLib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.BALOperation
{
    public class BALCorrespondanceType
    {
        public EFCorrespondanceType efCorrespondanceType;
        public BALCorrespondanceType()
        {
            efCorrespondanceType = new EFCorrespondanceType();
        }
        public IEnumerable<CorrespondanceType> GetAllCorrespondanceType()
        {
            return efCorrespondanceType.GetAllCorrespondanceType();

        }
    }
}
