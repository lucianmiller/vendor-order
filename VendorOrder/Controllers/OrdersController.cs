using Microsoft.AspNetCore.Mvc;
using VendorOrder.Models;
using System.Collections.Generic;

namespace VendorOrder.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }
  }
}