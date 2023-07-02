using GameSellDemo.Abstract;
using GameSellDemo.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellDemo.Concrete
{
    internal class UserValidationManager : IGameValidationService
    {
        public bool Validate(Customer customer)
        {
            if (customer.Id == 1 && customer.NationalyId == "23001"
                && customer.FirstName == "Batuhan" && customer.LastName == "Arslan")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
