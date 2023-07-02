using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellDemo.Abstract
{
    internal interface IGameValidationService
    {
        bool Validate(Entites.Customer customer);
    }
}
