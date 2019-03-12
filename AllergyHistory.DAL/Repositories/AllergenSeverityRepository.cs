using AllergyHistory.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AllergyHistory.DAL.Repositories
{
    public class AllergenSeverityRepository : IRepository<AllergenSeverity>
    {
        readonly AllergyHistoryContext dbContext;

        public AllergenSeverityRepository(AllergyHistoryContext context)
        {
            this.dbContext = context;
        }

        public string GetAllXml()
        {
            var xmlContent = File.ReadAllText(@"Data/Input/AllergenSeverityDropdown.xml");
            return xmlContent;
        }

        public IEnumerable<AllergenSeverity> GetAll()
        {
            var fakeData = GenerateFakeData();
            return fakeData;

            //return dbContext.AllegenHistories.ToList();
        }

        public IQueryable<AllergenSeverity> GetAll_Q()
        {
            //return dbContext.AllegenHistories.AsQueryable();
            return null;

        }

        public AllergenSeverity Get(long id)
        {
            //return dbContext.AllegenHistories
            //      .FirstOrDefault(e => e.AllegenHistoryId == id);

            return null;

        }

        public void Add(AllergenSeverity entity)
        {
            //dbContext.AllegenHistories.Add(entity);
            //dbContext.SaveChanges();
        }

        public void Update(AllergenSeverity allegenHistory, AllergenSeverity entity)
        {
            //dbContext.SaveChanges();
        }

        public void Delete(AllergenSeverity allergenHistory)
        {
           
        }


        /// <summary>
        /// This generate fake Domain data, considering that in this do main Enties, we call client is patient.
        /// </summary>
        /// <returns></returns>
        private IEnumerable<AllergenSeverity>  GenerateFakeData()
        {
            var data = new List<AllergenSeverity> {
                new AllergenSeverity
                {
                    Id = 1,
                    Desc = "Life Threatening",
                    Value = 1,
                    TypeId = 1,
                },

                new AllergenSeverity
                {
                    Id = 2,
                    Desc = "Low",
                    Value = 2,
                    TypeId = 2,
                },

                new AllergenSeverity
                {
                    Id = 3,
                    Desc = "Moderate",
                    Value = 3,
                    TypeId = 3,
                },

                new AllergenSeverity
                {
                    Id = 4,
                    Desc = "Severe",
                    Value = 4,
                    TypeId = 4,
                },
            };

            return data;
        }
    }
}
