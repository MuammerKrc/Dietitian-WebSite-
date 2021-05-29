using System.Linq;
using System.Threading.Tasks;
using app.data.Abstract;
using app.entity;
using Microsoft.EntityFrameworkCore;

namespace app.data.Concret
{
    public class DietMenüRepository : Repository<DietMenü>, IDietMenüRepository
    {
        public DietMenüRepository(AppContext context) : base(context)
        {

        }
        private AppContext appContext { get { return context as AppContext; } }

      
    }
}