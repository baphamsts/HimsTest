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
        //readonly AllergyHistoryContext dbContext;

        //public PatientRepository(AllergyHistoryContext context)
        //{
        //    this.dbContext = context;
        //}
        public PatientRepository()
        {

        }
        public string GetAllXml()
        {
            var xmlContent = File.ReadAllText(@"Data/Input/MedicationDropdown.xml");
            return xmlContent;
        }
    }
}
