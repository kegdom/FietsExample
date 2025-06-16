namespace FietsExample;

public class Regel
{
    public int Nummer { get; set; }
    public Product Product { get; set; }

    public Regel(int nummer, Product product)
    {
        Nummer = nummer;
        Product = product;
    }

    public float BerekenTotaalPrijs()
    {
        return Product.BerekenPrijs();
    }

}