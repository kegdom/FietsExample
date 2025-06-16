namespace FietsExample;

public abstract class ElectrischOnderdeel : IArtikelMetKostprijs
{
    public String Naam { get; set; }
    public float BasisPrijs { get; set; }

    protected ElectrischOnderdeel(string naam, float basisPrijs)
    {
        Naam = naam;
        BasisPrijs = basisPrijs;
    }
    
    public float BerekenKostprijs()
    {
        return BasisPrijs;
    }
}