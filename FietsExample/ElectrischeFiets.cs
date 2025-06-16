namespace FietsExample;

public class ElectrischeFiets : Fiets
{
    public int Actieradius {get; set;}

    public ElectrischeFiets(int nummer, string naam, float opslag, string merk, float basisPrijs, int actieradius) : base(nummer, naam, opslag, merk, basisPrijs)
    {
        Actieradius = actieradius;
    }

    public override float BerekenKostprijs()
    {
        return base.BerekenKostprijs();
    }
}