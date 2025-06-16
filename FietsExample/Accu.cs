namespace FietsExample;

public class Accu : ElectrischOnderdeel
{
    public int WattUur { get; set; }

    public Accu(string naam, float basisPrijs, int wattUur) : base(naam, basisPrijs)
    {
        WattUur = wattUur;
    }
}