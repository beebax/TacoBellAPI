using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TacoBellAPI.Controllers
{
    [Route("api/[controller]")]
    public class TacoController : Controller
    {
        private TacoBellDbContext dbContext = new TacoBellDbContext();

        //api/taco
        [HttpGet]
        public List<Taco> GetAllTacos()
        {
            return dbContext.Tacos.ToList();
        }
       

        //api/taco/[true or false]
        [HttpGet("SoftShell")]
        public List<Taco> GetBySoftShell(bool SoftShell)
        {
            return dbContext.Tacos.Where(b => b.SoftShell == SoftShell).ToList();
        }

        //api/taco?name=[Name]&cost=[Cost]&softshell=[SoftShell]&dorito=[Dorito]
        [HttpPost]
        public Taco AddTaco(string name, float cost, bool softshell, bool dorito)
        {
            Taco newTaco = new Taco
            {
                Name = name,
                Cost = cost,
                SoftShell = softshell,
                Dorito = dorito

            };

            dbContext.Tacos.Add(newTaco);
            dbContext.SaveChanges();

            return newTaco;
        }
    }
}

