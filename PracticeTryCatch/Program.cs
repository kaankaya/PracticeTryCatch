class Program
{
    public static void Main(string[] args)
    {
        //
        Tekrar:
        try
        {
            Console.WriteLine("Bir Sayı Giriniz");
            double input = Convert.ToDouble(Console.ReadLine());
            double kare = input * input;
            Console.WriteLine($"Girdiğiniz Sayının Karesi {kare}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Hatalı Bir Giriş Yaptınız");
            goto Tekrar;
        }
        finally
        {
            Console.WriteLine("İşlem Tamamlandı");
        }
    }
}