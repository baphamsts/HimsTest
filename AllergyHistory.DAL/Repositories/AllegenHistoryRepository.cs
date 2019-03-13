using AllergyHistory.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AllergyHistory.DAL.Repositories
{
    public class AllegenHistoryRepository : IRepository<AllergenHistory>
    {
        public AllegenHistoryRepository()
        {

        }
        //readonly AllergyHistoryContext dbContext;

        //public AllegenHistoryRepository(AllergyHistoryContext context)
        //{
        //    this.dbContext = context;
        //}

        public string GetAllXml(string fakeDataFolderPath)
        {
            var xmlContent = File.ReadAllText($"{fakeDataFolderPath}/Data/History/HistoryData.xml");
            return xmlContent;
        }
    }
}
