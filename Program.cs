using System.Runtime.InteropServices.Marshalling;

namespace variabel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Praktik 1
            //Nama : Kirani Ayu Habibah
            //Kelas : X PPLG 2
            //Membuat projek console
            //TEXT HALLO DUNIA
            Console.WriteLine("Hallo Dunia");
            Console.WriteLine("kirani ayu habibah");
            Console.WriteLine("x pplg 2");
            Console.WriteLine("pplg");

            //Praktik 2
            //nama : kirani ayu habibah
            //kelas : x pplg 2
            //perbedaan Console.Write dan Console.WriteLine
            Console.Write("kirani");
            Console.WriteLine("ayu");

            //Praktik 3
            //nama : kirani ayu habibah
            //kelas ; x pplg 2
            //membuat dan memanggil variabel
            string nama = "kirani ayu habibah";

            Console.WriteLine("nama :" + nama);
            Console.WriteLine("umur :" + nama);

            //raktik 4
            //nama : kirani ayu habibah
            //kelas : x pplg 2
            //Program input nama dan umur

            Console.Write("Masukkan nama :");
            string nama1 = Console.ReadLine();

            Console.Write("Masukkan nama :");
            int umur1 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("===DATA SISWA===");
            Console.WriteLine("Nama : " + nama);
            Console.WriteLine("Nama : " + umur1 + "tahun");

            //Praktik 5
            //nama : kirani ayu habibah
            //kelas : x pplg 2
            //program biodata sederhana

            Console.WriteLine("nama : kirani ayu habibah");
            string nama2 = Console.ReadLine();

            Console.WriteLine("kelas : x pplg 2");
            string kelas = Console.ReadLine();

            Console.WriteLine("jurusan : pplg");
            string jurusan = Console.ReadLine();

            Console.WriteLine("umur : 15 tahun");
            string umur = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("==== BIODATA SISWA ====");
            Console.WriteLine("nama : " + nama);
            Console.WriteLine("kelas : " + kelas);
            Console.WriteLine("jurusan : " + jurusan);
            Console.WriteLine("umur : " + umur1);

            //membuat variabel kosong
            string name;
            int age;

            Console.WriteLine("=== PROGRAM PENDAFTARAN PENDUDUK ===");
            Console.Write("masukkan nama");
            nama = Console.ReadLine();
            Console.WriteLine("masukkan alamat");
            var alamat = Console.ReadLine();
            Console.WriteLine("masukkan umur");
            umur = "int.Parse(Console.ReadLine())";

            Console.WriteLine();
            Console.WriteLine("terima kasih");
            Console.WriteLine("data berikut");
            Console.WriteLine($"nama: {nama}");
            Console.WriteLine($"alamat: {alamat}");
            Console.WriteLine($"umur: {umur}");
            Console.WriteLine("SUDAH DISIMPAN!");

            // membuat konstanta

            const float Phi = 3.14f;

            Console.WriteLine("== PROGRAM LUAS LINGKARAN ==");
            Console.Write("Input jari-jari");
            int r = int.Parse(Console.ReadLine());

            var luas = Phi * r * r;

            Console.WriteLine($"Luas Lingkaran = {luas}");

            int mangga, apel, hasil = 0;

            Console.Write("mangga =");
            mangga = int.Parse(Console.ReadLine());
            Console.Write("apple =");
            apel = int.Parse(Console.ReadLine());

            //operasi penjumlahan dengan operator +
            hasil = mangga + apel;

            Console.WriteLine($"hasil mangga + apple = {hasil}");

            int mango, apple, results = 0;

            Console.Write("mango = ");
            mango = int.Parse(Console.ReadLine());
            Console.WriteLine("apple = ");
            apple = int.Parse(Console.ReadLine());

            results = mango - apple;

            Console.WriteLine($"results mango - apple = {results}");

            int manggaa, apell = 0;

            Console.Write("mangga = ");
            manggaa = int.Parse(Console.ReadLine());
            Console.WriteLine("apell = ");
            apell = int.Parse(Console.ReadLine());

            results += manggaa * apell;

            Console.WriteLine($"results mangga * apell = {results}");

            int mango1, people, result = 0;

            Console.Write("jumlah mangga = ");
            mangga = int.Parse(Console.ReadLine());
            Console.Write("jumlah orang = ");
            people = int.Parse(Console.ReadLine());

            hasil = mangga / people;

            Console.WriteLine($"hasil mangga / people = {hasil}");

            int mangga1 = 3;
            int apel1 = 4;

            Console.WriteLine($"mangga = {mangga}");
            Console.WriteLine($"apel = {apel}");

            // increment
            mangga++;
            ++apel;

            Console.WriteLine($"mangga+1 = {mangga}");
            Console.WriteLine($"apel+1 = {apel}");

            // decrement
            mangga--;
            --apel;

            Console.WriteLine($"mangga-1 = {mangga}");
            Console.WriteLine($"apel-1 = {apel}");

            // mengisi operator = untuk mengisi nilai
            int mango2 = 10;
            int apple1 = 8;

            // mengisi ulang nilai variabel mangga
            mangga = 15;

            Console.WriteLine($"mangga = {mangga}");

            // menggunakan += untuk mengisi dan menjumlahkan
            apel += 6;

            Console.WriteLine($"apel = {apel}");

            int mangooo, appleee = 0;

            Console.Write("jumlah mangga =");
            mangga = int.Parse(Console.ReadLine());
            Console.Write("jumlah apel");
            apel = int.Parse(Console.ReadLine());

            Console.WriteLine("hasil perbandingan: ");
            Console.WriteLine($"mangga > apel : {mangga > apel}");
            Console.WriteLine($"mangga >= apel : {mangga >= apel}");
            Console.WriteLine($"mangga < apel : {mangga < apel}");
            Console.WriteLine($"mangga <= apel : {mangga <= apel}");
            Console.WriteLine($"mangga == apel : {mangga == apel}:");
            Console.WriteLine($"mangga != apel : {mangga != apel}:");

            Console.Write("enter your age");
            int age1 = int.Parse(Console.ReadLine());
            Console.Write("password");
            string password = (Console.ReadLine());

            bool isAdult = age1 > 18;
            bool isPasswordValid = isPasswordValid == "admin"; // pernyataan 2

            //menggunakan logika AND
            if (isAdult && isPasswordValid)
            {
                Console.WriteLine("WELCOME TO THE CLUB!");
            }
            else
            {
                Console.WriteLine("Sorry try again!");
            }
        }
    }
}