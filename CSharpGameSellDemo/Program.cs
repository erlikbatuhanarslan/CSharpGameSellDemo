using System;
using GameSellDemo;
using GameSellDemo.Abstract;
using GameSellDemo.Entites;
using GameSellDemo.Concrete;

namespace KnightOnlineGameProje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Batuhan";
            customer1.LastName = "Arslan";
            customer1.BirthYear = 2001;
            customer1.NationalyId = "23001";

            GameProduct product1 = new GameProduct();
            product1.Id = 1;
            product1.GameName = "God Of War";
            product1.Categories = "Action,Mythology";
            product1.Price = 329;

            Offer offer1 = new Offer();
            offer1.Id = 1;
            offer1.OfferName = "Summer Campaign";
            offer1.OfferDiscount = 23;

            CustomerManager customerManager = new CustomerManager(new UserValidationManager());
            customerManager.Add(customer1);
            customerManager.Delete(customer1);
            customerManager.Update(customer1);

            SalesManager salesManager = new SalesManager();
            salesManager.Sales(product1, customer1, offer1);

            OfferManager offerManager = new OfferManager();
            offerManager.AddOffer(offer1);
            offerManager.DeleteOffer(offer1);
            offerManager.UpdateOffer(offer1);

        }
    }
}
