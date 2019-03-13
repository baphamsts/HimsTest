using AllergyHistory.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AllergyHistory.DAL.Repositories
{
    public class AllergenSeverityRepository : IRepository<AllergenSeverity>
    {
        public AllergenSeverityRepository()
        {

        }

        public string GetAllXml(string fakeDataFolderPath)
        {
            var xmlContent = File.ReadAllText($"{fakeDataFolderPath}/Data/Input/AllergenSeverityDropdown.xml");
            return xmlContent;
        }
    }
}
