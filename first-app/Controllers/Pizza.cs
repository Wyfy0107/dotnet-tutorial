using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PizzaModel.Models;
using PizzaServices.Services;

namespace PizzaController.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Pizzas : ControllerBase
    {
        public Pizzas()
        {
        }

        // GET all action
        [HttpGet]
        public ActionResult<List<Pizza>> GetAll()
        {
            return PizzaService.GetAll();

        }

        // GET by Id action
        [HttpGet("{id}")]
        [Route("{pizzaId:int}")]
        public ActionResult<Pizza> GetOne(int pizzaId)
        {
            return PizzaService.GetOne(pizzaId);
        }

        // POST action

        // PUT action

        // DELETE action
    }
}