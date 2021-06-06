using System;
using System.Linq;
using System.Threading.Tasks;
using app.data.Abstract;
using app.entity;
using Microsoft.EntityFrameworkCore;

namespace app.data.Concret
{
    public class MounthRepository : Repository<Mounth>, IMounthRepository
    {
        public MounthRepository(DbContext context) : base(context)
        {
        }
        public AppContext appContext { get { return context as AppContext; } }

        public async Task<ReturnedClass<Mounth>> CreateWithReturned(Mounth m)
        {
            try
            {
                var result = await appContext.Mounths.AddAsync(m);
                Mounth returned = result.Entity;
                return new ReturnedClass<Mounth>(OprationResult.successful, returned);
            }
            catch (System.Exception)
            {
                return new ReturnedClass<Mounth>(OprationResult.ineffective);
            }
        }
        public async Task<ReturnedClass<Mounth>> ExistThisMounth(int mounth)
        {
            try
            {
                var result = await appContext.Mounths.FirstOrDefaultAsync(i => i.CurrentMounth == mounth);

                if (result == null)
                {
                    return new ReturnedClass<Mounth>(OprationResult.DontHave);
                }
                return new ReturnedClass<Mounth>(OprationResult.Have, result);

            }
            catch (System.Exception)
            {
                return new ReturnedClass<Mounth>(OprationResult.ineffective);
            }
        }

        public async Task<ReturnedClass<Mounth>> GetDateInOneMounth(int currentMounth)
        {
            try
            {
                var result =await appContext.Mounths
                                            .Include(i=>i.Days)
                                            .ThenInclude(i=>i.Hours)
                                            .AsSplitQuery()
                                            .AsNoTracking()
                                            .FirstOrDefaultAsync();



                                                               
                if (result != null)
                {
                    return new ReturnedClass<Mounth>(OprationResult.ok, _value: result);
                }
                else
                {
                    return new ReturnedClass<Mounth>(OprationResult.ineffective);
                }
            }
            catch (System.Exception)
            {
                return new ReturnedClass<Mounth>(OprationResult.ineffective);
            }
        }
    }
}