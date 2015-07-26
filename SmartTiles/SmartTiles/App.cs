using SmartTiles.Services;
using SmartTiles.ViewModels;
using SmartTiles.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using XLabs.Forms.Mvvm;
using XLabs.Ioc;

namespace SmartTiles
{
    public class App : Application
    {
        public App()
        {
            
            SetupIoc();
            RegisterViews();

            // The root page of your application
            MainPage = new NavigationPage((Page)ViewFactory.CreatePage<MainViewModel, MainPage>());
        }

        private void SetupIoc()
        {
            var container = new SimpleContainer();

            //Register services
            container.Register<ISettingsService, SettingsService>();
            container.Register<IHttpService>(r =>
            {
                var settings = r.Resolve<ISettingsService>();
                return new HttpService(settings.SmartAppUrl, settings.AccessToken);
            });
            container.Register<ITemperatureDevicesService>(r => new TemperatureDevicesService(r.Resolve<IHttpService>()));
            container.Register<ISwitchDevicesService>(r => new SwitchDevicesService(r.Resolve<IHttpService>()));

            //Register ViewModels
            container.Register<MainViewModel>(r => new MainViewModel(r.Resolve<ITemperatureDevicesService>()));

            Resolver.SetResolver(container.GetResolver());
        }

        private void RegisterViews()
        {
            ViewFactory.Register<MainPage, MainViewModel>();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
