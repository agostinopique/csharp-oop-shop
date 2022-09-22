// See https://aka.ms/new-console-template for more information


#region old excercise
//public class Product
//{
//    int code;
//    string name;
//    string description;
//    double price;
//    int IVA;

//    // DEFAULT CONSTRUCTOR
//    public Product()
//    {
//        this.code = new Random().Next(99999999);
//        this.name = null;
//        this.description = null;
//        this.price = 0;
//        this.IVA = 0;
//    }

//    // COMPLEX CONSTRUCTOR
//    public Product(string name, double price, int iva)
//    {
//        this.code = new Random().Next(999999);
//        this.name = name;
//        this.description = null;
//        this.price = price;
//        this.IVA = iva;
//    }

//    #region Getter
//    public string GetName()
//    {
//        return this.name;
//    }

//    public int GetCode()
//    {
//        return this.code;
//    }

//    public string GetDescription()
//    {
//        return this.description;
//    }


//    public double GetPrice()
//    {
//        return this.price;
//    }


//    public int GetIva()
//    {
//        return this.IVA;
//    }

//    public double GetFullPrice()
//    {
//        double priceIva = (this.price / 100) * this.IVA;

//        double fullPrice = Math.Round((this.price + priceIva), 2);

//        return fullPrice;
//    }



//    public string GetCorrectCode()
//    {   

//        string finalCode = null;

//        int missingDigits = 8 - Convert.ToString(this.code).Length;

//        if (missingDigits != 0)
//        {

//            for (int i = 0; i < missingDigits; i++)
//            {
//                finalCode += "0";
//            }

//            finalCode += Convert.ToString(this.code);

//        }

//        return finalCode;
//    }
//    #endregion Getter

//    #region Setter
//    public void SetName( string name)
//    {
//        this.name = name;
//    }

//    public void SetDescription(string description)
//    {
//        this.description = description;
//    }

//public void SetPrice(double price)
//    {
//        this.price = price;
//    }

//    public void SetIva(int iva)
//    {
//        this.IVA = iva;
//    }
//    #endregion Setter
//};

#endregion old excercise

using System.Diagnostics.Contracts;

public class Acqua : Product, IShop
{
    public static int iva = 4;
    public string Origin { get; set; }
    public double Ph { get; set; }
    public double Liters { get; set; }
    public bool Sparkling { get; set; }

    public Acqua(string name, double price, string origin, double ph, double liters, bool sparkling) : base(name, price)
    {
        this.Origin = origin;
        this.Ph = ph;
        this.Liters = liters;
        this.Sparkling = sparkling;
    }

    public void Empty()
    {
        Console.WriteLine("The bottle is now empty!");
        this.Liters = 0;
    }
    public double Drink(double poured)
    {
        double waterLeft = this.Liters - poured;

        if(waterLeft < 0)
        {
            Console.WriteLine("You cant drink this much water.");
            Console.WriteLine("You can only drink " + Liters + " amount of water");
            return Math.Round(Liters, 2);
        }
        this.Liters = waterLeft;
        return Math.Round(waterLeft, 2);
    }
    public double Fill(double liters)
    {
        double filled = this.Liters + liters;

        if (filled > 1.5)
        {
            Console.WriteLine("You cant fill the bottle more than its maximum capacity!");
            return this.Liters;
        }
        else
        {
            Console.WriteLine("You filled your bottle!");
            this.Liters = filled;
            return filled;
        }
    }

    public override void PrintProduct()
    {
        base.PrintProduct();
        Console.WriteLine("Souce: " + this.Origin);
        Console.WriteLine("Ph: " + this.Ph);
        Console.WriteLine("Liters: " + this.Liters);
        string sparkling = this.Sparkling ? "Sparkling" : "Still";
        Console.WriteLine("Still/Sparkling: " + sparkling);
    }


    public double GetFullPrice(double price)
    {
        double priceIva = (price / 100) * Acqua.iva;

        double fullPrice = Math.Round((price + priceIva), 2);

        return fullPrice;
    }
}