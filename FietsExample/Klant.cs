namespace FietsExample;

public class Klant
{
    public int Nummer { get; set; }
    
    public String Naam { get; set; }
    
    public String Email { get; set; }

    public Klant(int nummer, string naam, string email)
    {
        Nummer = nummer;
        Naam = naam;
        Email = email;
    }

    public void StuurBevestiging (Bestelling  bestelling)
    {
        Console.WriteLine(Nummer);
    }

}