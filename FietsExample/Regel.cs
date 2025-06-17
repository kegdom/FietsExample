using System.Globalization;

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
    
    public override string ToString()
    {
        // gebruik "C2" + Nederlandse cultuur voor €-weergave
        var totaalPrijs   = BerekenTotaalPrijs().ToString("C2", CultureInfo.GetCultureInfo("nl-NL"));
        return $"{Product.Naam} = {totaalPrijs}";
    }

}