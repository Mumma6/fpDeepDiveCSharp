using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fpDeepDive.models
{
  public class OrderItem
  {
    public Item Item { get; private set; }
    public int Quantity { get; private set; }

    public OrderItem(Item Item, int Quantity)
    {
      this.Item = Item;
      this.Quantity = Quantity;
    }
  }
}