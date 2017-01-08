using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MobileClient.Core.ViewModels;

namespace MobileClient.Core
{
  public class App : MvxApplication
  {
    public App()
    {
      Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<ServicesViewModel>());
    }
  }
}