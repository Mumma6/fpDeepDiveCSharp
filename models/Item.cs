using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fpDeepDive.models
{
  public class Item
  {
    public string Name { get; set; }
    public int Price { get; set; }
    public bool Taxable { get; set; }
    public ItemOptions Options { get; set; }
  }
}