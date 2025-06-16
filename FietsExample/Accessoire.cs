namespace FietsExample;

public class Accessoire : Product
{
    public float Prijs { get; set; }

    public Accessoire(int nummer, String naam, float opslag, float prijs) : base(nummer, naam, opslag)
    {
        Prijs = prijs;
    }

    public override float BerekenKostprijs()
    {
        return Prijs;
    }
}