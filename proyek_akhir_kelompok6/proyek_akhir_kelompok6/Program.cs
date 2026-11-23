using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyek_akhir_kelompok6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("Selamat Datang Di CAFE SUDUT SORE");

            string[] pilihanMenu =
            {
                "coffe latte",
                "cappucino",
                "matcha latte",
                "chocolatte",
                "milk tea",
                "mango juice",
            };

            int[] hargaMenu =
            {
                12000,
                10000,
                25000,
                20000,
                13000,
                10000,
            };

            string[] pilihanTambahan =
            {
                "Es batu",
                "Extra sugar",
                "Less sugar",
                "Extra shot",
                "Whipped cream",
            };
            Console.WriteLine();
            Console.WriteLine("====== Daftar Menu ======");
            Console.WriteLine("1. coffe latte\tRp.12.000");
            Console.WriteLine("2. cappucino\tRp.10.000");
            Console.WriteLine("3. matcha latte\tRp.25.000");
            Console.WriteLine("4. chocolatte\tRp.20.000");
            Console.WriteLine("5. milk tea\tRp.13.000");
            Console.WriteLine("6. mango  juice\tRp.10.000");
            int PilihanMenu = 0;
            do
            {
                Console.Write("pilih menu (1-6): ");
                PilihanMenu = Convert.ToInt32(Console.ReadLine());
                if (PilihanMenu < 1 || PilihanMenu > 6)
                {
                    Console.WriteLine("Pesanan Tidak Valid, silahkan coba lagi!");
                }
            } while (PilihanMenu < 1 || PilihanMenu > 6);



            Console.WriteLine();
            Console.WriteLine("====== Daftar Tambahan ======");
            Console.WriteLine("1. Es batu");
            Console.WriteLine("2. Extra sugar");
            Console.WriteLine("3. Less sugar");
            Console.WriteLine("4. Extra shot");
            Console.WriteLine("5. Whipped cream");
            Console.Write("pilih tambahan (1-5): ");
            int PilihanTambahan =
            Convert.ToInt32(Console.ReadLine());
            if (PilihanTambahan <=5)
            {
                Console.WriteLine("Pesanan Diterima");
            }
            else if (PilihanTambahan >=5)
            {
                Console.WriteLine("Pesanan Tidak Valid");
            }

            Console.WriteLine();
            Console.WriteLine("====== Detail Pesanan ======");
            Console.WriteLine("Masukkan nama anda: ");
            string nama = Console.ReadLine();
            string namaMenuTerpilih = pilihanMenu[PilihanMenu - 1];
            int hargaTerpilih = hargaMenu[PilihanMenu - 1];
            string TambahanTerpilih = pilihanTambahan[PilihanTambahan - 1];

            Console.WriteLine("nama pemesan: " + nama);
            Console.WriteLine("pilihan menu: " + namaMenuTerpilih);
            Console.WriteLine("tambahan: " + TambahanTerpilih);
            Console.WriteLine("harga: " + hargaTerpilih);
            Console.WriteLine("Pesanan Diproses");

            Console.WriteLine();
            Console.WriteLine("====== Voucher Diskon ======");
            Console.WriteLine("Masukkan kode voucher(opsional)");
            Console.Write("Kode voucher: ");

            string voucher = Console.ReadLine();
            int diskon = 0;

            if (voucher.ToUpper() ==
                "SIPAYULLDAN")
            {
                diskon = 2000;
                Console.WriteLine("Voucher Berhasil Digunakan!");
                Console.WriteLine("diskon: Rp2.000");
            }
            else if (voucher.ToUpper() ==
                    "JUNUBELLZ")
            {
                diskon = 1000;
                Console.WriteLine("Voucher Berhasil Digunakan!");
                Console.WriteLine("diskon: Rp1.000");
            }
            else if (voucher.ToUpper() ==
                    "RACHUANXUWANGYUAN")
            {
                diskon = 3000;
                Console.WriteLine("Voucher Berhasil Digunakan!");
                Console.WriteLine("diskon: Rp3.000");
            }
            else if (voucher == "")
            {
                Console.WriteLine("Tidak Menggunakan Voucher.");
            }
            else
            {
                Console.WriteLine("Voucher Tidak Valid");
            }
            int hargaAwal =
            hargaMenu[PilihanMenu - 1];
            int totalBayar = hargaAwal - diskon;

            Console.WriteLine();
            Console.WriteLine("====== Pembayaran ======");
            Console.WriteLine("Total bayar: Rp" + totalBayar);
            Console.Write("Uang pelanggan: Rp");
            int uangPelanggan =
            Convert.ToInt32(Console.ReadLine());
            if (uangPelanggan >= totalBayar)
            {
                int kembalian = uangPelanggan - totalBayar;
                Console.WriteLine();
                Console.WriteLine("====== Struk Pembayaran ======");
                Console.WriteLine("Total bayar: Rp" + totalBayar);
                Console.WriteLine("Uang Diterima: Rp" + uangPelanggan);
                Console.WriteLine("Kembalian: Rp" + kembalian);
                Console.WriteLine("Pembayaran Berhasil!");
            }
            else
            {
                Console.WriteLine("Maaf, Uang Pelanggan Tidak Mencukupi");
            }


            Console.WriteLine();
            Console.WriteLine("Total Bayar: Rp" + totalBayar);


            







        }
    }
}
ss