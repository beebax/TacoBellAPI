using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TacoBellAPI.Controllers
{
    [Route("api/[controller]")]
    public class BurritoController : Controller
    {
        private TacoBellDbContext dbContext = new TacoBellDbContext();

        [HttpGet]
        public List<Burrito> GetAll()
        {
            return dbContext.Burritos.ToList();
        }
        //ANY CHANGES TO DB (ADDING OR UPDATING) DON'T FORGET TO dbContext.SaveChanges();

        //api/taco/[Bean]
        [HttpGet("{Bean}")]
        public List<Burrito> GetByCategory(bool Bean)
        {
            return dbContext.Burritos.Where(b => b.Bean == Bean).ToList();
        }

        ////api/burrito?name=[Name]&cost=[Cost]&bean=[Bean]
        //[HttpPost]
        //public Burrito AddBurrito(int id, string name, float cost, bool bean)
        //{
        //    Burrito newBurrito = new Burrito(id, name, cost, bean);
        //    dbContext.Add(newBurrito);
        //    dbContext.SaveChanges();

        //    return newBurrito;
        //}
    }
}

