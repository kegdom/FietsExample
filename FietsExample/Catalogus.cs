namespace FietsExample;

public class Catalogus
{
    private List<Product> products = new List<Product>();
    
    private static Catalogus? _instance;

    public static Catalogus GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Catalogus();
            _instance.Initialiseer();
        }

        return _instance;
    }

    public void Initialiseer()
    {
        var aluFrame = new Frame("AluFrame", 0, "Recht", "Aluminum");
        var titFrame = new Frame("titFrame", 0, "Hangend", "titanium");
        var selleRoyalZadel = new Zadel("Selle Royal Zadel", 75, "Silicone");
        var brooksZadel = new Zadel("Brooks Zadel", 150, "Leer");
        var voorwiel = new Wielen("Racefiets Voorwiel", 89);
        var achterwiel = new Wielen("Achterwiel", 99);
        var motor = new Motor("Motor", 600, 250);
        var accu = new Accu("Accu", 350, 400);
        var gps = new Accessoire(1, "GPS", 0, 325);
        var fietstassen = new Accessoire(2, "Fietstassen", 0, 90);
        
        //fiets maken
        var racefiets = new Racefiets(1, "TitRacefiets", 0f, "Cube", 800, 9);
        racefiets.Onderdelen = new List<IArtikelMetKostprijs>
        {
            titFrame,
            selleRoyalZadel,
            voorwiel,
            achterwiel,
        };
        
        var elecFiets = new ElectrischeFiets(2, "ElecFiets", 0f, "Cube", 1250, 130);
        elecFiets.Onderdelen = new List<IArtikelMetKostprijs>
        {
            aluFrame,
            brooksZadel,
            motor,
            accu,
            voorwiel,
            achterwiel,
        };

        gps.Nummer = 3;
        fietstassen.Nummer = 4;
        
        products.Add(racefiets);
        products.Add(elecFiets);
        products.Add(fietstassen);
        products.Add(gps);
    }
    
    public void PrintCatalogus()
    {
        //print catalogus
        foreach (var product in products)
        {

        }
    }

    public Product Lookup(int nummer)
    {
        return products.Find(x => x.Nummer == nummer);
    }
}