using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TacoBellAPI.Controllers
{
    [Route("api/[controller]")]
    public class DrinkController : Controller
    {
        private TacoBellDbContext dbContext = new TacoBellDbContext();

        //api/burrito
        [HttpGet]
        public List<Drink> GetAllDrinks()
        {
            return dbContext.Drinks.ToList();
        }

        //api/taco/[Slushie]
        [HttpGet("Slushie")]
        public List<Drink> GetBySlushie(bool Slushie)
        {
            return dbContext.Drinks.Where(b => b.Slushie == Slushie).ToList();
        }

        //api/drink?name=[Name]
        [HttpDelete]
        public Drink DeleteDrink(string name)
        {
            Drink d = dbContext.Drinks.FirstOrDefault(d => d.Name == name);
            dbContext.Remove(d);
            dbContext.SaveChanges();

            return d;
        }
    }
}

