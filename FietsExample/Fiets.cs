namespace FietsExample;

public abstract class Fiets : Product
{
    public String Merk { get; set; }
    public float BasisPrijs  { get; set; }

    protected Fiets(int nummer, string naam, float opslag, string merk, float basisPrijs) : base(nummer, naam, opslag)
    {
        Merk = merk;
        BasisPrijs = basisPrijs;
    }

    public List<IArtikelMetKostprijs> Onderdelen { get; set; } =  new List<IArtikelMetKostprijs>();

    public override float BerekenKostprijs()
    {
        float totaal = BasisPrijs;
        foreach (var onderdelen in Onderdelen)
        {
            totaal += onderdelen.BerekenKostprijs();
        }
        return totaal;
    }
}