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

        [HttpGet]
        public List<Taco> GetAll()
        {
            return dbContext.Tacos.ToList();
        }
       

        //api/taco/[SoftShell]
        [HttpGet("{SoftShell}")]
        public List<Taco> GetByCategory(bool SoftShell)
        {
            return dbContext.Tacos.Where(b => b.SoftShell == SoftShell).ToList();
        }

        ////api/taco?name=[Name]&cost=[Cost]&softshell=[SoftShell]&dorito=[Dorito]
        //[HttpPost]
        //public Taco AddTaco(string name, float cost, bool softshell, bool dorito)
        //{
        //    Taco newTaco = new Taco(name, cost, softshell, dorito);
        //    dbContext.Tacos.Add(newTaco);
        //    dbContext.SaveChanges();

        //    return newTaco;
        //}
    }
}

