using DAOCLASSLib.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAOCLASSLib.Entities
{
   
    public partial class Model1 : DbContext
    {
        public override int SaveChanges()
        {
            foreach (var auditableEntity in ChangeTracker.Entries<IAuditable>())
            {
                if (auditableEntity.State == EntityState.Added ||
                    auditableEntity.State == EntityState.Modified)
                {
                    auditableEntity.Entity.Modified_date = DateTime.Now;
                    auditableEntity.Entity.Modified_By = "Modified User";

                    if (auditableEntity.State == EntityState.Added)
                    {
                        auditableEntity.Entity.Created_date = DateTime.Now;
                        auditableEntity.Entity.Created_By = "Created User";
                    }
                }
            }
            return base.SaveChanges();
        }



    }
}
