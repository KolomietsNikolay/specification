using SpecificationWEB.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace SpecificationWEB.Specification
{
    public class ExpessionEntity<T> : ISpecification<T>
    {
        protected Expression<Func<T, bool>> expression;

        public ExpessionEntity(Expression<Func<T, bool>> func)
        {
            this.expression = func;
        }
        public ExpessionEntity()
        { }

        public ISpecification<T> And(ISpecification<T> specification)
        {
            return new AndExpessionEntity<T>(this, specification);
        }

        public Expression<Func<T, bool>> IsSatisfiedBy()
        {
            return this.expression;
        }
    }
}