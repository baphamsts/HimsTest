using AllergyHistory.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AllergyHistory.DAL.Repositories
{
    public class AllergenRepository : IRepository<Allergen>
    {
        public AllergenRepository()
        {

        }
        public string GetAllXml(string fakeDataFolderPath)
        {
            var xmlContent = File.ReadAllText($"{fakeDataFolderPath}/Data/Input/AllergenDropdown.xml");
            return xmlContent;
        }
    }
}
