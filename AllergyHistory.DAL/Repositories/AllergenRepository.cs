using AllergyHistory.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AllergyHistory.DAL.Repositories
{
    public class AllergenRepository : IRepository<Allergen>
    {
        readonly AllergyHistoryContext dbContext;

        public AllergenRepository(AllergyHistoryContext context)
        {
            this.dbContext = context;
        }
        
        public IEnumerable<Allergen> GetAll()
        {
            var fakeData = GenerateFakeData();
            return fakeData;

            //return dbContext.AllegenHistories.ToList();
        }

        public IQueryable<Allergen> GetAll_Q()
        {
            //return dbContext.AllegenHistories.AsQueryable();
            return null;

        }

        public Allergen Get(long id)
        {
            //return dbContext.AllegenHistories
            //      .FirstOrDefault(e => e.AllegenHistoryId == id);

            return null;

        }

        public void Add(Allergen entity)
        {
            //dbContext.AllegenHistories.Add(entity);
            //dbContext.SaveChanges();
        }

        public void Update(Allergen allegenHistory, Allergen entity)
        {
            //dbContext.SaveChanges();
        }

        public void Delete(Allergen allergenHistory)
        {
           
        }

        public string GetAllXml()
        {
            var xmlContent = File.ReadAllText(@"Data/Input/AllergenDropdown.xml");
            return xmlContent;
        }


        /// <summary>
        /// This generate fake Domain data, considering that in this do main Enties, we call client is patient.
        /// </summary>
        /// <returns></returns>
        private IEnumerable<Allergen>  GenerateFakeData()
        {
            var data = new List<Allergen> {
                new Allergen
                {
                    Id = 1,
                    Desc = "Aminoglycoside Antibiotics",
                    Text = "Aminoglycoside Antibiotics",
                    TypeId = 1,
                },

                new Allergen
                {
                    Id = 2,
                    Desc = "Anesthesia",
                    Text = "Anesthesia",
                    TypeId = 2,
                },

                new Allergen
                {
                    Id = 3,
                    Desc = "Epinephrine",
                    Text = "Epinephrine",
                    TypeId = 3,
                },

                new Allergen
                {
                    Id = 4,
                    Desc = "Lidocaine",
                    Text = "Lidocaine",
                    TypeId = 4,
                },

                new Allergen
                {
                    Id = 5,
                    Desc = "Novocaine",
                    Text = "Novocaine",
                    TypeId = 5,
                },
            };

            return data;
        }
    }
}
