namespace FietsExample;

public class Fatbike : ElectrischeFiets
{
   public Fatbike(int nummer, string naam, float opslag, string merk, float basisPrijs, int actieradius) : base(nummer, naam, opslag, merk, basisPrijs, actieradius)
   {
   }

   public override float BerekenKostprijs()
   {
      float kostPrijs = base.BerekenKostprijs();
      kostPrijs *= 1.1f;
      return kostPrijs;
   }
}