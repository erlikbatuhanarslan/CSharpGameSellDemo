using GameSellDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellDemo.Abstract
{
    internal interface IGamerService
    {
        public void Add(Customer customer);
        public void Delete(Customer customer);
        public void Update(Customer customer);
    }
}
