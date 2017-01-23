using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationWEB.Specification
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>> IsSatisfiedBy();

        ISpecification<T> And(ISpecification<T> specification);
    }
}
