using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOCLASSLib.Entities
{

    public interface IAuditable
    {
        DateTime? Created_date { get; set; }
        string Created_By { get; set; }
        string Modified_By { get; set; }
        DateTime? Modified_date { get; set; }

    }
    public partial class EventDetail : IAuditable
    {

    }
}
