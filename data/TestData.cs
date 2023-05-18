using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fpDeepDive.models;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace fpDeepDive.data
{
  public class TestData
  {
    public static List<TaxRate> TaxRates => new List<TaxRate>() {
            new TaxRate() {
                State = "CA",
                Rate = 8
            },
            new TaxRate() {
                State = "AZ",
                Rate = 7
            },
            new TaxRate() {
                State = "UT",
                Rate = 5
            },
        };

    public static Order CAOrder => new Order
    {
      ShippingState = "CA",
      OrderNumber = 153,
      OrderDate = new DateTime(2021, 1, 2),
      Customer = new Customer()
      {
        BillingState = "MA"
      },
      Items = ImmutableList<OrderItem>.Empty.AddRange(new List<OrderItem>() {
                new OrderItem(
                    Quantity: 6,
                    Item: new Item() {
                        Name = "Widget",
                        Price = 12,
                        Taxable = true,
                        Options = new ItemOptions() {
                            Cost = 5,
                            Name = "Large"
                        }
                    }
                ),
                new OrderItem(
                    Quantity: 2,
                    Item: new Item() {
                        Name = "Dingbat",
                        Price = 54,
                        Taxable = false,
                        Options = new ItemOptions() {
                            Cost = 9,
                            Name = "Special"
                        }
                    }
                )
            })
    };

    public static Order AZOrder => new Order
    {
      ShippingState = "AZ",
      OrderNumber = 434,
      OrderDate = new DateTime(2021, 2, 5),
      Customer = new Customer()
      {
        BillingState = "MA"
      },
      Items = ImmutableList<OrderItem>.Empty.AddRange(new List<OrderItem>() {
                new OrderItem(
                    Quantity: 2,
                    Item: new Item() {
                        Name = "Widget",
                        Price = 12,
                        Taxable = true
                    }
                ),
                new OrderItem(
                    Quantity: 32,
                    Item: new Item() {
                        Name = "Foo",
                        Price = 4,
                        Taxable = true
                    }
                ),
                new OrderItem(
                    Quantity: 4,
                    Item: new Item() {
                        Name = "Bar",
                        Price = 10,
                        Taxable = true
                    }
                ),
                new OrderItem(
                    Quantity: 2,
                    Item: new Item() {
                        Name = "Dingbat",
                        Price = 54,
                        Taxable = false,
                        Options = new ItemOptions() {
                            Cost = 9,
                            Name = "Special"
                        }
                    }
                )
            })
    };

    public static Order UTOrder => new Order
    {
      ShippingState = "UT",
      OrderNumber = 34,
      OrderDate = new DateTime(2020, 11, 20),
      Customer = new Customer()
      {
        BillingState = "MA"
      },
      Items = ImmutableList<OrderItem>.Empty.AddRange(new List<OrderItem>() {
                new OrderItem(
                    Quantity: 120,
                    Item: new Item() {
                        Name = "Widget",
                        Price = 12,
                        Taxable = true,
                        Options = new ItemOptions() {
                            Cost = 2,
                            Name = "Special"
                        }
                    }
                ),
                new OrderItem(
                    Quantity: 300,
                    Item: new Item() {
                        Name = "Thing",
                        Price = 2,
                        Taxable = false,
                        Options = new ItemOptions() {
                            Cost = -1,
                            Name = "ScratchDent"
                        }
                    }
                )
            })
    };
  }
}