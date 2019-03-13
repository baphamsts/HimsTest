using AllergyHistory.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AllergyHistory.DAL.Repositories
{
    public class AllergenReactionRepository : IRepository<AllergenReaction>
    {
        public AllergenReactionRepository()
        {

        }
        public string GetAllXml(string fakeDataFolderPath)
        {
            var xmlContent = File.ReadAllText($"{fakeDataFolderPath}/Data/Input/AllergenReactionDropdown.xml");
            return xmlContent;
        }
    }
}
