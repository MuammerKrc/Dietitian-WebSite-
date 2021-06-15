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
                var result = await appContext.Customers.Where(i => i.Id == id)
                                .Include(m => m.Diet)
                                .ThenInclude(m => m.DietWekklies)
                                .AsSplitQuery()

                                .Include(m => m.Diet)
                                .ThenInclude(m => m.CombineDietRecipes)
                                .AsSplitQuery()

                                .Include(m => m.Diet)
                                .ThenInclude(m => m.AnamnezForm)

                                .AsNoTracking()
                                .FirstOrDefaultAsync();

                return new ReturnedClass<Customer>()
                {
                    oprationResult = OprationResult.ok,
                    value = result
                };
            }
            catch (System.Exception)
            {
                return new ReturnedClass<Customer>(OprationResult.canceled);

            }
        }

        public async Task<ReturnedClass<Customer>> GetByUserId(string userId)
        {
            try
            {
                var result = await appContext.Customers.Where(i => i.UserId == userId)
                                                .Include(i => i.Diet)
                                                .ThenInclude(i => i.DietWekklies)
                                                .AsSplitQuery()

                                                .Include(m => m.Diet)
                                                .ThenInclude(m => m.CombineDietRecipes)
                                                .AsSplitQuery()

                                                .Include(m => m.Diet)
                                                .ThenInclude(m => m.AnamnezForm)
                                                .AsSplitQuery()

                                                .AsNoTracking()
                                                .FirstOrDefaultAsync();

                return new ReturnedClass<Customer>(OprationResult.ok, _value: result);
            }
            catch (System.Exception)
            {
                return new ReturnedClass<Customer>(OprationResult.canceled);
            }
        }

        public ReturnedClass<Customer> GetCustomerDietCount(int id)
        {
            try
            {
                var result = appContext.Customers.Where(i => i.Id == id)
                                                    .Include(m => m.Diet)
                                                    .ThenInclude(m => m.DietWekklies)
                                                    .SingleOrDefault()
                                                    .Diet
                                                    .DietWekklies
                                                    .Count();

                return new ReturnedClass<Customer>(OprationResult.ok, _id: result);

            }
            catch (System.Exception)
            {
                return new ReturnedClass<Customer>()
                {
                    oprationResult = OprationResult.canceled
                };
            }
        }

        public async Task<OprationResult> updateDietPackages(int quantity,int CustomerId)
        {
            try
            {
                var cmd = "Update Customers set RemaningDietPackages=@p0 where Id=@p1";

                var result=await appContext.Database.ExecuteSqlRawAsync(cmd, quantity, CustomerId);
                if(result==1)
                {
                    return OprationResult.ok;
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