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

        public async Task<ReturnedClass<Customer>> GetCustomerByUserId(string UserId)
        {
            try
            {
                if (UserId == null)
                {
                    return new ReturnedClass<Customer>(OprationResult.canceled);
                }
                var result = await work.Customers.GetByUserId(UserId);
                if (result.oprationResult != OprationResult.ok)
                {
                    return result;
                }
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

        public async Task<ReturnedClass<Customer>> GetCustomerForHome()
        {
            try
            {
                var result =await work.Customers.GetCustomerForHome();
                return result;
            }
            catch (System.Exception)
            {
                return new ReturnedClass<Customer>(OprationResult.canceled);
            }
        }

        public async Task<OprationResult> InitilazeAnamnezForm(int customerId)
        {
            try
            {
                var varResult = await GetCustomerByIdWithDiet(customerId);
                if (varResult.oprationResult == OprationResult.canceled)
                {
                    return OprationResult.canceled;
                }
                if (varResult.value.Diet != null)
                {
                    AnamnezForm anamnezForm = new AnamnezForm()
                    {
                        DietId = varResult.value.Diet.Id
                    };
                    var result = await work.AnamnezForm.CreateAsync(anamnezForm);
                    if (result == OprationResult.ok)
                    {
                        var savedResult = await work.SaveAsync();
                        if (savedResult == OprationResult.Saved)
                        {
                            return OprationResult.ok;
                        }
                    }
                }
                return OprationResult.canceled;
            }
            catch (System.Exception)
            {
                return OprationResult.canceled;
            }
        }

        public async Task<OprationResult> InitilazeCustomer(Customer customer)
        {
            try
            {
                if (customer.UserId == null)
                {
                    return OprationResult.canceled;
                }
                var result = await work.Customers.CreateAsync(customer);
                if (result == OprationResult.canceled)
                {
                    return OprationResult.canceled;
                }
                var resultSave = await work.SaveAsync();
                if (resultSave == OprationResult.NotSaved)
                {
                    return resultSave;
                }
                return OprationResult.ok;

            }
            catch (System.Exception)
            {
                return OprationResult.canceled;
            }
        }

        public async Task<OprationResult> InitilazeDiet(int customerId)
        {
            try
            {
                var resultCustomer = await work.Customers.GetByIdAsync(customerId);
                if (resultCustomer.oprationResult == OprationResult.ok)
                {
                    Diet d = new Diet()
                    {
                        CustomerId = resultCustomer.value.Id
                    };
                    var result = await work.Diets.InitilazeDiet(d);
                    if (result == OprationResult.ok)
                    {
                        var saveResult = await work.SaveAsync();
                        if (saveResult == OprationResult.Saved)
                        {
                            return OprationResult.ok;
                        }
                    }
                }
                return OprationResult.canceled;
            }
            catch (System.Exception)
            {
                return OprationResult.canceled;
            }
        }

        public async Task<OprationResult> ReduceDietPackage(int customerId)
        {
            try
            {
                var result = await work.Customers.GetCustomerByIdWithDiet(customerId);
                if (result.oprationResult == OprationResult.ok)
                {
                    if (result.value != null)
                    {
                        if (result.value.Diet != null)
                        {
                            if(result.value.RemaningDietPackages != result.value.Diet.DietWekklies.Count(i=>i.Active==false))
                            {
                                var results=await work.Customers.updateDietPackages(result.value.Diet.DietWekklies.Count(i=>i.Active==false),customerId);
                                return results;
                            }
                        }
                    }
                }
                return OprationResult.canceled;
            }
            catch (System.Exception)
            {
                return OprationResult.canceled;
            }
        }

        public Task<OprationResult> UpdateAsync(Customer entity)
        {
            throw new System.NotImplementedException();
        }
    }
}