using DAL.EFOperation;
using DAOCLASSLib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.BALOperation
{
    public class BALEventDetail
    {
        public EFEventDetail efEventDetail;
        public BALEventDetail()
        {
            efEventDetail = new EFEventDetail();
        }
        public IEnumerable<EventDetail> GetAllEventDetails()
        {
            return efEventDetail.GetAllEventDetails();

        }
        public bool InsertEventDetail(EventDetail eventDetail, ref string error)
        {
            return efEventDetail.InsertEventDetail(eventDetail, ref error);

        }
        public EventDetail GetEventDetailByLC(int lcNum)
        {
            return efEventDetail.GetEventDetailByLC(lcNum);
        }




        }
}
