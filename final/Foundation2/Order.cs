public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _name;
    public Order (Customer name)
    {
        _name = name;
    }


    public void SetProducts(Product product)
    {
        _products.Add(product);
    }

    public double TotalCostProducts()
    {
        double totalCostProducts = 0;
        foreach(Product prod in _products)
        {
            double productCost = prod.ProductPrice();
            totalCostProducts += productCost;
        }
        bool USA = _name.LiveUSA();
        if (USA == false)
        {
            return totalCostProducts + 35;
        }else{
            return totalCostProducts + 5;
        }
        
    }

    public void PackingLabel()
    {
        foreach(Product pro in _products)
        {
            string name = pro.GetProductName();
            int productID = pro.GetProductID();
            Console.WriteLine($"> Product: {name} - ID: {productID}");
        }
    }
    public void ShippingLabel()
    {
        string customerName = _name.GetCustomerName();
        Address getAddress = _name.GetAddress();
        string fullAddress = getAddress.FullAddress();
        Console.WriteLine($"> Full Name: {customerName} - Address: {fullAddress}");
    }
}