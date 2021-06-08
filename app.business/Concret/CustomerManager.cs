using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.business.Abstract;
using app.data.Abstract;
using app.data.Concret;
using app.entity;

namespace app.business.Concret
{
    public class CustomerManager : ICustomerService
    {
        private IUnitOfWork work;
        public CustomerManager(IUnitOfWork _work)
        {
            work = _work;
        }

        public async Task<OprationResult> CreateAsync(Customer entity)
        {
            try
            {
                var dataResult = await work.Customers.CreateAsync(entity);
                if (!ManagerHelper.OperationControl(dataResult))
                {
                    return OprationResult.canceled;
                }
                var SaveResult = await work.SaveAsync();
                if (!ManagerHelper.OperationControl(SaveResult))
                {
                    return OprationResult.canceled;
                }
                return OprationResult.ok;
            }
            catch (System.Exception)
            {
                return OprationResult.canceled;
            }
        }

        public async Task<OprationResult> DeleteAsync(Customer entity)
        {
            try
            {
                var dataResult = work.Customers.DeleteAsync(entity);
                if (!ManagerHelper.OperationControl(dataResult))
                {
                    return OprationResult.canceled;
                }

                var SaveResult = await work.SaveAsync();
                if (!ManagerHelper.OperationControl(SaveResult))
                {
                    return OprationResult.canceled;
                }

                return OprationResult.ok;
            }
            catch (System.Exception)
            {
                return OprationResult.canceled;
            }
        }

        public async Task<ReturnedClass<Customer>> GetAll()
        {
            try
            {
                return await work.Customers.GetAll();

            }
            catch (System.Exception)
            {
                return new ReturnedClass<Customer>(OprationResult.canceled);
            }

        }

        public Task<ReturnedClass<Customer>> GetByEntityAsync(Customer entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ReturnedClass<Customer>> GetByIdAsync(int id)
        {
            try
            {
                var value = ManagerHelper.IdControlWithReurned<Customer>(id);
                if (value.oprationResult == OprationResult.canceled)
                {
                    return value;
                }

                var result = await work.Customers.GetByIdAsync(id);
                result.oprationResult = OprationResult.ok;
                return result;
            }
            catch (System.Exception)
            {
                return new ReturnedClass<Customer>(OprationResult.canceled);
            }
        }

        public async Task<ReturnedClass<Customer>> GetCustomerByIdWithDiet(int? id)
        {
            try
            {
                var value = ManagerHelper.IdControlWithReurned<Customer>(id);
                if (value.oprationResult == OprationResult.canceled)
                {
                    return value;
                }

                var result = await work.Customers.GetCustomerByIdWithDiet((int)id);
                result.oprationResult = OprationResult.ok;
                return result;
            }
            catch (System.Exception)
            {
                return new ReturnedClass<Customer>(OprationResult.canceled);
            }
        }

        public ReturnedClass<Customer> GetCustomerDietCount(int id)
        {
            return work.Customers.GetCustomerDietCount(id);
        }

        public Task<OprationResult> UpdateAsync(Customer entity)
        {
            throw new System.NotImplementedException();
        }
    }
}