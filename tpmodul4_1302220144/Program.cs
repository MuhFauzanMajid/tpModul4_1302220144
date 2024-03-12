using tpmodul4_1302220144;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Testing KodePos");
        Console.WriteLine();
        KodePos kodePos = new KodePos();

        Console.Write("Masukkan nama lokasi : ");

        string input = Console.ReadLine();
       
        int kodePosTempat = kodePos.getKodePos(input);

        if (kodePosTempat == 0)
        {
            Console.WriteLine("Kode pos untuk lokasi " + input + " tidak ditemukan.");
        }
        else
        {
            Console.WriteLine("Kode pos untuk " + input + ": " + kodePosTempat);
        }

        Console.WriteLine();
        Console.WriteLine("Testing DoorState");
        Console.WriteLine();

        DoorMachine pintu = new DoorMachine();
        // Simulasi perubahan state
        Console.WriteLine("\nMencoba membuka pintu...");
        pintu.BukaPintu();

        Console.WriteLine("\nMencoba mengunci pintu...");
        pintu.KunciPintu();

        Console.WriteLine("\nMencoba membuka pintu lagi...");
        pintu.BukaPintu();
    }
}
