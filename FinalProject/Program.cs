

public class Buyer
{
    public string Name { get; set; }
    public string City { get; set; }
    public string Telephone { get; set; }

    public void CreateBuyer()
    {
        Console.Write("Enter your name: ");
        Name = Console.ReadLine();

        Console.Write("Enter your city: ");
        City = Console.ReadLine();

        Console.Write("Enter your telephone number: ");
        Telephone = Console.ReadLine();
    }

    public void ShowBuyerInfo()
    {
        Console.WriteLine("Buyer Information:");
        Console.WriteLine($"{Name} from {City}, tel: {Telephone}");

    }
}




public class OrderManager
{
    public List<Order<Delivery>> Cart { get; private set; } = new List<Order<Delivery>>();

    public Order<Delivery> CreateOrder<TDelivery>(TDelivery delivery, int number, string description)
        where TDelivery : Delivery
    {
        var order = new Order<Delivery>(number, delivery);
        order.Description = description;
        Cart.Add(order);
        return order;
    }

    public void DisplayAllOrders()
    {
        foreach (var order in Cart)
        {
            Console.WriteLine($"Order Number: {order.Number}, Description: {order.Description}");
        }
    }

    public void ShowCart(List<Product> cart)
    {
        int totalPrice = 0;
        Console.WriteLine("Products in your cart: ");
        foreach (Product item in cart)
        {
            Console.WriteLine($"{item.Name} for {item.Price}$");
            totalPrice += item.Price;
        }
        Console.WriteLine($"Total Price: {totalPrice}$");
    }

    public void AddProductToCart<TProduct>(Order<Delivery> order, TProduct product) where TProduct : Product
    {
        order.AddProduct(product);
    }
}

public class Order<TDelivery> where TDelivery : Delivery
{
    public TDelivery Delivery { get; private set; }
    public int Number { get; private set; }
    public string Description { get; set; }
    public List<Product> Cart { get; private set; } = new List<Product>();

    public Order(int number, TDelivery delivery)
    {
        Number = number;
        Delivery = delivery;
    }

    public void DisplayAddress()
    {
        Console.WriteLine(Delivery.Address);
    }

    public void AddProduct<TProduct>(TProduct product) where TProduct : Product
    {
        Cart.Add(product);
    }
}

public abstract class Delivery
{
    public abstract string DeliveryNumber { get; set; }
    public abstract string Address { get; set; }
}

public class HomeDelivery : Delivery
{
    public override string DeliveryNumber { get; set; }
    public override string Address { get; set; }
    public string CourierName { get; set; }
}

public class PickPointDelivery : Delivery
{
    public override string DeliveryNumber { get; set; }
    public override string Address { get; set; }
    public string PickPointLocation { get; set; }
}

public class ShopDelivery : Delivery
{
    public override string DeliveryNumber { get; set; }
    public override string Address { get; set; }
    public string ShopName { get; set; }
}

public class Product
{
    public string Name { get; set; }
    public int Price { get; set; }
}

