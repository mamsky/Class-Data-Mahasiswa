using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek produk
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

        static void Main(string[] args)
        {
            Console.Title = "Nama: Paste Prosmana";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..5]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahData();
                        break;

                    case 2:
                        HapusData();
                        break;

                    case 3:
                        TampilkanData();
                        break;
                    
                    case 4:
                        EditData();
                        break;

                    case 5: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("------------------------");
            Console.WriteLine("- Nama: Paste Prosmana -");
            Console.WriteLine("-   Nim : 19.11.2800   -");
            Console.WriteLine("------------------------");
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine("1. Tambah Data");
            Console.WriteLine("2. Hapus Data");
            Console.WriteLine("3. Tampilkan Data");
            Console.WriteLine("4. Edit Data");
            Console.WriteLine("5. Keluar\n");
        }

        static void TambahData()
        {
            Console.Clear();
			Console.WriteLine("Tambahkan Data Mahasiswa\n");
			Mahasiswa mahasiswa = new Mahasiswa();
			Console.Write("Masukkan Nim : ");
            mahasiswa.Nim = Console.ReadLine();
			Console.Write("Nama Mahasiswa : ");
			mahasiswa.Nama = Console.ReadLine();
			Console.Write("Jenis Kelamin [L/P]: ");
			mahasiswa.JenisKelamin = Console.ReadLine();
			Console.Write("IPK : ");
			mahasiswa.IPK = Console.ReadLine();

			daftarMahasiswa.Add(mahasiswa);

			Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusData()
        {
            Console.Clear();
			
			Console.WriteLine("Hapus Data Mahasiswa\n");
			Console.Write("Nim Mahasiswa : ");
			string Nim = Console.ReadLine();

            Mahasiswa delPro = daftarMahasiswa.SingleOrDefault(f => f.Nim == Nim);
            if (daftarMahasiswa.Contains(delPro) == true)
            {
                daftarMahasiswa.Remove(delPro);
                Console.WriteLine("Data Mahasiswa Berhasil di hapus");
            }
            else
            {
                Console.WriteLine("Nim Mahasiswa tidak ditemukan");
            }
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilkanData()
        {
            Console.Clear();
			Console.WriteLine("Data Mahasiswa\n");
			int noUrut = 1;
			foreach (Mahasiswa mahasiswa in daftarMahasiswa)
			{
				Console.WriteLine("{0}. {1}, {2}, {3}, {4}", noUrut, mahasiswa.Nim, mahasiswa.Nama, mahasiswa.JenisKelamin, mahasiswa.IPK);
                noUrut++;
			}
            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
        static void EditData()
        {
            Console.Clear();
            Console.WriteLine("Edit Data mahasiswa \n");
            HapusData();
            Console.Clear();
            TambahData();
        }
    }
}