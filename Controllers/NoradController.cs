using cosmonautica_v2.Dtos;
using cosmonautica_v2.Repositoriess;
using Microsoft.AspNetCore.Mvc;

namespace cosmonautica_v2.Controllers;

public class NoradController : Controller
{
    private readonly INoradRepo _noradRepo;

    public NoradController(INoradRepo noradRepo)
    {
        _noradRepo = noradRepo;
    }
    // GET
    public async Task<IActionResult> Index()
    {
        SatelitesDto satelites = new SatelitesDto();

        satelites.satelites = new List<RootNoratDto>();

        var issr = await _noradRepo.GetSatelite(25544);
        satelites.satelites.Add(issr);
        var galileo = await _noradRepo.GetSatelite(59598);
        satelites.satelites.Add(galileo);
        var china = await _noradRepo.GetSatelite(54216);
        satelites.satelites.Add(china);
        var galileo2 = await _noradRepo.GetSatelite(43565);
        satelites.satelites.Add(galileo2);
        var atlas = await _noradRepo.GetSatelite(6155);
        satelites.satelites.Add(atlas);
        var fox = await _noradRepo.GetSatelite(40967);
        satelites.satelites.Add(fox);
        

        

        
        
        return View(satelites);
    }
}