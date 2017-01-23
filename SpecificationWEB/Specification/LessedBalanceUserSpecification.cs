using SpecificationWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpecificationWEB.Specification
{
    public class LessedBalanceUserSpecification : ExpessionEntity<User>
    {
        public LessedBalanceUserSpecification(int balanceLess)
        {
            this.expression = x => x.Balance < balanceLess;
        }
    }
}