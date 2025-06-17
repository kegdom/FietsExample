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
    
    public override string ToString()
    {
        var sb = new System.Text.StringBuilder();
        sb.AppendLine($"Bestelling #{Nummer}");
        sb.AppendLine(new string('=', 20));
        foreach (var regel in Regels)
        {
            sb.AppendLine(regel.ToString());
        }
        sb.AppendLine(new string('-', 20));
        sb.AppendLine($"Totaal: €{BerekenTotaalPrijs():F2}");
        return sb.ToString();
    }

    public void PrintBestelling()
    {
        Console.WriteLine(this.ToString());
    }
}