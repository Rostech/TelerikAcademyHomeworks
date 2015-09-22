namespace SpecificationPattern.BaseLogic
{
    using System;

    public class AndSpecification<TEntity> : ISpecification<TEntity>
    {
        private readonly ISpecification<TEntity> specification1;
        private readonly ISpecification<TEntity> specification2;

        public AndSpecification(ISpecification<TEntity> specification1, ISpecification<TEntity> specification2)
        {
            if (specification1 == null)
            {
                throw new ArgumentNullException("Spec1");
            }

            if(specification2 == null)
            {
                throw new ArgumentNullException("Spec2");
            }

            this.specification1 = specification1;
            this.specification2 = specification2;
        }

        public bool IsSatisfiedBy(TEntity candidate)
        {
            return this.specification1.IsSatisfiedBy(candidate) &&
                this.specification2.IsSatisfiedBy(candidate);
        }
    }
}
