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

public interface IShop{
    public double GetFullPrice(double price);
}