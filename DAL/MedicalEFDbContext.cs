using Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public abstract class MedicalEFDbContext : DbContext
    {
        public MedicalEFDbContext()
            : base("name=DefaultConnection")
        {
        }
    }

    public class DiagnosisDBEfContext : MedicalEFDbContext
    {
        public IDbSet<Diagnosis> Diagnosises { get; set; }
        public IDbSet<Drug> Drugs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Drug>().MapToStoredProcedures();

            Database.SetInitializer<DiagnosisDBEfContext>(new DropCreateDatabaseIfModelChanges<DiagnosisDBEfContext>());
        }
    }
}
