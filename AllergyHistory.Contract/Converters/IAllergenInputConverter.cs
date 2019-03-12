using System;
using System.Collections.Generic;
using System.Linq;
using AllergyHistory.Contract.ViewModels;
using AllergyHistory.Domain.Entities;

namespace AllergyHistory.Contract.Converters
{
    public interface IAllergenInputConverter
    {
        /// <summary>
        /// Convert AllergenSeverity to AllergenSeverityViewModel
        /// </summary>
        /// <param name="allergenSeverity">The AllergenSeverity</param>
        /// <returns>The AllergenSeverityViewModel</returns>
        AllergenSeverityViewModel Convert(AllergenSeverity allergenSeverity);

        /// <summary>
        /// Convert AllergenType to AllergenTypeViewModel
        /// </summary>
        /// <param name="allergenSeverity">The AllergenType</param>
        /// <returns>The AllergenTypeViewModel</returns>
        AllergenTypeViewModel Convert(AllergenType allergenType);

        /// <summary>
        /// Convert Allergen to AllergenViewModel
        /// </summary>
        /// <param name="allergen">The Allergen</param>
        /// <returns>The AllergenTypeViewModel</returns>
        AllergenViewModel Convert(Allergen allergen);


        /// <summary>
        /// Convert AllergenReaction to AllergenReactioneViewModel
        /// </summary>
        /// <param name="allergenReaction">The AllergenReaction</param>
        /// <returns>The AllergenReactionViewModel</returns>
        AllergenReactionViewModel Convert(AllergenReaction allergenReaction);


        /// <summary>
        /// Convert Drug to AllergenTypeViewModel
        /// </summary>
        /// <param name="drug">The Drug</param>
        /// <returns>The MedicationViewModel</returns>
        MedicationViewModel Convert(Drug drug);

        /// <summary>
        /// Convert List of allergenSeverities to List of allergenSeverityViewModel
        /// </summary>
        /// <param name="allergenSeverities">The list of allergenSeverities</param>
        /// <returns>The list of allergenSeverityViewModel</returns>
        List<AllergenSeverityViewModel> Convert(IEnumerable<AllergenSeverity> allergenSeverities);

        List<AllergenTypeViewModel> Convert(IEnumerable<AllergenType> allergenTypes);

        List<AllergenReactionViewModel> Convert(IEnumerable<AllergenReaction> allergenReactions);

        List<AllergenViewModel> Convert(IEnumerable<Allergen> allergens);
        List<MedicationViewModel> Convert(IEnumerable<Drug> drugs);

        /*
                /// <summary>
                /// Convert AllergenSeverityViewModel to AllergenSeverity
                /// </summary>
                /// <param name="allergenSeverityViewModel">The AllergenSeverityViewModel</param>
                /// <returns>The AllergenSeverity</returns>
                AllergenSeverity Convert(AllergenSeverityViewModel allergenSeverityViewModel);

                /// <summary>
                /// Convert List of allergenSeverityViewModel to List of allergenSeverities
                /// </summary>
                /// <param name="allergenSeverityViewModel">The list of allergenSeverityViewModel</param>
                /// <returns>The list of allergenSeverities</returns>
                List<AllergenSeverity> Convert(List<AllergenSeverityViewModel> allergenSeverityViewModel);


                /// <summary>
                /// Convert AllergenSeverityViewModel to AllergenSeverity
                /// </summary>
                /// <param name="allergenSeverityViewModel">The AllergenSeverityViewModel</param>
                /// <returns>The AllergenSeverity</returns>
                AllergenSeverity Patch(AllergenSeverityViewModel allergenSeverityViewModel, AllergenSeverity allergenSeverity);

                This is for create update only
        */
    }
}
