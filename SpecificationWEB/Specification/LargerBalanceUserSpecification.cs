using SpecificationWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Linq.Expressions;

namespace SpecificationWEB.Specification
{
    public class LargerBalanceUserSpecification : ExpessionEntity<User>
    {
        public LargerBalanceUserSpecification(int balance)
        {
            this.expression = x => x.Balance > balance;
        }
    }
}