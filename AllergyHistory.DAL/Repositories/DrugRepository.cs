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
       
        public string GetAllXml(string fakeDataFolderPath)
        {
            var xmlContent = File.ReadAllText($"{fakeDataFolderPath}/Data/Input/MedicationDropdown.xml");
            return xmlContent;
        }
    }
}
