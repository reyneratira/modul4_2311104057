class KodeBuah
{
    private static Dictionary<string, string> kodeBuahTable = new Dictionary<string, string>
    {
        {"Apel", "A00"}, {"Aprikot", "B00"}, {"Alpukat", "C00"},
        {"Pisang", "D00"}, {"Paprika", "E00"}, {"Blackberry", "F00"},
        {"Ceri", "H00"}, {"Kelapa", "I00"}, {"Jagung", "J00"},
        {"Kurma", "K00"}, {"Durian", "L00"}, {"Anggur", "M00"},
        {"Melon", "N00"}, {"Semangka", "O00"}
    };

    public static string GetKodeBuah(string buah)
    {
        return kodeBuahTable.ContainsKey(buah) ? kodeBuahTable[buah] : "Kode buah tidak ditemukan";
    }
}

class PosisiKarakterGame
{
    private enum State { Berdiri, Tengkurap, Terbang, Jongkok }
    private State currentState;

    public PosisiKarakterGame()
    {
        currentState = State.Berdiri;
        Console.WriteLine("Posisi awal: Berdiri");
    }
}


class Program
{
    static void Main()
    {
        // Table-Driven approach
        Console.WriteLine("Masukkan nama buah: ");
        string buah = Console.ReadLine();
        Console.WriteLine("Kode Buah: " + KodeBuah.GetKodeBuah(buah));
    }
}