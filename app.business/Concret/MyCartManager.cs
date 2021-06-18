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
            work=_work;
        }
        public Task<OprationResult> CreateAsync(MyCart entity)
        {
            throw new System.NotImplementedException();
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

        public OprationResult UpdateAsync(MyCart entity)
        {
            throw new System.NotImplementedException();
        }
    }
}