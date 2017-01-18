using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileClient.Core.Services
{
  public interface IDiscovery
  {
    event EventHandler ServiceAvailability;
  }

  public class ServiceAvailabilityData : EventArgs
  {

  }
}
