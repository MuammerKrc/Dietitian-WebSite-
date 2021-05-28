using System.Collections.Generic;
using System.Threading.Tasks;
using app.data.Abstract;
using Microsoft.EntityFrameworkCore;

namespace app.data.Concret
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        protected readonly DbContext context;
        protected readonly DbSet<T> data;
        public Repository(DbContext _context)
        {
            context = _context;
            data = context.Set<T>();
        }
        public async Task<OprationResult> CreateAsync(T entity)
        {
            try
            {
                await data.AddAsync(entity);
                return OprationResult.successful;
            }
            catch (System.Exception)
            {
                return OprationResult.ineffective;
            }

        }



        public OprationResult DeleteAsync(T entity)
        {
            try
            {
                data.Remove(entity);
                return OprationResult.successful;
            }
            catch (System.Exception)
            {
                return OprationResult.ineffective;
            }
        }

        

        public async Task<ReturnedClass<T>> GetAll()
        {
            try
            {
                var result =await data.ToListAsync();
                return new ReturnedClass<T>(OprationResult.successful,result);

            }
            catch (System.Exception)
            {
                return new ReturnedClass<T>(OprationResult.ineffective);
            }
        }

        public async Task<ReturnedClass<T>> GetByEntityAsync(T entity)
        {
            try
            {
                var resultentity = await data.FindAsync(entity);
                
                return new ReturnedClass<T>(OprationResult.successful);
            }
            catch (System.Exception)
            {
               
                return new ReturnedClass<T>(OprationResult.ineffective);
            }
        }
        public async Task<ReturnedClass<T>> GetByIdAsync(int id)
        {
            try
            {
                var result = await data.FindAsync(id);

                return new ReturnedClass<T>(OprationResult.successful,_value:result);
            }
            catch (System.Exception)
            {
                return new ReturnedClass<T>(OprationResult.ineffective);
            }
        }

        public OprationResult UpdateAsync(T id)
        {
            try
            {
                context.Entry(id).State = EntityState.Modified;
                return OprationResult.successful;
            }
            catch (System.Exception)
            {
                return OprationResult.ineffective;
            }
        }

       
    }

}
public enum OprationResult
{
    // dataResult
    successful = 1,
    ineffective = -1,


    //saveChangeResult
    Saved = 2,
    NotSaved = -2,


    //businessResult
    InvalidId = -3,
    NotFound = 0,
    canceled = -10,
    ok = 10
}