using System.Collections.Generic;
using System.Threading.Tasks;

namespace CourseSignUp.Common.Persistence
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity GetById(int id);        

        #region Sync CRUD Methods
        void Add(TEntity obj);
        void AddRange(IEnumerable<TEntity> objs);
        void Update(TEntity obj);
        void Remove(int id);
        void Delete(TEntity entityToDelete); 
        #endregion

        #region Async CRUD Methods
        Task SaveAsync();
        Task<TEntity> AddAndSaveAsync(TEntity obj);
        Task<IEnumerable<TEntity>> AddRangeAndSaveAsync(IEnumerable<TEntity> objs);
        Task<TEntity> UpdateAndSaveAsync(TEntity obj);
        Task<IEnumerable<TEntity>> UpdateRangeAndSaveAsync(IEnumerable<TEntity> objs); 
        #endregion
    }
}
