using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fpDeepDive.models;

namespace fpDeepDive.services
{
  public static class OrderServices
  {
    public static double GetTotal(Order order, List<TaxRate> taxRates, Func<List<TaxRate>, string, double> taxRater)
    {
      // local function
      double subTotal(OrderItem item) => item.Item.Price * item.Quantity;

      return order.Items.Sum(orderItem => orderItem.Item.Taxable ? subTotal(orderItem) + taxRater(taxRates, order.ShippingState) : subTotal(orderItem));
    }

    public static Order UpdateOrderShipDetails(Order order)
    {
      var shipDetails = ShippingService.GetDetails(order);
      return order with
      {
        ShippingState = shipDetails.DestinationState,
        EstimatedArrival = shipDetails.EstimatedArrival,
        ShippingCost = shipDetails.ShipCost
      };
    }
  }
}