namespace FietsExample;

public class Frame : BasisOnderdeel
{
    public String Vorm {get; set;}
     public String Materiaal {get; set;}

    public Frame(string naam, float basisPrijs, string vorm, string materiaal) : base(naam, basisPrijs)
    {
        Vorm = vorm;
        Materiaal = materiaal;
    }
    
}