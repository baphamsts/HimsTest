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
        public string GetAllXml()
        {
            var xmlContent = File.ReadAllText(@"D:/HiMs/HimsTest/AllergyHistory.API/Data/Input/AllergenDropdown.xml");
            return xmlContent;
        }
    }
}
