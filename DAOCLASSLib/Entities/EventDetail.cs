namespace DAOCLASSLib.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EventDetail")]
    public partial class EventDetail
    {
        [Key]
        [Column("EventDetailId")]
        public int EventDetailId { get; set; }

        public int? BranchId { get; set; }

        [StringLength(50)]
        public string Batch1 { get; set; }

        [StringLength(50)]
        public string Batch2 { get; set; }

        public int? EventTypeId { get; set; }

        public int? IssueMediumId { get; set; }

        public int? LCNumber { get; set; }

        public int? EventNumber { get; set; }

        [StringLength(50)]
        public string EventStatus1 { get; set; }

        [StringLength(50)]
        public string EventStatus2 { get; set; }

        public int? correspondanceNo { get; set; }

        public DateTime? CorrespondanceDate { get; set; }

        public int? CorrespondanceTypeId { get; set; }

        public int? PartiesId { get; set; }

        [StringLength(50)]
        public string BankBranch { get; set; }

        public int? BankNo { get; set; }

        public int? BranchNo { get; set; }

        [StringLength(500)]
        public string Information { get; set; }

        [StringLength(50)]
        public string Information2 { get; set; }

        [StringLength(50)]
        public string Reference { get; set; }

        [StringLength(500)]
        public string IntractionToSend { get; set; }

        [StringLength(500)]
        public string information3 { get; set; }

        [StringLength(50)]
        public string EventDetailStatus { get; set; }

        [StringLength(50)]
        public string Created_By { get; set; }

        public DateTime? Created_date { get; set; }

        [StringLength(50)]
        public string Modified_By { get; set; }

        public DateTime? Modified_date { get; set; }

        public bool? IsActive { get; set; }

        public virtual CorrespondanceType CorrespondanceType { get; set; }

        public virtual EventType EventType { get; set; }

        public virtual IssueMedium IssueMedium { get; set; }

        public virtual Party Party { get; set; }
    }
}
