using GameSellDemo.Abstract;
using GameSellDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellDemo.Concrete
{
    internal class OfferManager : IOfferService
    {
        public void AddOffer(Offer offer)
        {
            Console.WriteLine("Kampanya uygulandı.");
        }

        public void DeleteOffer(Offer offer)
        {
            Console.WriteLine("Kampanya uygulanmadı.:(");
        }

        public void UpdateOffer(Offer offer)
        {
            Console.WriteLine("Kampanya güncellendi.");
        }
    }
}
