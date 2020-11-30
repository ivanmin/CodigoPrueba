using API;
using API.Data;
using API.Services;
using ModulePopupInfoPeople.ViewModels;
using ModulePopupInfoPeople.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;

namespace ModulePopupInfoPeople
{
    public class InfoModule : IModule
    {

        private readonly IRegionManager _regionManager;

        public InfoModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion("ContentRegion", typeof(PeopleControl));
            
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            ViewModelLocationProvider.Register<PeopleControl, PeopleControlViewModel>();
            containerRegistry.RegisterSingleton<IInformationService, InformationService>();
        }
    }
}
