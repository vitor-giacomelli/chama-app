using CourseSignUp.Common.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseSignUp.Adapters.Repository.Repositories
{
    public class EntityRepository<TEntity> : EntityRepository<TEntity, ModelContext>
        where TEntity : class
    {
        public EntityRepository(ModelContext context) : base(context)
        {
        }
    }

    public class EntityRepository<TEntity, TContext> : IRepository<TEntity>
       where TEntity : class
       where TContext : BaseDbContext
    {
        protected BaseDbContext Context { get; }
        private readonly DbSet<TEntity> _dbSet;

        public EntityRepository(TContext context)
        {
            Context = context;
            _dbSet = context.Set<TEntity>();
        }

        public virtual TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public virtual void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void AddRange(IEnumerable<TEntity> entities)
        {
            _dbSet.AddRange(entities);
        }

        public virtual void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }

        public virtual void Remove(int id)
        {
            TEntity entityToDelete = _dbSet.Find(id);
            Delete(entityToDelete);
        }

        public virtual void Delete(TEntity entityToDelete)
        {
            if (Context.Entry(entityToDelete).State == EntityState.Detached)
            {
                _dbSet.Attach(entityToDelete);
            }
            _dbSet.Remove(entityToDelete);
        }

        public virtual async Task SaveAsync()
        {
            await Context.SaveChangesAsync();
        }

        public virtual async Task<TEntity> AddAndSaveAsync(TEntity entity)
        {
            if (entity == null)
                return entity;

            var saved = _dbSet.Add(entity);
            await Context.SaveChangesAsync();

            return saved.Entity;
        }

        public virtual async Task<IEnumerable<TEntity>> AddRangeAndSaveAsync(IEnumerable<TEntity> entities)
        {
            if (entities == null || !entities.Any())
                return entities;

            _dbSet.AddRange(entities);
            await Context.SaveChangesAsync();
            return entities;
        }

        public virtual async Task<TEntity> UpdateAndSaveAsync(TEntity entity)
        {
            if (entity == null)
                return entity;

            var updated = _dbSet.Update(entity);
            await Context.SaveChangesAsync();

            return updated.Entity;
        }

        public virtual async Task<IEnumerable<TEntity>> UpdateRangeAndSaveAsync(IEnumerable<TEntity> entities)
        {
            if (entities == null || !entities.Any())
                return entities;

            _dbSet.UpdateRange(entities);
            await Context.SaveChangesAsync();

            return entities;
        }
    }
}
