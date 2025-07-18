using System;

struct Catatan
{
    public string Tanggal;
    public string Keterangan;
    public double Jumlah;

    public Catatan(string tanngal, string keterangan, double jumlah)
    {

        Tanggal = tanngal;
        Keterangan = keterangan;
        Jumlah = jumlah;

    }

    public void Tampilkan()
    {
        Console.WriteLine($"{Tanggal} - {Keterangan} - Rp{Jumlah:N0}");
    }
}
