using app.business.Abstract;
using app.data.Abstract;


namespace app.business.Concret
{
    public class CartManager : ICartService
    {
        private readonly IUnitOfWork unitOfWork;
        public CartManager(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

      
    }
}