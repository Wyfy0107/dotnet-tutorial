using PizzaModel.Models;
using System.Collections.Generic;
using System.Linq;

namespace PizzaServices.Services
{
    public static class PizzaService
    {
        static List<Pizza> Pizzas { get; }
        static int nextId = 3;
        static PizzaService()
        {
            Pizzas = new List<Pizza>
            {
                new Pizza { Id = 1, Name = "Classic Italian", IsGlutenFree = false },
                new Pizza { Id = 2, Name = "Veggie", IsGlutenFree = true }
            };
        }

        public static List<Pizza> GetAll() => Pizzas;

        public static Pizza GetOne(int id) => Pizzas.FirstOrDefault(p => p.Id == id);

        public static void AddOne(Pizza pizza)
        {
            pizza.Id = nextId++;
            Pizzas.Add(pizza);
        }

        public static void DeleteOne(int id)
        {
            var pizza = GetOne(id);
            if (pizza is null)
                return;

            Pizzas.Remove(pizza);
        }

        public static void UpdateOne(Pizza pizza)
        {
            var index = Pizzas.FindIndex(p => p.Id == pizza.Id);
            if (index == -1)
                return;

            Pizzas[index] = pizza;
        }
    }
}