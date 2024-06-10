using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToysLib
{
    public class ToysRepository
    {
        private List<Toy> toys = new List<Toy> 
        {
            new Toy { Id = 1, Brand = "Lego", Model = "Star Wars", Price = 100 },
            new Toy { Id = 2, Brand = "Playmobil", Model = "Pirate", Price = 50 },
            new Toy { Id = 3, Brand = "Barbie", Model = "Princess", Price = 75 },
            new Toy { Id = 4, Brand = "Hot Wheels", Model = "Cars", Price = 96 }
        };

        //GetById henter et id fra listen dermed kan vi finde et specifikt legetøj
        // giv en forklaring på hvad denne metode gør
        public Toy GetById(int id)
        {
            //FirstOrDefault er med til at finde d
            Toy? toy = toys.FirstOrDefault(t => t.Id == id);
            if (toy == null)
                throw new ArgumentException("Toy not found");
            return toy;
        }

        public List<Toy> GetAll(int price = 0, string? brand = null) 
        { 
            List <Toy> toys = new List<Toy>();
            if (price > 0)
            {
                toys = this.toys.Where(t => t.Price <= price).ToList();
            }
            else
            {
                toys = this.toys;
            }
            if (brand != null)
            {
                toys = toys.Where(t => t.Brand == brand).ToList();
            }
            return toys;

        }

        public Toy Add(Toy toy)
        {
            toy.ValidateToy();
            toys.Add(toy);
            return toy;
        }

        public Toy Remove(int id)
        {
            Toy toy = GetById(id);
            toys.Remove(toy);
            return toy;
        }

    }
}
// under Build, Build Solution, så man kan gøre klar til REST API