﻿using Windows.UI.Xaml.Controls;
using MvvmCross.Core.ViewModels;
using MvvmCross.WindowsUWP.Platform;

namespace MobileClient.UI.UWP
{
  public class Setup : MvxWindowsSetup
  {
    public Setup(Frame rootFrame) : base(rootFrame)
    {
    }

    protected override IMvxApplication CreateApp()
    {
      return new Core.App();
    }
  }
}