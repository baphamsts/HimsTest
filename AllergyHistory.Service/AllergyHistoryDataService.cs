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

        public string GetAllAllergenHistoryXml()
        {
            return allergenHistoryRepository.GetAllXml();
        }
    }
}
