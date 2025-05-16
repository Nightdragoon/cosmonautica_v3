using System.Runtime.InteropServices.JavaScript;
using cosmonautica_v2.Dtos;
using cosmonautica_v2.Models;
using cosmonautica_v2.Repositoriess;
using Microsoft.AspNetCore.Mvc;

namespace cosmonautica_v2.Controllers;

public class NasaController : Controller
{
    private readonly INasaRepo _nasaRepo;
    
    // GET

    public NasaController(INasaRepo nasaRepo)
    {
        _nasaRepo = nasaRepo;
    }
    public async Task<IActionResult>  Index(DateTime? date)
    {
        if (date == null)
        {
            var naso = await _nasaRepo.getAll(new DateTime(2015,6,3));
         
            return View(naso);
        }
    
            DateTime nasaa = (DateTime)date;
            var nasa = await _nasaRepo.getAll(nasaa);
         
            return View(nasa);
        
         
    }



    [HttpPost]
    public async Task<IActionResult> GetDates(DateTime date)
    {
       return RedirectToAction("Index", date);
    }
}