namespace FietsExample;

public class Bestelling
{
    public int Nummer  { get; set; }
    public List<Regel> Regels  { get; set; } = new List<Regel>();
    

    public Bestelling(int nummer)
    {
        Nummer = nummer;
    }

    public float BerekenTotaalPrijs()
    {
        float totaal = 0;
        foreach (var regel in Regels)
        {
            totaal += regel.BerekenTotaalPrijs();
        }
        return totaal;
    }
}