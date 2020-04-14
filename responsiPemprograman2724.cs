using System;

namespace responsiPemprograman2724
{
    class Program
    {
        static void Main(string[] args)
        {

            Karyawan karyawan = new Karyawan(1, 19112724, "Ismail", 5000000);
            Karyawan karyawan2 = new Karyawan(2, 19112725, "Ardhian", 4000000);

            Console.WriteLine("No \t NIK \t\t Nama \t\t Gaji");
            Console.WriteLine("------------------------------------------------");
            karyawan.tampilKaryawan();
            karyawan2.tampilKaryawan();

            Console.WriteLine("\n\n Asyiquee naik gaji 10% \n");

            Console.WriteLine("No \t NIK \t\t Nama \t\t Gaji");
            Console.WriteLine("------------------------------------------------");
            karyawan.naikGaji();
            karyawan2.naikGaji();

            Console.ReadKey();
        }
    }

    class Karyawan
    {
        public int no { get; set; }
        public int nik { get; set; }
        public string nama { get; set; }
        public int gajiBulanan { get; set; }

        public Karyawan(int no, int nik, string nama, int gaji)
        {
            this.no = no;
            this.nik = nik;
            this.nama = nama;

            if (gaji < 0)
            {
                this.gajiBulanan = 0;
            }
            else
            {
                this.gajiBulanan = gaji;
            }
        }

        public void tampilKaryawan()
        {
            Console.WriteLine("{0} \t {1} \t {2} \t {3}", no, nik, nama, gajiBulanan);
        }

        public void naikGaji()
        {
            double tmp = 0;
            tmp = 0.1 * gajiBulanan;
            gajiBulanan += Convert.ToInt32(tmp);
            Console.WriteLine("{0} \t {1} \t {2} \t {3}", no, nik, nama, gajiBulanan);
        }
    }
}