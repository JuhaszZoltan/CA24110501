namespace CA24110501;

public class Versenyzo
{
    public string Nev { get; set; }
    public int SzulEv { get; set; }
    public string RajtSzam { get; set; }
    public bool Nem { get; set; }
    public string Kategoria { get; set; }
    public Dictionary<string, TimeSpan> VersenyIdok { get; set; }


}
