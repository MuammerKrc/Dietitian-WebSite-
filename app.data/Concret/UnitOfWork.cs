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
        private RecipeRepository recipeRepository;
        private AnamnezFormRepository anamnezFormRepository;



        public ICustomerRepository Customers => customerRepository=customerRepository??new CustomerRepository(context);
        public IPilatesRepository Piates => pilatesRepository=pilatesRepository??new PilatesRepository(context);

        public IDietRepository Diets => dietRepository=dietRepository??new DietRepository(context);

        public IDietWekklyRepository DietWekkly =>dietWekklyRepository=dietWekklyRepository??new DietWekklyRepository(context);

        public IDietMenüRepository dietMenüs => dietMenüRepository=dietMenüRepository??new DietMenüRepository(context);

        public IRecipeRepository Recipe => recipeRepository=recipeRepository??new RecipeRepository(context);

        public IAnamnezFormRepository AnamnezForm => anamnezFormRepository=anamnezFormRepository??new AnamnezFormRepository(context);

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