using GameSellDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellDemo.Abstract
{
    internal interface ISalesService
    {
        void Sales(GameProduct gameProduct, Customer customer, Offer offer);

    }
}
