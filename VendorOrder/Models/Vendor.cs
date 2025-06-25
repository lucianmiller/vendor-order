using System.Collections.Generic;

namespace VendorOrder.Models
{
  public class Vendor
  {
    private static List<Vendor> _instance = new List<Vendor> {};
    public string Name { get; set; }
    public int Id { get; }

    public Vendor(string vendorName)
    {
      Name = vendorName;
      _instance.Add(this);
      Id = _instance.Count;
    }
  }
}