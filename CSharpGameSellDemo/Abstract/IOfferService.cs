using GameSellDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellDemo.Abstract
{
    internal interface IOfferService
    {
        public void AddOffer(Offer offer);
        public void DeleteOffer(Offer offer);
        public void UpdateOffer(Offer offer);

    }
}
