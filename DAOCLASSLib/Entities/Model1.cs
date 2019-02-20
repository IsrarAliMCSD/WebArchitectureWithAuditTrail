namespace DAOCLASSLib.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Trade_Finance")
        {
        }

        public virtual DbSet<CorrespondanceType> CorrespondanceTypes { get; set; }
        public virtual DbSet<EventDetail> EventDetails { get; set; }
        public virtual DbSet<EventType> EventTypes { get; set; }
        public virtual DbSet<IssueMedium> IssueMediums { get; set; }
        public virtual DbSet<Party> Parties { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CorrespondanceType>()
                .Property(e => e.CorrespondanceTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<CorrespondanceType>()
                .Property(e => e.Created_By)
                .IsUnicode(false);

            modelBuilder.Entity<CorrespondanceType>()
                .Property(e => e.Modified_By)
                .IsUnicode(false);

            modelBuilder.Entity<EventDetail>()
                .Property(e => e.Batch1)
                .IsUnicode(false);

            modelBuilder.Entity<EventDetail>()
                .Property(e => e.Batch2)
                .IsUnicode(false);

            modelBuilder.Entity<EventDetail>()
                .Property(e => e.EventStatus1)
                .IsUnicode(false);

            modelBuilder.Entity<EventDetail>()
                .Property(e => e.EventStatus2)
                .IsUnicode(false);

            modelBuilder.Entity<EventDetail>()
                .Property(e => e.BankBranch)
                .IsUnicode(false);

            modelBuilder.Entity<EventDetail>()
                .Property(e => e.Information)
                .IsUnicode(false);

            modelBuilder.Entity<EventDetail>()
                .Property(e => e.Information2)
                .IsUnicode(false);

            modelBuilder.Entity<EventDetail>()
                .Property(e => e.Reference)
                .IsUnicode(false);

            modelBuilder.Entity<EventDetail>()
                .Property(e => e.IntractionToSend)
                .IsUnicode(false);

            modelBuilder.Entity<EventDetail>()
                .Property(e => e.information3)
                .IsUnicode(false);

            modelBuilder.Entity<EventDetail>()
                .Property(e => e.EventDetailStatus)
                .IsUnicode(false);

            modelBuilder.Entity<EventDetail>()
                .Property(e => e.Created_By)
                .IsUnicode(false);

            modelBuilder.Entity<EventDetail>()
                .Property(e => e.Modified_By)
                .IsUnicode(false);

            modelBuilder.Entity<EventType>()
                .Property(e => e.EventTypeName)
                .IsUnicode(false);

            modelBuilder.Entity<EventType>()
                .Property(e => e.Created_By)
                .IsUnicode(false);

            modelBuilder.Entity<EventType>()
                .Property(e => e.Modified_By)
                .IsUnicode(false);

            modelBuilder.Entity<EventType>()
                .HasMany(e => e.EventDetails)
                .WithOptional(e => e.EventType)
                .HasForeignKey(e => e.EventTypeId);

            modelBuilder.Entity<IssueMedium>()
                .Property(e => e.IssueMediumName)
                .IsUnicode(false);

            modelBuilder.Entity<IssueMedium>()
                .Property(e => e.Created_By)
                .IsUnicode(false);

            modelBuilder.Entity<IssueMedium>()
                .Property(e => e.Modified_By)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.PartiesName)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.Created_By)
                .IsUnicode(false);

            modelBuilder.Entity<Party>()
                .Property(e => e.Modified_By)
                .IsUnicode(false);
        }
    }
}
