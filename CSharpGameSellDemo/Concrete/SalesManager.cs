using GameSellDemo.Abstract;
using GameSellDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellDemo.Concrete
{
    internal class SalesManager : ISalesService
    {
        public void Sales(GameProduct gameProduct, Customer customer, Offer offer)
        {
            Console.WriteLine(customer.FirstName + "'a " + gameProduct.GameName + " ürünü %" + offer.OfferDiscount + " indirim ile satıldı.");
        }
    }
}
