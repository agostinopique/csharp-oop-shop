// See https://aka.ms/new-console-template for more information

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
    public Product(string productName, double productPrice, int iva)
    {
        this.productCode = new Random().Next(999999);
        this.productName = productName;
        this.productDescription = null;
        this.productPrice = productPrice;
        this.IVA = iva;
    }

    #region Getter
    public string GetProductName()
    {
        return this.productName;
    }

    public int GetProductCode()
    {
        return this.productCode;
    }

    public string GetProductDescription()
    {
        return this.productDescription;
    }


    public double GetProductPrice()
    {
        return this.productPrice;
    }


    public int GetProductIva()
    {
        return this.IVA;
    }

    public double GetFullPrice()
    {
        double priceIva = (this.productPrice / 100) * this.IVA;

        double fullPrice = Math.Round((this.productPrice + priceIva), 2);

        return fullPrice;
    }



    public string GetCorrectCode()
    {   

        string finalCode = null;
        
        int missingDigits = 8 - Convert.ToString(this.productCode).Length;

        if (missingDigits != 0)
        {

            for (int i = 0; i < missingDigits; i++)
            {
                finalCode += "0";
            }

            finalCode += Convert.ToString(this.productCode);

        }

        return finalCode;
    }
    #endregion Getter

    #region Setter
    public void SetName( string productName)
    {
        this.productName = productName;
    }

    public void SetDescription(string productDescription)
    {
        this.productDescription = productDescription;
    }

    public void SetPrice(double productPrice)
    {
        this.productPrice = productPrice;
    }

    public void SetIva(int iva)
    {
        this.IVA = iva;
    }
    #endregion Setter
};
