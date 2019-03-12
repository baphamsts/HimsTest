using AllergyHistory.Contract.Converters;
using AllergyHistory.Contract.DTOs;
using AllergyHistory.Contract.ViewModels;
using AllergyHistory.DAL.Repositories;
using AllergyHistory.Domain.Entities;
using System.Collections.Generic;

namespace AllergyHistory.Services
{
   
    public class AllergyHistoryDataService : IAllergyHistoryDataService
    {
        private readonly IRepository<AllergenHistory> allergenHistoryRepository;
        private readonly IAllergyHistoryConverter conveter;

        public AllergyHistoryDataService(IRepository<AllergenHistory> allergenHistoryRepository, IAllergyHistoryConverter conveter)
        {
            this.allergenHistoryRepository = allergenHistoryRepository;
            this.conveter = conveter;
        }

        public IEnumerable<AllergenHistoryDTO> GetAllAllergenHistory()
        {
            var domainEntityData = allergenHistoryRepository.GetAll();

            var viewModelData = conveter.Convert(domainEntityData);

            return viewModelData;
        }

        public string GetAllAllergenHistoryXml()
        {
            return allergenHistoryRepository.GetAllXml();
        }

        public IEnumerable<AllergenHistoryDataTableViewModel> GetAll()
        {
            /// Fake data here
            /// 
            
            var data = new List<AllergenHistoryDataTableViewModel>();

            var originFakeData = new AllergenHistoryDataTableViewModel();
            originFakeData.Patient = "Patient";
            originFakeData.Type = "Medication";
            originFakeData.Allergen = "Amoxicillin";
            originFakeData.Reaction = "Anaphylaxis";
            originFakeData.Serverty = "Life Threatening";
            originFakeData.Notes = "Test 123";
            originFakeData.CreateInfo = "Created on 12/17/2018 by Stner";
            originFakeData.UpdateInfo = "updated on 2/18/2019 by Rgarcia";

            for(int i = 0; i < 10; i++)
            {
                // Dummy some differ data to observe
                var temp = new AllergenHistoryDataTableViewModel();
                temp.Patient = originFakeData.Patient + (i+1).ToString();
                temp.Type = i % 2 == 0 ? "Medication" : "Allegen";
                temp.Allergen = "Amoxicillin";
                temp.Reaction = "Anaphylaxis";
                temp.Serverty = "Life Threatening";
                temp.Notes = "Test";
                temp.CreateInfo = "Created on 12/17/2018 by X";
                temp.UpdateInfo = "updated on 2/18/2019 by Y";
                for (int j = 0; j < 10; j++)
                {
                    data.Add(temp);
                }
            }

            return data;
        }
    }
}
