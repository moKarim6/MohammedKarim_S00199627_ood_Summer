using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohammedKarim_S00199627
{
    public class Game
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Score { get; set; }
        public string Description { get; set; }
        public string Platform { get; set; }
        public decimal Price { get; set; }
        public string GameImage { get; set; }

        public Game()
        {

        }

        public Game(string name, double score, string description, string platform, decimal price, string gameImage = "")
        {
            Name = name;
            Score = score;
            Description = description;
            Platform = platform;
            Price = price;
            GameImage = gameImage;
        }

        public override string ToString()
        {
            return Name;
        }

        public void DecreasePrice(decimal amount)
        {
            Price -= amount;
        }
    }

  
}
