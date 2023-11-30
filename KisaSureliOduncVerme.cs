public class KisaSureliOduncVerme : IOduncIslemleri
{
       public void OduncAl(Uye uye, Kitap kitap)
    {
        uye.kitapOduncAl(kitap);
        Console.WriteLine($"{uye.Ad} isimli üye {kitap.Ad} isimli kitabı kısa süreliğine ödünç almıştır.");
    }
}