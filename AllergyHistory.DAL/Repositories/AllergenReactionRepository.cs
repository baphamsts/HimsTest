using AllergyHistory.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AllergyHistory.DAL.Repositories
{
    public class AllergenReactionRepository : IRepository<AllergenReaction>
    {
        readonly AllergyHistoryContext dbContext;

        public AllergenReactionRepository(AllergyHistoryContext context)
        {
            this.dbContext = context;
        }

        public IEnumerable<AllergenReaction> GetAll()
        {
            var fakeData = GenerateFakeData();
            return fakeData;

            //return dbContext.AllegenHistories.ToList();
        }

        public IQueryable<AllergenReaction> GetAll_Q()
        {
            //return dbContext.AllegenHistories.AsQueryable();
            return null;

        }

        public AllergenReaction Get(long id)
        {
            //return dbContext.AllegenHistories
            //      .FirstOrDefault(e => e.AllegenHistoryId == id);

            return null;

        }

        public void Add(AllergenReaction entity)
        {
            //dbContext.AllegenHistories.Add(entity);
            //dbContext.SaveChanges();
        }

        public void Update(AllergenReaction allegenHistory, AllergenReaction entity)
        {
            //dbContext.SaveChanges();
        }

        public void Delete(AllergenReaction allergenHistory)
        {
           
        }


        public string GetAllXml()
        {
            var xmlContent = File.ReadAllText(@"Data/Input/AllergenReactionDropdown.xml");
            return xmlContent;
        }


        /// <summary>
        /// This generate fake Domain data, considering that in this do main Enties, we call client is patient.
        /// </summary>
        /// <returns></returns>
        private IEnumerable<AllergenReaction>  GenerateFakeData()
        {
            var data = new List<AllergenReaction> {
                new AllergenReaction
                {
                    Id = 1,
                    Desc = "Dizziness",
                    Value = "69096003",
                    TypeId = 1,
                },

                new AllergenReaction
                {
                    Id = 2,
                    Desc = "Headache",
                    Value = "139490008",
                    TypeId = 2,
                },

                new AllergenReaction
                {
                    Id = 3,
                    Desc = "Nausea",
                    Value = "139330007",
                    TypeId = 3,
                },

                new AllergenReaction
                {
                    Id = 4,
                    Desc = "Photosensitivity",
                    Value = "90128006",
                    TypeId = 4,
                },

            };

            return data;
        }
    }
}
