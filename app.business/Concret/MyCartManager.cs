using System.Threading.Tasks;
using app.business.Abstract;
using app.data.Abstract;
using app.data.Concret;
using app.entity;

namespace app.business.Concret
{
    public class MyCartManager : IMyCartService
    {
        private readonly IUnitOfWork work;
        public MyCartManager(IUnitOfWork _work)
        {
            work = _work;
        }
        public async Task<OprationResult> CreateAsync(MyCart entity)
        {
            try
            {
                var result = await work.MyCart.CreateAsync(entity);
                if (result == OprationResult.ok)
                {
                    var SaveResult = await work.SaveAsync();
                    if (SaveResult == OprationResult.Saved)
                    {
                        return OprationResult.ok;
                    }
                }
                return OprationResult.canceled;
            }
            catch (System.Exception)
            {
                return OprationResult.canceled;
            }
        }

        public OprationResult DeleteAsync(MyCart entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<MyCart>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<MyCart>> GetByEntityAsync(MyCart entity)
        {
            throw new System.NotImplementedException();
        }

        public Task<ReturnedClass<MyCart>> GetByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<OprationResult> UpdateAsync(MyCart entity)
        {
           try
           {
               var result =work.MyCart.UpdateAsync(entity);
               if(result==OprationResult.ok)
               {
                   var SaveResult =await work.SaveAsync();
                   if(SaveResult==OprationResult.Saved)
                   {
                       return OprationResult.ok;
                   }
               }
                return OprationResult.canceled;
           }
           catch (System.Exception)
           {
                return OprationResult.canceled;
           }
        }
    }
}