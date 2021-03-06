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
                                .ThenInclude(i => i.Calendar)

                                .Include(m => m.Diet)
                                .ThenInclude(m => m.CombineDietRecipes)

                                .Include(m => m.Diet)
                                .ThenInclude(m => m.AnamnezForm)

                                .Include(m => m.Pilates)
                                .ThenInclude(m => m.PilatesWeeks)
                                .ThenInclude(m => m.calendar)

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
                                                .ThenInclude(i => i.Calendar)

                                                .Include(m => m.Diet)
                                                .ThenInclude(m => m.CombineDietRecipes)


                                                .Include(m => m.Diet)
                                                .ThenInclude(m => m.AnamnezForm)

                                                .Include(m => m.Pilates)
                                                .ThenInclude(m => m.PilatesWeeks)
                                                .ThenInclude(m => m.calendar)

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

        public async Task<OprationResult> updateDietPackages(int quantity, int CustomerId)
        {
            try
            {
                var cmd = "Update Customers set RemaningDietPackages=@p0 where Id=@p1";

                var result = await appContext.Database.ExecuteSqlRawAsync(cmd, quantity, CustomerId);
                if (result == 1)
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

        public async Task<ReturnedClass<Customer>> GetCustomerForHome()
        {
            try
            {
                var result = await appContext.Customers
                                            .Include(m => m.Pilates)

                                            .Include(m => m.Diet)
                                            .AsNoTracking()
                                            .ToListAsync();
                return new ReturnedClass<Customer>(OprationResult.ok, _values: result);
            }
            catch (System.Exception)
            {
                return new ReturnedClass<Customer>(OprationResult.canceled);
            }
        }

        public async Task<ReturnedClass<Customer>> GetCustomerForCustomerHome(int id)
        {
            try
            {
                var result = await appContext.Customers.Where(i => i.Id == id)
                                                    .Include(m => m.Diet)
                                                    .ThenInclude(m => m.DietWekklies)
                                                    .ThenInclude(i => i.Calendar)

                                                    .Include(m => m.Diet)
                                                    .ThenInclude(m => m.AnamnezForm)

                                                    .Include(m => m.Diet)
                                                    .ThenInclude(m => m.CombineDietRecipes)

                                                    .Include(m => m.Pilates)
                                                    .ThenInclude(m => m.PilatesWeeks)
                                                    .ThenInclude(m => m.calendar)

                                                    .Include(m => m.MyCarts)

                                                    .AsNoTracking()
                                                    .FirstOrDefaultAsync();

                return new ReturnedClass<Customer>(OprationResult.ok, _value: result);
            }
            catch (System.Exception)
            {
                return new ReturnedClass<Customer>(OprationResult.canceled);
            }
        }

        public async Task<OprationResult> ownWeekControlWithByUserId(string userId, int weekId)
        {
            try
            {
                var result = await appContext.Customers
                                                    .Where(i => i.UserId == userId)
                                                    .Include(i => i.Diet)
                                                    .ThenInclude(i => i.DietWekklies)
                                                    .FirstOrDefaultAsync();

                if (result != null)
                {
                    if (result.Diet != null)
                    {
                        if (result.Diet.DietWekklies != null)
                        {
                            if (result.Diet.DietWekklies.Any(i => i.Id == weekId))
                            {
                                return OprationResult.ok;
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
        public async Task<OprationResult> onPiatesControlWithByUserId(string userId, int weekId)
        {
            try
            {
                var result = await appContext.Customers
                                                    .Where(i => i.UserId == userId)
                                                    .Include(i => i.Pilates)
                                                    .ThenInclude(i => i.PilatesWeeks)
                                                    .FirstOrDefaultAsync();

                if (result != null)
                {
                    if (result.Pilates != null)
                    {
                        if (result.Pilates.PilatesWeeks != null)
                        {
                            if (result.Pilates.PilatesWeeks.Any(i => i.Id == weekId))
                            {
                                return OprationResult.ok;
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

        public async Task<OprationResult> updatePilatesPackages(int quantity, int customerId)
        {
            try
            {
                var cmd = "Update Customers set RemaningPilatesPackages=@p0 where Id=@p1";

                var result = await appContext.Database.ExecuteSqlRawAsync(cmd, quantity, customerId);
                if (result == 1)
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