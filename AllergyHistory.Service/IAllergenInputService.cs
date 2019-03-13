using AllergyHistory.Contract.ViewModels;
using System.Collections.Generic;

namespace AllergyHistory.Services
{
    public interface IAllergenInputService
    {

        string FakeDataFolderPath { get; set; }

        string GetAllAllergenSeverityXml();
        string GetAllAllergenTypeXml();
        string GetAllAllergenXml();
        string GetAllAllergenReactionXml();
        string GetAllMedicationXml();

    }
}
