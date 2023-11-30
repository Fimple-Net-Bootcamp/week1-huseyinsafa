public class UzunSureliOduncVerme : IOduncIslemleri
{
    public void OduncAl(Uye uye, Kitap kitap)
    {
        uye.kitapOduncAl(kitap);
        Console.WriteLine($"{uye.Ad} isimli üye {kitap.Ad} isimli kitabı uzun süreliğine ödünç almıştır.");
    }
}