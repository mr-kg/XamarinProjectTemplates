using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using $safeprojectname$.ViewModels;

namespace $safeprojectname$
{
    public class AppStart : MvxNavigatingObject, IMvxAppStart
    {
        public void Start(object hint = null)
        {
            ShowViewModel<SplashScreenViewModel>();
        }
    }
}
