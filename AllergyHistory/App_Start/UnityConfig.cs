using AllergyHistory.Contract.Converters;
using AllergyHistory.DAL;
using AllergyHistory.DAL.Repositories;
using AllergyHistory.Domain.Entities;
using AllergyHistory.Services;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace AllergyHistory
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            //container.RegisterType<AllergyHistoryContext>(opts => opts.UseSqlServer(Configuration["ConnectionStrings:AllergyHistoyDB"]));
            container.RegisterType<IRepository<AllergenHistory>, AllegenHistoryRepository>();
            container.RegisterType<IAllergyHistoryConverter, AllergyHistoryConverter>();
            container.RegisterType<IAllergyHistoryDataService, AllergyHistoryDataService>();
            container.RegisterType<IRevokeApiService, RevokeApiService>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}