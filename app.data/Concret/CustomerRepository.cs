using System.Linq;
using System.Threading.Tasks;
using app.data.Abstract;
using app.entity;
using Microsoft.EntityFrameworkCore;

namespace app.data.Concret
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(AppContext context) : base(context)
        {

        }
        private AppContext appContext { get { return context as AppContext; } }

        public async Task<ReturnedClass<Customer>> GetCustomerByIdWithDiet(int id)
        {
            try
            {
                var result = await appContext.Customers.Where(i=>i.Id==id)
                                .Include(m => m.Diet)
                                .ThenInclude(m=>m.DietWekklies)
                                .AsSplitQuery()
                                
                                .Include(m=>m.Diet)
                                .ThenInclude(m=>m.CombineDietRecipes)
                                .AsSplitQuery()

                                .AsNoTracking()
                                .FirstOrDefaultAsync();
                return new ReturnedClass<Customer>()
                {
                    oprationResult = OprationResult.successful,
                    value = result
                };
            }
            catch (System.Exception)
            {
                return new ReturnedClass<Customer>()
                {
                    oprationResult = OprationResult.ineffective
                };
            }
        }

        public ReturnedClass<Customer> GetCustomerDietCount(int id)
        {
            try
            {
                var result = appContext.Customers.Where(i=>i.Id==id)
                                                    .Include(m=>m.Diet)
                                                    .ThenInclude(m=>m.DietWekklies)
                                                    .SingleOrDefault()
                                                    .Diet
                                                    .DietWekklies
                                                    .Count();

                return new ReturnedClass<Customer>(OprationResult.successful,_id:result);
                                                    
            }
            catch (System.Exception)
            {
                return new ReturnedClass<Customer>(){
                    oprationResult=OprationResult.ineffective
                };
            }
        }
    }
}