using Registration.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration.Repository
{
    class RepositoryBase: DbContext
    {
        public DbSet<Register> Rigesters { get; set; }
        public DbSet<Person> Persons { get; set; }
        
        public DbSet<Certification> Certifications { get; set; }

        public DbSet<Colleage> Colleages { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<EAddress> EAddress { get; set; }
        public DbSet<Training> Experincess { get; set; }
        public DbSet<ForAdmin> ForAdmins { get; set; }
        public DbSet<Grade> Grades { get; set; }
        
        public DbSet<NatID> NatIDs { get; set; }
        
        public DbSet<Paper> Papers { get; set; }
        public DbSet<PName> Names { get; set; }
        public DbSet<province> Provences { get; set; }
        
        public DbSet<Relative> Relatives { get; set; }
        public DbSet<Major> SpecialistS { get; set; }
        public DbSet<State> States { get; set; }
        public University Universities { get; set; }
        public DbSet<Village> Villages { get; set; }
        public DbSet<Experinces> WorkingHistorys { get; set; }

        /* public DbSet<RecType> RecTypes { get; set; }
        public DbSet<GradeType> GradeTypes { get; set; }
        public DbSet<NatType> NatTypes { get; set; }
        public DbSet<Classification> Classifications { get; set; } */

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
    
}
