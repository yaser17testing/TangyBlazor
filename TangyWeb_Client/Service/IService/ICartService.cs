using TangyWeb_Client.ViewModels;

namespace TangyWeb_Client.Service.IService
{
    public interface ICartService
    {
        public event Action Onchange;

        Task DecrementCart(ShoppingCart shoppingCart);

            Task IncrementCart(ShoppingCart shoppingCart);


    }
}
