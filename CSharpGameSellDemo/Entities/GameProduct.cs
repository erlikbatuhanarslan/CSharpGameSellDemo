using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellDemo.Entites
{
    internal class GameProduct
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public string Categories { get; set; }
        public double Price { get; set; }
    }
}
