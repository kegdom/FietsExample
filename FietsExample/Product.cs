namespace FietsExample;

public abstract class Product : IArtikelMetKostprijs
{
    public int Nummer { get; set; }
    public string Naam { get; set; }
    public float Opslag { get; set; }

    protected Product(int nummer, string naam, float opslag)
    {
        Nummer = nummer;
        Naam = naam;
        Opslag = opslag;
    }

    public virtual float BerekenPrijs()
    {
        return BerekenKostprijs() + Opslag;
    }

    public float BerekenMarge()
    {
        return BerekenPrijs() - BerekenKostprijs();
    }

    public abstract float BerekenKostprijs();

}
