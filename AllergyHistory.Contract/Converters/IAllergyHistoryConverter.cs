using System.Collections.Generic;
using AllergyHistory.Contract.DTOs;
using AllergyHistory.Contract.ViewModels;
using AllergyHistory.Domain.Entities;

namespace AllergyHistory.Contract.Converters
{
    public interface IAllergyHistoryConverter
    {

        /// <summary>
        /// Convert AllergenHistory to AllergenHistoryDTO
        /// </summary>
        /// <param name="alergenHistory">The AllergenHistory</param>
        /// <returns>The AllergenHistoryDTO</returns>
        AllergenHistoryDTO Convert(AllergenHistory alergenHistory);

        /// <summary>
        /// Convert List of AllergenHistory to List of AllergenHistoryDTO
        /// </summary>
        /// <param name="alergenHistories">The list of AllergenHistory</param>
        /// <returns>The list of AllergenHistoryDTO</returns>
        List<AllergenHistoryDTO> Convert(IEnumerable<AllergenHistory> alergenHistories);
    }
}
