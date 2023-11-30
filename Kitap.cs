public class Kitap : YaziliEser,IYazdirilabilir
{
    private static int kitapSayisi = 1;

    private int id;

    public int Id{
        get{return id;}
        private set {id=value;}
    }
    
    private string ad;

    public string Ad 
    {
        get { return ad; }
        set { ad = value; }
    }

    private string yazar;

    public string Yazar{
        get{return yazar;}
        set{yazar=value;}
    }

    private int yayinYili;

    public int YayinYili{
        get{return yayinYili;}
        set{yayinYili=value;}
    }
    

    public Kitap(string kitapAdi, string yazar, int yayinYili,string tur)
    {
        Id = kitapSayisi++;
        Ad = kitapAdi;
        Yazar = yazar;
        YayinYili = yayinYili;
        Tur=tur;
    }

    public void Yazdir()
    {
        Console.WriteLine($"{Id} {Ad} {Yazar} {YayinYili}");
    }
}