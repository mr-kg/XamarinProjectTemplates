using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using System;
using System.Collections.Generic;
using System.Text;

namespace $safeprojectname$
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            // Add IoC types here
            Mvx.RegisterType<IApiService, ApiService>();

            // Construct custom application start object
            Mvx.ConstructAndRegisterSingleton<IMvxAppStart, AppStart>();

            // request a reference to the constructed appstart object 
            var appStart = Mvx.Resolve<IMvxAppStart>();

            // register the appstart object
            RegisterAppStart(appStart);
        }
    }
}
