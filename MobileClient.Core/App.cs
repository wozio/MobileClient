using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using MobileClient.Core.ViewModels;
using MobileClient.Core.Services;

namespace MobileClient.Core
{
  public class App : MvxApplication
  {
    public App()
    {
      Mvx.RegisterType<IDiscovery, Discovery>();
      Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<ServicesViewModel>());
    }
  }
}