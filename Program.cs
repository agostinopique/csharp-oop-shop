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

//Console.WriteLine(product.GetCorrectCode());

Console.WriteLine(product.GetProductName() + "  " + product.GetCorrectCode());

Console.WriteLine("Vuoi avere il prezzo del prodotto con l'IVA? (si/no)");

string answer = Console.ReadLine();

switch (answer)
{
    case "si":
        Console.WriteLine(product.GetFullPrice());
        break;
    case "no":
        Console.WriteLine("OK");
        break;
    default:
        Console.WriteLine("Il prezzo senza IVA é quello inserito da te in precedenza!");
        break;
}

