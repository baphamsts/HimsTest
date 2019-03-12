using AllergyHistory.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AllergyHistory.DAL.Repositories
{
    /// <summary>
    /// This patient Repository for test that this solution can work with an persistence database
    /// Already test and up and running, but this has no longer used anymore, due to we just want using fake data instead
    /// </summary>
    public class PatientRepository : IRepository<Patient>
    {
        readonly AllergyHistoryContext dbContext;

        public PatientRepository(AllergyHistoryContext context)
        {
            this.dbContext = context;
        }

        public IEnumerable<Patient> GetAll()
        {
            return dbContext.Patients.ToList();
        }

        public IQueryable<Patient> GetAll_Q()
        {
            return dbContext.Patients.AsQueryable();
        }

        public Patient Get(long id)
        {
            return dbContext.Patients
                  .FirstOrDefault(e => e.PatientId == id);
        }

        public void Add(Patient entity)
        {
            dbContext.Patients.Add(entity);
            dbContext.SaveChanges();
        }

        public void Update(Patient Patient, Patient entity)
        {
            Patient.PatientName = entity.PatientName;
            Patient.Provider = entity.Provider;
            Patient.Population = entity.Population;
            Patient.DOB = entity.DOB;
            Patient.AxisI = entity.AxisI;
            Patient.CISId = entity.CISId;
            Patient.Gender = entity.Gender;
            Patient.deleted = entity.deleted;

            dbContext.SaveChanges();
        }

        public string GetAllXml()
        {
            var xmlContent = File.ReadAllText(@"Data/Input/MedicationDropdown.xml");
            return xmlContent;
        }

        public void Delete(Patient Patient)
        {
            dbContext.Patients.Remove(Patient);
            dbContext.SaveChanges();
        }

    }
}
