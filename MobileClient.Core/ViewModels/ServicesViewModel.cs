using MvvmCross.Core.ViewModels;
using System;

namespace MobileClient.Core.ViewModels
{
  public class ServicesViewModel : MvxViewModel
  {
    public ServicesViewModel()
    {
    }

    public override void Start()
    {
      Service = "DUPA!";
      base.Start();
    }

    String _service;

    public String Service
    {
      get { return _service; }
      set
      {
        _service = value;
        RaisePropertyChanged(() => Service);
      }
    }

  
  }
}