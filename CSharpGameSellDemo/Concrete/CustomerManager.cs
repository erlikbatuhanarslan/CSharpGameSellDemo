using GameSellDemo.Abstract;
using GameSellDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellDemo.Concrete
{
    internal class CustomerManager : IGamerService
    {

        private IGameValidationService _gamerValidationService;

        public CustomerManager(Abstract.IGameValidationService gamerValidationService)
        {
            _gamerValidationService = gamerValidationService;
        }

        public void Add(Customer customer)
        {
            if (_gamerValidationService.Validate(customer) == true)
            {
                Console.WriteLine("Başarılı bir şekilde kayıt olundu.");
            }
            else
            {
                Console.WriteLine("Kayıt başarısız.:(");
            }
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Kayıt silinid");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Kayıtlı kişi güncelendi.");
        }
    }
}
