using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fpDeepDive.models;

namespace fpDeepDive.services
{
  public class ShippingDetails
  {
    public double ShipCost { get; set; }
    public string DestinationState { get; set; }
    public DateTime EstimatedArrival { get; set; }
  }
  public static class ShippingService
  {
    public static ShippingDetails GetDetails(Order order)
    {
      return new ShippingDetails()
      {
        DestinationState = "WA",
        EstimatedArrival = DateTime.Now.AddDays(3),
        ShipCost = 12.20
      };
    }
  }
}