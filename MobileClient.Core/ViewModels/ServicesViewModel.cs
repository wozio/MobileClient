using MobileClient.Core.Services;
using MvvmCross.Core.ViewModels;
using System;

namespace MobileClient.Core.ViewModels
{
  public class ServicesViewModel : MvxViewModel
  {
    readonly IDiscovery _discovery;
    public ServicesViewModel(IDiscovery discovery)
    {
      _discovery = discovery;

    }

    public override void Start()
    {
      Service = _discovery.get();
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