using System.Threading.Tasks;
using app.data.Abstract;
using app.entity;
using Microsoft.EntityFrameworkCore;

namespace app.data.Concret
{
    public class AnamnezFormRepository : Repository<AnamnezForm>, IAnamnezFormRepository
    {
        public AnamnezFormRepository(AppContext context) : base(context)
        {
            
        }
        private AppContext appContext { get { return context as AppContext; } }

        public async Task<ReturnedClass<AnamnezForm>> CreateWithRuturned(AnamnezForm anamnez)
        {
            try
            {
                var result = await appContext.AnamnezForms.AddAsync(anamnez);
                AnamnezForm anamnez1=result.Entity;

                return new ReturnedClass<AnamnezForm>(OprationResult.ok,_value:anamnez1);
            }
            catch (System.Exception)
            {
                return new ReturnedClass<AnamnezForm>(OprationResult.canceled);
            }
        }
    }
}