using System;
using Microsoft.MobileBlazorBindings;
using Microsoft.Extensions.Hosting;
using Xamarin.Essentials;
using Xamarin.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace MobileBlazorAdvanced
{
    public class App : Application
    {
        public IHost AppHost { get; }

        public App(string[] args = null, IServiceCollection additionalServices = null)
        {
            AppHost = MobileBlazorBindingsHost.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    // Register app-specific services
                    //services.AddSingleton<AppState>();
                    if(additionalServices!=null)
                    {
                        services.AddAdditionalServices(additionalServices);
                    }

                })
                .Build();

            MainPage = new ContentPage();
            AppHost.AddComponent<HelloWorld>(parent: MainPage);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
