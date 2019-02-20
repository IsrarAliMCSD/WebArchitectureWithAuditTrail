using BAL.BALOperation;
using DAOCLASSLib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppController
{
    public class AppManager
    {
        public BALParty balPartyObj;
        public BALEventType balEventType;
        public BALIssueMedium balIssueMedium;
        public BALCorrespondanceType balcorrespondanceType;
        public BALEventDetail balEventDetail;

        public AppManager()
        {
            //balPartyObj = new balPartyObj();
        }
        public IEnumerable<Party> GetAllParties()
        {
            balPartyObj = new BALParty();
            return balPartyObj.GetAllParties();
        }
        public IEnumerable<EventType> GetAllEventType()
        {
            balEventType = new BALEventType();
            return balEventType.GetAllEventType();
        }
        public IEnumerable<IssueMedium> GetAllIssueMedium()
        {
            balIssueMedium = new BALIssueMedium();
            return balIssueMedium.GetAllIssueMedium();
        }


        public IEnumerable<CorrespondanceType> GetAllCorrespondanceType()
        {
            balcorrespondanceType = new BALCorrespondanceType();
            return balcorrespondanceType.GetAllCorrespondanceType();
        }
        public IEnumerable<EventDetail> GetAllEventDetails()
        {
            balEventDetail = new BALEventDetail();
            return balEventDetail.GetAllEventDetails();

        }
        public bool InsertEventDetail(EventDetail eventDetail, ref string error)
        {
            balEventDetail = new BALEventDetail();
            return balEventDetail.InsertEventDetail(eventDetail, ref error);

        }
        public EventDetail GetEventDetailByLC(int lcNum)
        {
            balEventDetail = new BALEventDetail();
            return balEventDetail.GetEventDetailByLC(lcNum);

        }


    }
}
