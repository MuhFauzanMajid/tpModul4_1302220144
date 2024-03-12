using tpmodul4_1302220144;

internal class Program
{
    private static void Main(string[] args)
    {
        KodePos kodePos = new KodePos();

        Console.WriteLine("Masukkan nama lokasi (ketik 'exit' untuk keluar):");

        string input = Console.ReadLine();

        while (input.ToLower() != "exit")
        {
            int kodePosTempat = kodePos.getKodePos(input);

            if (kodePosTempat == 0)
            {
                Console.WriteLine("Kode pos untuk lokasi " + input + " tidak ditemukan.");
            }
            else
            {
                Console.WriteLine("Kode pos untuk " + input + ": " + kodePosTempat);
            }

            Console.WriteLine("Masukkan nama lokasi (ketik 'exit' untuk keluar):");
            input = Console.ReadLine();
        }

        Console.WriteLine("Terima kasih telah menggunakan program ini.");
        Console.ReadLine();
    }
}
