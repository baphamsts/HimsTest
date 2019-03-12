using System;
using System.Collections.Generic;
using System.Linq;
using AllergyHistory.Contract.ViewModels;
using AllergyHistory.Domain.Entities;

namespace AllergyHistory.Contract.Converters
{
    public class AllergenInputConverter : IAllergenInputConverter
    {
     

        public AllergenSeverityViewModel Convert(AllergenSeverity allergenSeverity)
        {
            try
            {
                AllergenSeverityViewModel allergenSeverityViewModel = null;

                if (allergenSeverity != null)
                {
                    allergenSeverityViewModel = new AllergenSeverityViewModel();
                    allergenSeverityViewModel.CodeId = allergenSeverity.Id;
                    allergenSeverityViewModel.CodeDesc = allergenSeverity.Desc;
                    allergenSeverityViewModel.CodeValue = allergenSeverity.Value;
                    allergenSeverityViewModel.TypeId = allergenSeverity.TypeId;
                    
                }

                return allergenSeverityViewModel;
            }
            catch (Exception exception)
            {
                throw new Exception("Convert allergenSeverity > allergenSeverityViewModel failed!", exception);
            }
        }

        public List<AllergenSeverityViewModel> Convert(IEnumerable<AllergenSeverity> AllergenSeverities)
        {
            List<AllergenSeverityViewModel> AllergenSeverityViewModels = new List<AllergenSeverityViewModel>();

            if (AllergenSeverities != null)
            {
                AllergenSeverities
                    .ToList()
                    .ForEach(c => AllergenSeverityViewModels.Add(Convert(c)));
            }

            return AllergenSeverityViewModels;
        }


        public AllergenReactionViewModel Convert(AllergenReaction allergenReaction)
        {
            try
            {
                AllergenReactionViewModel allergenReactionViewModel = null;

                if (allergenReaction != null)
                {
                    allergenReactionViewModel = new AllergenReactionViewModel();
                    allergenReactionViewModel.CodeId = allergenReaction.Id;
                    allergenReactionViewModel.CodeDesc = allergenReaction.Desc;
                    allergenReactionViewModel.CodeValue = allergenReaction.Value;
                    allergenReactionViewModel.TypeId = allergenReaction.TypeId;

                }

                return allergenReactionViewModel;
            }
            catch (Exception exception)
            {
                throw new Exception("Convert allergenReaction > allergenReactionViewModel failed!", exception);
            }
        }

        public List<AllergenReactionViewModel> Convert(IEnumerable<AllergenReaction> allergenReactions)
        {
            List<AllergenReactionViewModel> allergenReactionsViewModels = new List<AllergenReactionViewModel>();

            if (allergenReactions != null)
            {
                allergenReactions
                    .ToList()
                    .ForEach(c => allergenReactionsViewModels.Add(Convert(c)));
            }

            return allergenReactionsViewModels;
        }



        public AllergenTypeViewModel Convert(AllergenType allergenType)
        {
            try
            {
                AllergenTypeViewModel allergenTypeViewModel = null;

                if (allergenType != null)
                {
                    allergenTypeViewModel = new AllergenTypeViewModel();
                    allergenTypeViewModel.CodeId = allergenType.Id;
                    allergenTypeViewModel.CodeDesc = allergenType.Desc;
                    allergenTypeViewModel.CodeText = allergenType.Text;
                    allergenTypeViewModel.CodeValue = allergenType.Value;
                    allergenTypeViewModel.TypeId = allergenType.TypeId;

                }

                return allergenTypeViewModel;
            }
            catch (Exception exception)
            {
                throw new Exception("Convert allergenType > allergenTypeViewModel failed!", exception);
            }
        }

        public List<AllergenTypeViewModel> Convert(IEnumerable<AllergenType> alergenTypes)
        {
            List<AllergenTypeViewModel> AllergenTypeViewModels = new List<AllergenTypeViewModel>();

            if (alergenTypes != null)
            {
                alergenTypes
                    .ToList()
                    .ForEach(c => AllergenTypeViewModels.Add(Convert(c)));
            }

            return AllergenTypeViewModels;
        }




        public AllergenViewModel Convert(Allergen allergen)
        {
            try
            {
                AllergenViewModel allergenViewModel = null;

                if (allergen != null)
                {
                    allergenViewModel = new AllergenViewModel();
                    allergenViewModel.CodeId = allergen.Id;
                    allergenViewModel.CodeDesc = allergen.Desc;
                    allergenViewModel.CodeText = allergen.Text;
                    allergenViewModel.TypeId = allergen.TypeId;

                }

                return allergenViewModel;
            }
            catch (Exception exception)
            {
                throw new Exception("Convert allergenSeverity > allergenSeverityViewModel failed!", exception);
            }
        }

        public List<AllergenViewModel> Convert(IEnumerable<Allergen> Allergens)
        {
            List<AllergenViewModel> AllergenViewModels = new List<AllergenViewModel>();

            if (Allergens != null)
            {
                Allergens
                    .ToList()
                    .ForEach(c => AllergenViewModels.Add(Convert(c)));
            }

            return AllergenViewModels;
        }



        public MedicationViewModel Convert(Drug drug)
        {
            try
            {
                MedicationViewModel medicationViewModel = null;

                if (drug != null)
                {
                    medicationViewModel = new MedicationViewModel();
                    medicationViewModel.DrugId = drug.Id;
                    medicationViewModel.DrugName = drug.DrugName;
                    medicationViewModel.LexiDrugId = drug.LexiDrugId;

                }

                return medicationViewModel;
            }
            catch (Exception exception)
            {
                throw new Exception("Convert drug > medicationViewModel failed!", exception);
            }
        }

        public List<MedicationViewModel> Convert(IEnumerable<Drug> drugs)
        {
            List<MedicationViewModel> medicationViewModels = new List<MedicationViewModel>();

            if (drugs != null)
            {
                drugs
                    .ToList()
                    .ForEach(c => medicationViewModels.Add(Convert(c)));
            }

            return medicationViewModels;
        }


        /*
                public AllergenSeverity Convert(AllergenSeverityViewModel allergenSeverityViewModel)
                {
                    try
                    {
                        AllergenSeverity allergenSeverity = null;

                        if (allergenSeverityViewModel != null)
                        {
                            //allergenSeverity = new AllergenSeverity();
                            //allergenSeverity.Id = allergenSeverityViewModel.Id;
                            //allergenSeverity.FirstName = allergenSeverityViewModel.FirstName;
                            //allergenSeverity.LastName = allergenSeverityViewModel.LastName;
                            //allergenSeverity.AccessToken = allergenSeverityViewModel.AccessToken;
                            //allergenSeverity.Role = allergenSeverityViewModel.Role;
                            //allergenSeverity.CreatedAt = allergenSeverityViewModel.CreatedAt;
                            //allergenSeverity.CreatedBy = allergenSeverityViewModel.CreatedBy;
                            //allergenSeverity.UpdatedAt = allergenSeverityViewModel.UpdatedAt;
                            //allergenSeverity.UpdatedBy = allergenSeverityViewModel.UpdatedBy;
                            //allergenSeverity.DocumentVersion = allergenSeverityViewModel.DocumentVersion;
                        }

                        return allergenSeverity;
                    }
                    catch (Exception exception)
                    {
                        throw new Exception("Convert allergenSeverityViewModel > allergenSeverity failed!", exception);
                    }
                }

                public List<AllergenSeverity> Convert(List<AllergenSeverityViewModel> AllergenSeverityViewModels)
                {
                    List<AllergenSeverity> AllergenSeverities = new List<AllergenSeverity>();

                    if (AllergenSeverityViewModels != null)
                    {
                        AllergenSeverityViewModels.ForEach(c => AllergenSeverities.Add(Convert(c)));
                    }

                    return AllergenSeverities;
                }

                public AllergenSeverity Patch(AllergenSeverityViewModel allergenSeverityViewModel, AllergenSeverity allergenSeverity)
                {
                    if (allergenSeverity != null)
                    {
                        //PatchHelper.Patch(allergenSeverityViewModel, allergenSeverity);

                        return allergenSeverity;
                    }

                    return null;
                }*/
    }
}
