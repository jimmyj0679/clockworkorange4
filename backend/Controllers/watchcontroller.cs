using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

[Route("api/watches")]
[ApiController]
public class WatchesController : ControllerBase
{
    private static readonly List<Watch> Watches = new List<Watch>
    {
        new Watch { Id = 1, BrandName = "Swatch", Description = "Great price, water-resistant", Type = "Type digital", Price = 100.00 },
        new Watch { Id = 2, BrandName = "Rolex", Description = "Timeless classic, arrive on time in style", Type = "Type analog", Price = 200.00 },
        new Watch { Id = 3, BrandName = "Timex", Description = "Cheap but reliable like the hands of a ticking clock, easy to set great entry-level piece", Type = "Type digital", Price = 69.00 },
        new Watch { Id = 4, BrandName = "Seiko", Description = "Simple watch just to go out and about", Type = "Type analog", Price = 80.00 },
        new Watch { Id = 5, BrandName = "Timex", Description = "The gems on the hands make this a timepiece to use for any event", Type = "Type analog", Price = 115.00 },
        new Watch { Id = 6, BrandName = "Casio", Description = "All the mods from date and time to stopwatch and underwater depth gauge this one has it all.", Type = "Type digital", Price = 300.00 },
        new Watch { Id = 7, BrandName = "Swatch", Description = "Simple, effective time-keeping at its simplest", Type = "Type digital", Price = 95.00 },
        new Watch { Id = 8, BrandName = "Casio", Description = "Rare antique watch, collectors will love this", Type = "Type analog", Price = 350.00 },
    };

    [HttpGet]
    public ActionResult<IEnumerable<Watch>> GetWatches()
    {
        return Ok(Watches);
    }
}

public class Watch
{
    public int Id { get; set; }
    public string BrandName { get; set; }
    public string Description { get; set; }
    public string Type { get; set; }
    public double Price { get; set; }
}