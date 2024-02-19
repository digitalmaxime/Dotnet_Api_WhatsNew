namespace KeyedServiceRegistration;

public interface IShoppingCartService
{
    public void ClearCart();
}

public class ShoppingCartService : IShoppingCartService
{
    private readonly INotificationService _notificationService;

    public ShoppingCartService([FromKeyedServices("mail")]INotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    public void ClearCart()
    {
        _notificationService.SendNotification("Cart cleared");
    }
}