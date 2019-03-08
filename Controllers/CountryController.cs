using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fresenius_Angular.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fresenius_Angular.Controllers
{
    [Route("api/[controller]")]
    public class CountryController : Controller
    {
        private readonly FreseniusContext _context;
        private static string[] Summaries = new[]
        {
            "Замораживание", "бодрящий", "холодный", "прохладный", "мягкий", "теплый", "мягкий", "горячий", "душный", "палящий"
        };

        public CountryController(FreseniusContext context)
        {
            _context = context;
            if (_context.Countries.Count() == 0)
            {
                Console.WriteLine("База стран пусто");
            }
          
        }

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            var rng = new Random();
            return Enumerable.Range(1, 15).Select(index => new WeatherForecast
            {
                DateFormatted = DateTime.Now.AddDays(index).ToString("d"),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }

        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }

            public int TemperatureF
            {
                get
                {
                    return 32 + (int)(TemperatureC / 0.5556);
                }
            }
        }

        [HttpGet]
        [Route("countries")]
        public async Task<ActionResult<IEnumerable<Country>>> GetCatsAtribut(string attribute = "no", string order = "no", int limit = -1, int offset = 0)
        {
            List<Country> countries = new List<Country>();
            countries = await _context.Countries.ToListAsync();


            switch (order)
            {
                case "asc":

                    switch (attribute)
                    {
                        case "name": countries = countries.OrderBy(n => n.Name).ToList(); break;
                      //  case "color": countries = countries.OrderBy(n => n.Color).ToList(); break;
                       // case "tail_length": countries = countries.OrderBy(n => n.Tail_length).ToList(); break;
                       // case "Whiskers_length": countries = countries.OrderBy(n => n.Whiskers_length).ToList(); break;

                    }; break;

                case "desc":
                    switch (attribute)
                    {
                        case "name": countries = countries.OrderByDescending(n => n.Name).ToList(); break;
                      //  case "color": countries = countries.OrderByDescending(n => n.Color).ToList(); break;
                      //  case "tail_length": countries = countries.OrderByDescending(n => n.Tail_length).ToList(); break;
                      //  case "Whiskers_length": countries = countries.OrderByDescending(n => n.Whiskers_length).ToList(); break;

                    }; break;
            }
            if ((limit > 0) & (limit < countries.Count())) countries = countries.Skip(offset).Take(limit).ToList();
            return countries;
        }
    }
}
