using System;
using System.Collections.Generic;
using System.Linq;
using AllergyHistory.Contract.DTOs;
using AllergyHistory.Contract.ViewModels;
using AllergyHistory.Domain.Entities;

namespace AllergyHistory.Contract.Converters
{
    public class AllergyHistoryConverter : IAllergyHistoryConverter
    {

        public AllergenHistoryDTO Convert(AllergenHistory alergenHistory)
        {
            try
            {
                AllergenHistoryDTO allergenHistoryDTO = null;

                if (alergenHistory != null)
                {
                    allergenHistoryDTO = new AllergenHistoryDTO();

                    allergenHistoryDTO.ClientId = alergenHistory.PatientId;
                    allergenHistoryDTO.ClientName = alergenHistory.PatientName;
                    allergenHistoryDTO.CISId = alergenHistory.CISId;
                    allergenHistoryDTO.DOB = alergenHistory.DOB;
                    allergenHistoryDTO.Gender = alergenHistory.Gender;
                    allergenHistoryDTO.Provider = alergenHistory.Provider;
                    allergenHistoryDTO.Population = alergenHistory.Population;
                    allergenHistoryDTO.AxisI = alergenHistory.AxisI;
                    allergenHistoryDTO.AxisIDesc = alergenHistory.AxisIDesc;
                    allergenHistoryDTO.ClientAllergyId = alergenHistory.ClientAllergyId;
                    allergenHistoryDTO.Allergen = alergenHistory.Allergen;
                    allergenHistoryDTO.Notes = alergenHistory.Notes;
                    allergenHistoryDTO.CreateUser = alergenHistory.CreateUser;
                    allergenHistoryDTO.CreateDate = alergenHistory.CreateDate;
                    allergenHistoryDTO.UpdateUser = alergenHistory.UpdateUser;
                    allergenHistoryDTO.UpdateDate = alergenHistory.UpdateDate;
                    allergenHistoryDTO.Deleted = alergenHistory.Deleted;
                    allergenHistoryDTO.AllergenId = alergenHistory.AllergenId;
                    allergenHistoryDTO.AllergenType = alergenHistory.AllergenType;
                    allergenHistoryDTO.ReactionId = alergenHistory.ReactionId;
                    allergenHistoryDTO.SeverityId = alergenHistory.SeverityId;
                    allergenHistoryDTO.ReactionDesc = alergenHistory.ReactionDesc;
                    allergenHistoryDTO.SeverityDesc = alergenHistory.SeverityDesc;
                    allergenHistoryDTO.Type = alergenHistory.Type;
                    allergenHistoryDTO.DrugName = alergenHistory.DrugName;
                    allergenHistoryDTO.CreateDateWithTime = alergenHistory.CreateDateWithTime;
                    allergenHistoryDTO.UpdateDateWithTime = alergenHistory.UpdateDateWithTime;
                }

                return allergenHistoryDTO;
            }
            catch (Exception exception)
            {
                throw new Exception("Convert allergenSeverity > allergenSeverityViewModel failed!", exception);
            }
        }

        public List<AllergenHistoryDTO> Convert(IEnumerable<AllergenHistory> alergenHistories)
        {
            List<AllergenHistoryDTO> allergenHistoryDTOs = new List<AllergenHistoryDTO>();

            if (alergenHistories != null)
            {
                alergenHistories
                    .ToList()
                    .ForEach(c => allergenHistoryDTOs.Add(Convert(c)));
            }

            return allergenHistoryDTOs;
        }
    }
}
