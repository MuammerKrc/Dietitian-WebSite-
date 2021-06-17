using System;
using System.Threading.Tasks;

namespace app.data.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository Customers { get; }
        IRecipeRepository Recipe { get; }
        IPilatesRepository Piates { get; }
        IDietRepository Diets { get; }
        IDietMenüRepository dietMenüs { get; }
        IDietWekklyRepository DietWekkly { get; }
        IAnamnezFormRepository AnamnezForm { get; }
        ICalendarRepository Calendar { get; }
        IPackageRequestRepository packageRequest{get;}
        IGeneralMsjRepository GeneralMsj{get;}
        Task<OprationResult> SaveAsync();
    }
}