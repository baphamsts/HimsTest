using AllergyHistory.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AllergyHistory.DAL.Repositories
{
    public class AllergenTypeRepository : IRepository<AllergenType>
    {
        readonly AllergyHistoryContext dbContext;

        public AllergenTypeRepository(AllergyHistoryContext context)
        {
            this.dbContext = context;
        }

        public IEnumerable<AllergenType> GetAll()
        {
            var fakeData = GenerateFakeData();
            return fakeData;

            //return dbContext.AllegenHistories.ToList();
        }

        public IQueryable<AllergenType> GetAll_Q()
        {
            //return dbContext.AllegenHistories.AsQueryable();
            return null;

        }

        public AllergenType Get(long id)
        {
            //return dbContext.AllegenHistories
            //      .FirstOrDefault(e => e.AllegenHistoryId == id);

            return null;

        }

        public void Add(AllergenType entity)
        {
            //dbContext.AllegenHistories.Add(entity);
            //dbContext.SaveChanges();
        }

        public void Update(AllergenType allegenHistory, AllergenType entity)
        {
            //dbContext.SaveChanges();
        }

        public void Delete(AllergenType allergenHistory)
        {
           
        }

        public string GetAllXml()
        {
            var xmlContent = File.ReadAllText(@"Data/Input/AllergenTypeDropdown.xml");
            return xmlContent;
        }

        /// <summary>
        /// This generate fake Domain data, considering that in this do main Enties, we call client is patient.
        /// </summary>
        /// <returns></returns>
        private IEnumerable<AllergenType>  GenerateFakeData()
        {
            var data = new List<AllergenType> {
                new AllergenType
                {
                    Id = 1,
                    Desc = "Allergen",
                    Text = "Allergen",
                    Value = 1,
                    TypeId = 1,
                },

                new AllergenType
                {
                    Id = 2,
                    Desc = "Medication",
                    Text = "Medication",
                    Value = 2,
                    TypeId = 2,
                },

                new AllergenType
                {
                    Id = 3,
                    Desc = "No Known Allergies",
                    Text = "No Known Allergies",
                    Value = 3,
                    TypeId = 3,
                },

                new AllergenType
                {
                    Id = 4,
                    Desc = "Other",
                    Text = "Other",
                    Value = 4,
                    TypeId = 4,
                },
            };

            return data;
        }
    }
}
