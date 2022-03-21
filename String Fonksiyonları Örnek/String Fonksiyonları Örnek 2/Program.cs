class Program
{
    static void Main(string[] args)
    {
        //Girilen metnin içerisinden kaç tane 'n' karakteri geçtiğini hesaplayalım

        Console.WriteLine("Lütfen bir metin giriniz.");
        string metin = Console.ReadLine();

        int adet = 0;
        for (int i = 0; i <metin.Length; i++)
        {
            if (metin[i] == 'n')
                adet++;
        }

        Console.WriteLine(adet);

       
    }
}