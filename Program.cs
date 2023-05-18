using fpDeepDive.models;
using fpDeepDive.data;
using fpDeepDive.services;

var orders = new List<Order>() {
  TestData.AZOrder,
  TestData.CAOrder,
  TestData.UTOrder
};

Func<List<TaxRate>, string, double> taxRater = (List<TaxRate> rates, string state) => rates.First(x => x.State == state).Rate;

var taxRates = TestData.TaxRates;

var order = TestData.AZOrder;

var total = OrderServices.GetTotal(order, taxRates, taxRater);

var orderWithShipDetails = OrderServices.UpdateOrderShipDetails(order);

Console.WriteLine("Total is " + total);