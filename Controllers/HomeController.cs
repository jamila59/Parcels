using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;  
using ParcelCalc.Models;
using System;

namespace ParcelCalc.Controllers
{
  public class HomeController : Controller
  {
      [Route("/")]
      public ActionResult Template() { return View(); }

      [Route("/second")]
      public ActionResult Second(double length, double width,double height) 
      {
          Parcel myPackage = new Parcel(length,width,height);
          myPackage.Volume();
          double result = myPackage.CostToShip();
          // double result = myPackage.CostToShip();
          // string results = result.ToString();
          myPackage.returnResults(result);
          return View("Second",myPackage.returnResults(result));
      }

  }
}