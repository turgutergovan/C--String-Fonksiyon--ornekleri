class Program
{
    static void Main(string[] args)
    {
        //Girilen metindeki kelime sayısını hesaplayalım.

        Console.WriteLine("Lütfen bir metin giriniz.");
        string metin = Console.ReadLine();
        
        //   1.ÇÖZÜM

        string[] kelimeler = metin.Split(' ');
        Console.WriteLine(kelimeler.Length);
        


        //   2.ÇÖZÜM

        int adet = 1;
        while (true)
        {
            int index = metin.IndexOf(' ');
            if (index == -1)

                break;
            adet++;
            
            metin = metin.Substring(index+1);
        }
        Console.WriteLine(adet);
    }

}