using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TacoBellAPI.Controllers
{
    [Route("api/[controller]")]
    public class DrinkController : Controller
    {
        private TacoBellDbContext dbContext = new TacoBellDbContext();

        [HttpGet]
        public List<Drink> GetAll()
        {
            return dbContext.Drinks.ToList();
        }
        //ANY CHANGES TO DB (ADDING OR UPDATING) DON'T FORGET TO dbContext.SaveChanges();

        //api/taco/[Slushie]
        [HttpGet("{Slushie}")]
        public List<Drink> GetByCategory(bool Slushie)
        {
            return dbContext.Drinks.Where(b => b.Slushie == Slushie).ToList();
        }

        ////api/drink?name=[Name]
        //[HttpDelete]
        //public Drink DeleteDrink(string name)
        //{
        //    Drink d = dbContext.Drinks.FirstOrDefault(d => d.Name == name);
        //    dbContext.Remove(d);

        //    return d;
        //}
    }
}

