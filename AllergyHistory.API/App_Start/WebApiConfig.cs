using AllergyHistory.Contract.Converters;
using AllergyHistory.DAL.Repositories;
using AllergyHistory.Domain.Entities;
using AllergyHistory.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Unity;

namespace AllergyHistory.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            var container = new UnityContainer();

            container.RegisterType<IRepository<Patient>, PatientRepository>();
            container.RegisterType<IRepository<AllergenHistory>, AllegenHistoryRepository>();
            container.RegisterType<IRepository<AllergenSeverity>, AllergenSeverityRepository>();
            container.RegisterType<IRepository<AllergenType>, AllergenTypeRepository>();
            container.RegisterType<IRepository<AllergenReaction>, AllergenReactionRepository>();
            container.RegisterType<IRepository<Allergen>, AllergenRepository>();
            container.RegisterType<IRepository<Drug>, DrugRepository>();

            container.RegisterType<IAllergenInputConverter, AllergenInputConverter>();
            container.RegisterType<IAllergyHistoryConverter, AllergyHistoryConverter>();
            container.RegisterType<IAllergenInputService, AllergenInputService>();
            container.RegisterType<IAllergyHistoryDataService, AllergyHistoryDataService>();


            config.DependencyResolver = new UnityResolver(container);
        }
    }
}
