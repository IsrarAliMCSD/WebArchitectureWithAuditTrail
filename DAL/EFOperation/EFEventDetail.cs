using DAOCLASSLib.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EFOperation
{
    public class EFEventDetail
    {
        public Model1 context;
        bool result = false;
        int userId = 0;
        public EFEventDetail()
        {
            context = new Model1();
            //context.Configuration.ProxyCreationEnabled = true;
            //context.Configuration.LazyLoadingEnabled = true;

        }
        public IEnumerable<EventDetail> GetAllEventDetails()
        {
            return context.EventDetails.Where(a => a.IsActive == true).ToList();
        }
        public bool InsertEventDetail(EventDetail eventDetail, ref string error)
        {



            result = false;
            using (context)
            {
                if (eventDetail != null && eventDetail.EventDetailId > 0)
                {
                    context.Entry(eventDetail).State = EntityState.Modified;
                }
                else
                {
                    context.EventDetails.Add(eventDetail);
                }
                context.SaveChanges();
                result = true;
            }
            return result;
        }

        public EventDetail GetEventDetailByLC(int lcNum)
        {
            return context.EventDetails.Where(a => a.LCNumber == lcNum).FirstOrDefault();
            ///return context.EventDetails.Where(a => a.LCNumber == lcNum && a.IsActive == true).FirstOrDefault();
        }

        public bool UpdateEventDetail(EventDetail eventDetail)
        {
            using (context)
            {
                var result = context.EventDetails.Where(a => a.EventDetailId == eventDetail.EventDetailId).FirstOrDefault();
                if (result != null)
                {
                    result.LCNumber = 123;
                    context.SaveChanges();
                    return true;
                }
            }
            return false;

        }
    }
}