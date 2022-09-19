// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Lo-Fi!");



Console.WriteLine("Inserisci il nome di un prodotto: ");
string productName = Console.ReadLine();

Console.WriteLine("Inserisci il prezzo del prodotto: ");
double productPrice = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Inserisci l'IVA del prodotto: ");
int iva = Convert.ToInt32(Console.ReadLine());

Product product = new Product(productName, productPrice,iva);

Console.WriteLine("Prodotto inserito correttamente!");

Console.WriteLine(product.GetProductName());
public class Product
{
    int productCode;
    string productName;
    string productDescription;
    double productPrice;
    int IVA;

    // DEFAULT CONSTRUCTOR
    public Product()
    {
        this.productCode = new Random().Next(99999999);
        this.productName = null;
        this.productDescription = null;
        this.productPrice = 0;
        this.IVA = 0;
    }

    // COMPLEX CONSTRUCTOR
    public  Product(string productName, double productPrice, int iva)
    {
        this.productCode = new Random().Next(99999999);
        this.productName = productName;
        this.productDescription = null;
        this.productPrice = productPrice;
        this.IVA = iva;
    }

    public string GetProductName()
    {
        return this.productName;
    }
};
