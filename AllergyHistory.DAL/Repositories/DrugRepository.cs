using AllergyHistory.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace AllergyHistory.DAL.Repositories
{
    public class DrugRepository : IRepository<Drug>
    {
        public DrugRepository()
        {

        }
       
        public string GetAllXml()
        {
            var xmlContent = File.ReadAllText(@"D:/HiMs/HimsTest/AllergyHistory.API/Data/Input/MedicationDropdown.xml");
            return xmlContent;
        }
    }
}
