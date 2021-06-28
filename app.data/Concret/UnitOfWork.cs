using System;
using System.Threading.Tasks;
using app.data.Abstract;

namespace app.data.Concret
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppContext context;
        public UnitOfWork(AppContext _context)
        {
            context = _context;
        }
        private CustomerRepository customerRepository;
        private DietRepository dietRepository;
        private PilatesRepository pilatesRepository;
        private DietWekklyRepository dietWekklyRepository;
        private DietMenüRepository dietMenüRepository;
        private RecipeRepository recipeRepository;
        private AnamnezFormRepository anamnezFormRepository;
        private CalendarRepository calendarRepository;
        private PackageRequestRepository packageRequestRepository;
        private GeneralMsjRepository generalMsjRepository;
        private MyCartRepository myCartRepository;
        private ProductRepository productRepository;
        private CategoryRepository categoryRepository;
        private DateRequestRepository dateRequestRepository;
        private PilatesWeekRepository pilatesWeekRepository;



        public ICustomerRepository Customers => customerRepository = customerRepository ?? new CustomerRepository(context);

        public IPilatesRepository Piates => pilatesRepository = pilatesRepository ?? new PilatesRepository(context);

        public IDietRepository Diets => dietRepository = dietRepository ?? new DietRepository(context);

        public IDietWekklyRepository DietWekkly => dietWekklyRepository = dietWekklyRepository ?? new DietWekklyRepository(context);

        public IDietMenüRepository dietMenüs => dietMenüRepository = dietMenüRepository ?? new DietMenüRepository(context);

        public IRecipeRepository Recipe => recipeRepository = recipeRepository ?? new RecipeRepository(context);

        public IAnamnezFormRepository AnamnezForm => anamnezFormRepository = anamnezFormRepository ?? new AnamnezFormRepository(context);

        public ICalendarRepository Calendar => calendarRepository = calendarRepository ?? new CalendarRepository(context);

        public IPackageRequestRepository packageRequest => packageRequestRepository = packageRequestRepository ?? new PackageRequestRepository(context);

        public IGeneralMsjRepository GeneralMsj => generalMsjRepository=generalMsjRepository??new GeneralMsjRepository(context);

        public IProductRepository Products => productRepository=productRepository??new ProductRepository(context);

        public ICategoryRepository Categories => categoryRepository=categoryRepository??new CategoryRepository(context);

        public IMyCartRepository MyCart => myCartRepository=myCartRepository??new MyCartRepository(context);

        public IDateRequestRepository DateRequest => dateRequestRepository=dateRequestRepository??new DateRequestRepository(context);

        public IPilatesWeekRepository PilatesWeek =>pilatesWeekRepository=pilatesWeekRepository??new PilatesWeekRepository(context);


        // public IOrderRepository Orders => throw new NotImplementedException();
        // public ICartRepository Carts => throw new NotImplementedException();


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
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
                return OprationResult.NotSaved;
            }
        }
    }
}