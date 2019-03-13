using AllergyHistory.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AllergyHistory.DAL.Repositories
{
    public class AllergenTypeRepository : IRepository<AllergenType>
    {
        public AllergenTypeRepository()
        {

        }
        public string GetAllXml(string fakeDataFolderPath)
        {
            //string path = Directory.GetCurrentDirectory();
            var xmlContent = File.ReadAllText($"{fakeDataFolderPath}/Data/Input/AllergenTypeDropdown.xml");
            return xmlContent;
        }
    }
}
