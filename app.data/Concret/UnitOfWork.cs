using System.Threading.Tasks;
using app.data.Abstract;

namespace app.data.Concret
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppContext context;
        public UnitOfWork(AppContext _context)
        {
            context=_context;
        }
        private CustomerRepository customerRepository;
        private DietRepository dietRepository;
        private PilatesRepository pilatesRepository;
        private DietWekklyRepository dietWekklyRepository;
        private DietMenüRepository dietMenüRepository;

        public ICustomerRepository Customers => customerRepository=customerRepository??new CustomerRepository(context);
        public IPilatesRepository Piates => pilatesRepository=pilatesRepository??new PilatesRepository(context);

        public IDietRepository Diets => dietRepository=dietRepository??new DietRepository(context);

        public IDietWekklyRepository DietWekkly =>dietWekklyRepository??new DietWekklyRepository(context);

        public IDietMenüRepository dietMenüs => dietMenüRepository??new DietMenüRepository(context);

        public void Dispose()
        {
            context.Dispose();
        }

        public async Task<OprationResult> SaveAsync()
        {
            try
            {
                await context.SaveChangesAsync();
                return OprationResult.Saved;
            }
            catch (System.Exception)
            {
                return OprationResult.NotSaved;
            }

        }
    }
}