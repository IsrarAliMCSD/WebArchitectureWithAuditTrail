namespace DAOCLASSLib.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EventType")]
    public partial class EventType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EventType()
        {
            EventDetails = new HashSet<EventDetail>();
        }

        [Key]
        public int EventsTypeId { get; set; }

        [StringLength(50)]
        public string EventTypeName { get; set; }

        [StringLength(50)]
        public string Created_By { get; set; }

        public DateTime? Created_date { get; set; }

        [StringLength(50)]
        public string Modified_By { get; set; }

        public DateTime? Modified_date { get; set; }

        public bool? IsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EventDetail> EventDetails { get; set; }
    }
}
