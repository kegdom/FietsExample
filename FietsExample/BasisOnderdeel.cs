namespace FietsExample;

public abstract class BasisOnderdeel : IArtikelMetKostprijs
{
    public String Naam { get; set; }
    public float BasisPrijs { get; set; }

    protected BasisOnderdeel(string naam, float basisPrijs)
    {
        Naam = naam;
        BasisPrijs = basisPrijs;
    }

    public float BerekenKostprijs()
    {
        return BasisPrijs;
    }
}