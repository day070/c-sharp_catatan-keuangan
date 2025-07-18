using System;
internal class Program
{
    private static void Main(string[] args)
    {
        List<Catatan> daftar = new List<Catatan>();
        while (true)
        {
            Console.WriteLine("\n==Aplikasi Catatan Pengeluaran==");
            Console.WriteLine("1. Tambah Catatan \n2. Lihat Semua Catatan \n3. Lihat Total Pengeluaran \n4. Keluar ");
            Console.Write("Pilih Menu : ");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (input)
            {
                case 1:
                    string tanggal = DateTime.Now.ToString("dd,MM,yyyy HH:mm");
                    Console.WriteLine("Tanggal : " + tanggal);
                    Console.Write("Keterangan : ");
                    string keterangan = Console.ReadLine();
                    Console.Write("Jumlah : ");
                    double jumlah = Convert.ToDouble(Console.ReadLine());
                    daftar.Add(new Catatan(tanggal, keterangan, jumlah));
                    Console.WriteLine("Catatan Berhasil di tambahkan");
                    break;

                case 2:
                    if (daftar.Count == 0)
                    {
                        Console.WriteLine("Belum ada catatan");
                    }
                    else
                    {
                        Console.WriteLine("Daftar Catatan");
                        foreach (Catatan c in daftar)
                        {
                            c.Tampilkan();
                        }
                    }
                        break;

                    case 3:
                    double Total = 0;
                    foreach (Catatan c in daftar)
                    {
                        Total += c.Jumlah;
                    }
                    Console.WriteLine($"Total Pengeluaran : Rp{Total:N0}");
                    break;

                    case 4:

                    return;

            }
        }
    }
}