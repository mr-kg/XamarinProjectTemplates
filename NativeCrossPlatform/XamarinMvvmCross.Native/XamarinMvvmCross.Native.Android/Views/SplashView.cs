using Android.App;
using MvvmCross.Droid.Views;

namespace $safeprojectname$.Views
{
    [Activity(Label = "Splash", MainLauncher = true)]
    public class SplashView : MvxActivity
    {
        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Splash);
        }
    }
}