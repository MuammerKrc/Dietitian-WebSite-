using System.Threading.Tasks;
using app.data.Concret;
using app.entity;

namespace app.data.Abstract
{
    public interface IAnamnezFormRepository:IRepository<AnamnezForm>
    {
        Task<ReturnedClass<AnamnezForm>> CreateWithRuturned(AnamnezForm anamnez);
    }
}