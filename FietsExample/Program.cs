// See https://aka.ms/new-console-template for more information

using FietsExample;

class Program
{
    static void Main(String[] args)
    {
        Catalogus.GetInstance();
        
        var johnDoe = new Klant(1, "John Doe", "johndoe@gmail.com");
        
        Catalogus.PrintCatalogus();

        var racefiets = Catalogus.GetInstance().Lookup(1);
        var elecfiets = Catalogus.GetInstance().Lookup(2);
        var gps = Catalogus.GetInstance().Lookup(3);
        var fietstassen = Catalogus.GetInstance().Lookup(4);

        var bestelling = new Bestelling(001);

        bestelling.Regels.Add(new Regel(1, racefiets));
        bestelling.Regels.Add(new Regel(2, elecfiets));
        bestelling.Regels.Add(new Regel(3, gps));
        bestelling.Regels.Add(new Regel(4, fietstassen));
        
        bestelling.PrintBestelling();
        
        float totaalPrijs = bestelling.BerekenTotaalPrijs();
        
        Console.WriteLine(totaalPrijs);
        johnDoe.StuurBevestiging(bestelling);

    }
}