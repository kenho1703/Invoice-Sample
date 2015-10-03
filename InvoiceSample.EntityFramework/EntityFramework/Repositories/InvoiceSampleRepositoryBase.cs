using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace InvoiceSample.EntityFramework.Repositories
{
    public abstract class InvoiceSampleRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<InvoiceSampleDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected InvoiceSampleRepositoryBase(IDbContextProvider<InvoiceSampleDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class InvoiceSampleRepositoryBase<TEntity> : InvoiceSampleRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected InvoiceSampleRepositoryBase(IDbContextProvider<InvoiceSampleDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
