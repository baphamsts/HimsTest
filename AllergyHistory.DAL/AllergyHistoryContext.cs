using AllergyHistory.Domain.Entities;
using System;
using System.Data.Entity;

namespace AllergyHistory.DAL
{
    public class AllergyHistoryContext : DbContext
    {
        public AllergyHistoryContext(/*DbContextOptions options*/) : base(/*options*/)
        {

        }

        public DbSet<Patient> Patients { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Patient>().HasData(new Patient
        //    {
        //        PatientId = 1,
        //        PatientName = "something",
        //        CISId = 3,
        //        DOB = DateTime.Now,
        //        Gender = "Male",
        //        Provider = "something",
        //        Population = "Child",
        //        AxisI = "",
        //        ClientAllergyId = "",
        //        Allergen = "",
        //        deleted = false,

        //    }, new Patient
        //    {
        //        PatientId = 2,
        //        PatientName = "",
        //        CISId = 4,
        //        DOB = DateTime.Now,
        //        Gender = "Female",
        //        Provider = "something",
        //        Population = "Child",
        //        AxisI = "something",
        //        ClientAllergyId = "",
        //        Allergen = "",
        //        deleted = false,
        //    });
        //}
    }
}
