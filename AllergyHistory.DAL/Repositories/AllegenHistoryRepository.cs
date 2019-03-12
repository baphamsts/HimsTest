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

        public string GetAllXml()
        {
            var xmlContent = File.ReadAllText(@"D:/HiMs/HimsTest/AllergyHistory.API/Data/History/HistoryData.xml");
            return xmlContent;
        }
    }
}
