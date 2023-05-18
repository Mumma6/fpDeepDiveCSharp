using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.Immutable;


namespace fpDeepDive.models
{
  public record Order
  {
    public ImmutableList<OrderItem> Items { get; init; }
    public Customer Customer { get; init; }
    public string ShippingState { get; init; }
    public int OrderNumber { get; init; }
    public DateTime OrderDate { get; init; }
    public DateTime EstimatedArrival { get; init; }
    public double ShippingCost { get; init; }
    public double Total { get; init; }
  }
}