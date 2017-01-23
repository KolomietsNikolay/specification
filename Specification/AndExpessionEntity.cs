using SpecificationWEB.Models;
using SpecificationWEB.Specification;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace SpecificationWEB.Specification
{
    internal class AndExpessionEntity<T> : ISpecification<T>
    {
        private ISpecification<T> expessionEntity;
        private ISpecification<T> specification;

        public AndExpessionEntity(ISpecification<T> expessionEntity, ISpecification<T> specification)
        {
            this.expessionEntity = expessionEntity;
            this.specification = specification;
        }

        public ISpecification<T> And(ISpecification<T> specification)
        {
            throw new Exception();
        }

        public Expression<Func<T, bool>> IsSatisfiedBy()
        {
            Expression<Func<T, bool>> leftExpression =  expessionEntity.IsSatisfiedBy();
            Expression<Func<T, bool>> rightExpression = specification.IsSatisfiedBy();


            var sum = Expression.AndAlso(Expression.Invoke(leftExpression, leftExpression.Parameters[0]), Expression.Invoke(rightExpression, leftExpression.Parameters[0])); // here is the magic
            var sumExpr = Expression.Lambda<Func<T, bool>>(sum, leftExpression.Parameters);

            return sumExpr;
        }
    }
}