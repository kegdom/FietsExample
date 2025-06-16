namespace FietsExample;

public class Racefiets : Fiets
{
    public float Gewicht { get; set; }

    public Racefiets(int nummer, string naam, float opslag, string merk, float basisPrijs, float gewicht) : base(nummer, naam, opslag, merk, basisPrijs)
    {
        Gewicht = gewicht;
    }
    public override float BerekenKostprijs()
    {
        float kostPrijs = base.BerekenKostprijs();
        if (Naam.ToLower().Contains("tit"))
        {
            kostPrijs *= 1.3f;
        }
        return kostPrijs;
    }
}