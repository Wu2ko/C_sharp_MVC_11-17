using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_11_17.Models;


namespace MVC_11_17.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(InputViewModel name)
        {
            return View();

        }
        public IActionResult Privacy()
            {
            return View();
    }

    //  public IActionResult Index(InputViewModel model)
    //  {
    /*// string mystring = "sveiki";
    //  string mystring2 = "sveiki22222";
    var inputs = new InputViewModel();



    var manoObjektas = new ManoTest();

    manoObjektas.Query = model.name;
    manoObjektas.Skaicius = model.skaic;

    int sudetis = model.q + model.skaic;

    //string naujasZodis;
    /*
    ViewBag.queryStringas = q;
    ViewBag.queryIntas = skaic;


    ViewBag.manoStringas = mystring;
    ViewData["testtext"] = mystring;
    TempData["tes2"] = mystring;
    *//*
    if (ModelState.IsValid)
    {
        return View("Index", manoObjektas);
    }
    else
    return View("Error");

    */

    //  }

}
}
// ?q=reiksme