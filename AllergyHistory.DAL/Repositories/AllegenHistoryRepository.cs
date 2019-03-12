using AllergyHistory.Domain.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AllergyHistory.DAL.Repositories
{
    public class AllegenHistoryRepository : IRepository<AllergenHistory>
    {
        readonly AllergyHistoryContext dbContext;

        public AllegenHistoryRepository(AllergyHistoryContext context)
        {
            this.dbContext = context;
        }

        public IEnumerable<AllergenHistory> GetAll()
        {
            var fakeData = generateFakeData();
            return fakeData;

            //return dbContext.AllegenHistories.ToList();
        }

        public IQueryable<AllergenHistory> GetAll_Q()
        {
            //return dbContext.AllegenHistories.AsQueryable();
            return null;

        }

        public AllergenHistory Get(long id)
        {
            //return dbContext.AllegenHistories
            //      .FirstOrDefault(e => e.AllegenHistoryId == id);

            return null;

        }

        public void Add(AllergenHistory entity)
        {
            //dbContext.AllegenHistories.Add(entity);
            //dbContext.SaveChanges();
        }

        public void Update(AllergenHistory allegenHistory, AllergenHistory entity)
        {
            //dbContext.SaveChanges();
        }

        public void Delete(AllergenHistory allergenHistory)
        {
           
        }

        public string GetAllXml()
        {
            var xmlContent = File.ReadAllText(@"Data/History/HistoryData.xml");
            return xmlContent;
        }

        /// <summary>
        /// This generate fake Domain data, considering that in this do main Enties, we call client is patient.
        /// </summary>
        /// <returns></returns>
        private IEnumerable<AllergenHistory>  generateFakeData()
        {
            var data = new List<AllergenHistory>();

            var fakeDomainEntity = new AllergenHistory();
            fakeDomainEntity.Id                 = 1;
            fakeDomainEntity.PatientId          = 1;
            fakeDomainEntity.PatientName        = "Test Name ";
            fakeDomainEntity.CISId              = "0742031237";
            fakeDomainEntity.DOB                = DateTime.Now;
            fakeDomainEntity.Gender             = "Male";
            fakeDomainEntity.Provider           = "Redcedar";
            fakeDomainEntity.Population         = "Adult";
            fakeDomainEntity.AxisI              = "F25.0";
            fakeDomainEntity.AxisIDesc          = "Disoder";
            fakeDomainEntity.ClientAllergyId    = 1;
            fakeDomainEntity.Allergen           = "Reveal Blood";
            fakeDomainEntity.Notes              = "Test notes";
            fakeDomainEntity.CreateUser         = "User 1";
            fakeDomainEntity.CreateDate         = DateTime.Now;
            fakeDomainEntity.UpdateUser         = "User 2";
            fakeDomainEntity.UpdateDate         = DateTime.Now;
            fakeDomainEntity.Deleted            = false;
            fakeDomainEntity.AllergenId         = 1;
            fakeDomainEntity.AllergenType       = 1;
            fakeDomainEntity.ReactionId         = 1;
            fakeDomainEntity.SeverityId         = 1;
            fakeDomainEntity.ReactionDesc       = "Diarrhea";
            fakeDomainEntity.SeverityDesc       = "Life Threatening";
            fakeDomainEntity.Type               = "Medication";
            fakeDomainEntity.DrugName           = "Vitro Strip";
            fakeDomainEntity.CreateDateWithTime = DateTime.Now;
            fakeDomainEntity.UpdateDateWithTime = DateTime.Now;

            for (int i = 0; i < 10; i++)
            {
                // Dummy some differ data to observe
                var temp = new AllergenHistory();
                temp.Id                 = fakeDomainEntity.Id;
                temp.PatientId          = fakeDomainEntity.PatientId;
                temp.PatientName        = fakeDomainEntity.PatientName;
                temp.CISId              = fakeDomainEntity.CISId;
                temp.DOB                = fakeDomainEntity.DOB;
                temp.Gender             = fakeDomainEntity.Gender;
                temp.Provider           = fakeDomainEntity.Provider;
                temp.Population         = fakeDomainEntity.Population;
                temp.AxisI              = fakeDomainEntity.AxisI;
                temp.AxisIDesc          = fakeDomainEntity.AxisIDesc;
                temp.ClientAllergyId    = fakeDomainEntity.ClientAllergyId;
                temp.Allergen           = fakeDomainEntity.Allergen;
                temp.Notes              = fakeDomainEntity.Notes;
                temp.CreateUser         = fakeDomainEntity.CreateUser;
                temp.CreateDate         = fakeDomainEntity.CreateDate;
                temp.UpdateUser         = fakeDomainEntity.UpdateUser;
                temp.UpdateDate         = fakeDomainEntity.UpdateDate;
                temp.Deleted            = fakeDomainEntity.Deleted;
                temp.AllergenId         = fakeDomainEntity.AllergenId;
                temp.AllergenType       = fakeDomainEntity.AllergenType;
                temp.ReactionId         = fakeDomainEntity.ReactionId;
                temp.SeverityId         = fakeDomainEntity.SeverityId;
                temp.ReactionDesc       = fakeDomainEntity.ReactionDesc;
                temp.SeverityDesc       = fakeDomainEntity.SeverityDesc;
                temp.Type               = fakeDomainEntity.Type;
                temp.DrugName           = fakeDomainEntity.DrugName;
                temp.CreateDateWithTime = fakeDomainEntity.CreateDateWithTime;
                temp.UpdateDateWithTime = fakeDomainEntity.UpdateDateWithTime;


                for (int j = 0; j < 10; j++)
                {
                    data.Add(temp);
                }
            }

            return data;
        }
    }
}
