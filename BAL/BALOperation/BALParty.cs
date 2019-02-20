using DAL.EFOperation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAOCLASSLib;
using DAOCLASSLib.Entities;

namespace BAL.BALOperation
{
    public class BALParty
    {
        public EFParty efParty;
        public BALParty()
        {
            efParty = new EFParty();
        }
        public IEnumerable<Party> GetAllParties()
        {
            return efParty.GetAllParties();
        }
    }
}
