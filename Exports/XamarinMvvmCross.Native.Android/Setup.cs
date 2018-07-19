using Android.Content;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;
using $rootnamespace$.Native.Core;

namespace $safeprojectname$
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext)
        : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
			// Please add a reference to {ProjectName}.Native.Core in order to resolve this ref
            return new App();
        }
    }
}