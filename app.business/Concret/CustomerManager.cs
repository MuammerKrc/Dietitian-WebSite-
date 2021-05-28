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
            await work.Customers.CreateAsync(entity);
            await work.SaveAsync();
            return OprationResult.ok;
        }

        public async Task<OprationResult> DeleteAsync(Customer entity)
        {
            work.Customers.DeleteAsync(entity);
            await work.SaveAsync();
            return OprationResult.ok;
        }

        public async Task<ReturnedClass<Customer>> GetAll()
        {
            
            return await work.Customers.GetAll(); 

        }

        public Task<ReturnedClass<Customer>> GetByEntityAsync(Customer entity)
        {
            throw new System.NotImplementedException();
        }

        public async Task<ReturnedClass<Customer>> GetByIdAsync(int id)
        {
            return await work.Customers.GetByIdAsync(id);
        }

        public async Task<ReturnedClass<Customer>> GetCustomerByIdWithDiet(int id)
        {
            return  await work.Customers.GetCustomerByIdWithDiet(id);
        }

        public ReturnedClass<Customer> GetCustomerDietCount(int id)
        {
            return  work.Customers.GetCustomerDietCount(id);
        }

        public Task<OprationResult> UpdateAsync(Customer entity)
        {
            throw new System.NotImplementedException();
        }
        
        // public async Task<OprationResult> CreateAsync(Customer entity)
        // {

        //     try
        //     {
        //         if (!ManagerHelper.OperationControl(await work.Customers.CreateAsync(entity)))
        //         {
        //             return OprationResult.ineffective;
        //         }

        //         if (!ManagerHelper.OperationControl(await work.SaveAsync()))
        //         {
        //             return OprationResult.NotSaved;
        //         }
        //         return OprationResult.ok;
        //     }
        //     catch (System.Exception)
        //     {
        //         return OprationResult.canceled;
        //     }
        // }

        // public async Task<OprationResult> DeleteAsync(Customer entity)
        // {
        //     try
        //     {
        //         if (!ManagerHelper.IdControlByEntity(entity))
        //         {
        //             return OprationResult.InvalidId;
        //         }
        //         var result = await work.Customers.GetByIdAsync(entity.Id);

        //         if (!ManagerHelper.OperationControl(result.oprationResult))
        //         {
        //             return OprationResult.ineffective;
        //         }

        //         if (!ManagerHelper.ValueControl(result.value))
        //         {
        //             return OprationResult.NotFound;
        //         }
        //         if (!ManagerHelper.OperationControl(await work.SaveAsync()))
        //         {
        //             return OprationResult.NotSaved;
        //         }
        //         return OprationResult.ok;
        //     }
        //     catch (System.Exception)
        //     {
        //         return OprationResult.canceled;
        //     }
        // }

        // public async Task<ReturnedClass<Customer>> GetAll()
        // {

        //     try
        //     {
        //         var result = await work.Customers.GetAll();
        //         if (ManagerHelper.OperationControl(result.oprationResult))
        //         {
        //             result.oprationResult = OprationResult.ok;
        //             return result;
        //         }
        //         return result;
        //     }
        //     catch (System.Exception)
        //     {
        //         return new ReturnedClass<Customer>(OprationResult.canceled);
        //     }
        // }

        // public async Task<ReturnedClass<Customer>> GetByEntityAsync(Customer entity)
        // {
        //     try
        //     {
        //         if (!ManagerHelper.IdControlByEntity(entity))
        //         {
        //             return new ReturnedClass<Customer>(OprationResult.InvalidId);
        //         }
        //         var result = await work.Customers.GetByIdAsync(entity.Id);

        //         if (!ManagerHelper.OperationControl(result.oprationResult))
        //         {
        //             result.oprationResult = OprationResult.ineffective;
        //             return result;
        //         }
        //         if (!ManagerHelper.ValueControl(result.value))
        //         {
        //             result.oprationResult = OprationResult.NotFound;
        //             return result;
        //         }
        //         return result;

        //     }
        //     catch (System.Exception)
        //     {

        //         return new ReturnedClass<Customer>(OprationResult.canceled);
        //     }
        // }

        // public async Task<ReturnedClass<Customer>> GetByIdAsync(int id)
        // {
        //     if (!ManagerHelper.IdControlById(id))
        //     {
        //         return new ReturnedClass<Customer>(OprationResult.InvalidId);
        //     }
        //     var result = await work.Customers.GetByIdAsync(id);
        //     if (!ManagerHelper.OperationControl(result.oprationResult))
        //     {
        //         result.oprationResult = OprationResult.ineffective;
        //         return result;
        //     }
        //     if (!ManagerHelper.ValueControl(result.value))
        //     {
        //         result.oprationResult = OprationResult.NotFound;
        //         return result;
        //     }
        //     return result;
        // }

        // public async Task<OprationResult> UpdateAsync(Customer entity)
        // {
        //     try
        //     {
        //         if (!ManagerHelper.IdControlByEntity(entity))
        //         {
        //             return OprationResult.InvalidId;
        //         }

        //         var result = work.Customers.UpdateAsync(entity);

        //         if (ManagerHelper.OperationControl(result))
        //         {
        //             return OprationResult.ineffective;
        //         }

        //         if (!ManagerHelper.OperationControl(await work.SaveAsync()))
        //         {
        //             return OprationResult.NotSaved;
        //         }
        //         return OprationResult.ok;
        //     }
        //     catch (System.Exception)
        //     {
        //         return OprationResult.canceled;
        //     }
        // }
    }
}