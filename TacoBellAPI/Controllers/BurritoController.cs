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

        //api/burrito
        [HttpGet]
        public List<Burrito> GetAllBurritos()
        {
            return dbContext.Burritos.ToList();
        }

        //api/burrito/[true or false]
        [HttpGet("Bean")]
        public List<Burrito> GetByBean(bool Bean)
        {
            return dbContext.Burritos.Where(b => b.Bean == Bean).ToList();
        }

        //api/burrito?name=[Name]&cost=[Cost]&bean=[true or false]
        [HttpPost]
        public Burrito AddBurrito(string name, float cost, bool bean)
        {
            Burrito newBurrito = new Burrito()
            {
                Name = name,
                Cost = cost,
                Bean = bean
            };

            dbContext.Burritos.Add(newBurrito);
            dbContext.SaveChanges();

            return newBurrito;
        }
    }
}

