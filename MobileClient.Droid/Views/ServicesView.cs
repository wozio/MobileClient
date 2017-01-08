using Android.App;
using MvvmCross.Droid.Views;

namespace MobileClient.Droid.Views
{
  [Activity(Label = "@string/ApplicationName", MainLauncher = true)]
  public class ServicesView : MvxActivity
  {
    protected override void OnViewModelSet()
    {
      SetContentView(Resource.Layout.View_Services);
    }
  }
}