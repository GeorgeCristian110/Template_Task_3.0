namespace Template_Task_3.DemoClasses;

public class Product
{
    private int _stock;
    public string Code { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock
    {
        get { return _stock; }
        set
        {
            if (value < 0)
            {
                Console.WriteLine("Can not accept a negative number");
            } else
            {
                _stock = value;
            }
        }
    }

    public Product(string code, string name, decimal price, int stock)
    {
        Code = code;
        Name = name;
        Price = price;
        Stock = stock;
    }

    public override string ToString()
    {
        return $"{Code}: {Name}, {Price} kr, saldo: {Stock}";
    }
}
