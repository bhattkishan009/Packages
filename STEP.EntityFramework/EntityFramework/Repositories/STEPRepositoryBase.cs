using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace STEP.EntityFramework.Repositories
{
    public abstract class STEPRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<STEPDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected STEPRepositoryBase(IDbContextProvider<STEPDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class STEPRepositoryBase<TEntity> : STEPRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected STEPRepositoryBase(IDbContextProvider<STEPDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
