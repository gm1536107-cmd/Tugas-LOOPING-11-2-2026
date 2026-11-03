using System;

namespace WhileLoop
{
    class Home
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====FOR LOOP=====");
            Console.WriteLine("Contoh FOR ke 1");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(", " + i);
            }
            Console.WriteLine();
            Console.WriteLine("Contoh FOR ke 2(Bilangan Genap)");
            for (int i = 2; i < 10; i += 2)
            {
                Console.Write(", " + i);
            }
            Console.WriteLine();
            Console.WriteLine("Contoh FOR ke 3(Bilangan Ganjil)");
            for (int i = 1; i < 10; i += 2)
            {
                Console.Write(", " + i);
            }
            Console.WriteLine();
            Console.WriteLine("Contoh FOR ke 4(Hitung mundur)");
            for (int i = 10; i > 0; i--)
            {
                Console.Write(", " + i);
            }
            Console.WriteLine();
            Console.WriteLine("Contoh FOR ke 5(Dikuadratkan)");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(", " + (i * i));
            }
            Console.WriteLine();
            Console.WriteLine("=====WHILE LOOP=====");

            Console.WriteLine("Contoh WHILE ke 1");
            int w1 = 1;
            while( w1  < 10 )
            {
                Console.Write(", " + w1);
                w1++;
            }
            Console.WriteLine();

            Console.WriteLine("Contoh WHILE ke 2(Menampilkan Ganji)");
            int w2 = 1;
            while (w2 < 10)
            {
                Console.Write(", " + w2);
                w2+=2;
            }
            Console.WriteLine();

            Console.WriteLine("Contoh WHILE ke 3(Menampilkan Genap)");
            int w3 = 2;
            while (w3 < 10)
            {
                Console.Write(", " + w3);
                w3 += 2;
            }
            Console.WriteLine();

            Console.WriteLine("Contoh WHILE ke 4(Menampilkan Bilangan yang dikuadaratkan)");
            int w4 = 1;
            while (w4 < 10)
            {
                Console.Write(", " + w4 * w4);
                w4++;
            }
            Console.WriteLine();

            Console.WriteLine("Contoh WHILE ke 5(Menampilkan Teks 3 kali)");
            int w5 = 1;
            while (w5 <= 3)
            {
                Console.Write($"Jam ke {w5}, ");
                w5++;
            }
            Console.WriteLine();

            Console.WriteLine("=====Do While=====");

            Console.WriteLine("Contoh Do While ke 1");
            int dw1 = 1;
            do
            {
                Console.Write(", " + dw1);
                dw1++;
            } while(dw1 < 10);
            Console.WriteLine();

            Console.WriteLine("Contoh Do While ke 2(Menampilkan angka kuadrat)");
            int dw2 = 1;
            do
            {
                Console.Write(", " + dw2 * dw2);
                dw2++;
            } while (dw2 < 10);
            Console.WriteLine() ;

            Console.WriteLine("Contoh Do While ke 3(Menampilkan angka Genap)");
            int dw3 = 2;
            do
            {
                Console.Write(", " + dw3);
                dw3+=2;
            } while (dw3 < 10);
            Console.WriteLine();

            Console.WriteLine("Contoh Do While ke 4(Menampilkan angka Ganjil)");
            int dw4 = 1;
            do
            {
                Console.Write(", " + dw4);
                dw4=+2;
            } while (dw2 < 10);
            Console.WriteLine();

            Console.WriteLine("Contoh Do While ke 5(Menampilkan angka Prima)");
            int dw5 = 0;
            do
            {
                if(dw5 == 2 || dw5  == 3 || dw5  == 5 || dw5 == 7 ||(dw5 > 5 && dw5 % 2 != 0 && dw5 % 3 != 0 && dw5 % 5 != 0))
                { 
                    Console.Write(dw5);
                }
                dw5++;
            } while (dw5 < 20);
            Console.WriteLine();

            Console.WriteLine("=====FOREACH=====");

            Console.WriteLine("Contoh Foreach ke 1");
            int[] FE1 = { 1, 2, 3, 4, 5 };
            foreach(int i in FE1)
            {
                Console.Write(", " + i);
            }
            Console.WriteLine();

            Console.WriteLine("Contoh Foreach ke 2(Menampilkan daftar nama buah)");
            string[] FE2 = { "Pisang", "Apel", "Nanas" };
            foreach (string i in FE2)
            {
                Console.Write("Buah: " + i + ", ");
            }
            Console.WriteLine();

            Console.WriteLine("Contoh Foreach ke 3(Menjumlahkan nilai dari 1, 2, 3, 4, 5)");
            int[] FE3 = { 1, 2, 3, 4, 5 };
            int sumFE = 0;
            foreach (int n in FE3)
            {
                sumFE += n;
            }
            Console.Write(", " + sumFE);
            Console.WriteLine();

            Console.WriteLine("Contoh Foreach ke 4(Karakter dalam kata)");
            string kata = "SMKN";
            foreach(char  c in kata)
            {
                Console.Write($"{c}, ");
            }
            Console.WriteLine();

            Console.WriteLine("Contoh Foreach ke 5(Menampilkan nama hari dalam sepekan)");
            List<string> hari = new List<string> {"senin", "selasa","rabu", "kamis", "jum'at", "sabtu", "minggu"};
            foreach(string h in hari)
            {
                Console.Write("hari: " + h + ", ");
            }
            Console.WriteLine();

            Console.WriteLine("=====ARRAY=====");

            Console.WriteLine("Contoh Array ke 1(Daftar nama siswa)");
            string[] namaS = { "Andi", "Budi", "Dani", "Eva" };
            for (int i = 1;  i < namaS.Length; i++)
            {
                Console.WriteLine(namaS[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Contoh Array ke 2(Nilai rata rata)");
            double[] nilai = { 87, 86, 90, 84, 97 };
            double total = 0;
            for(int i = 0; i < nilai.Length; i++)
            {
                total += nilai[i];
            }
            double ratarata = total/nilai.Length;
            Console.WriteLine("Rata rata nilai adalah: " + ratarata);
            Console.WriteLine();

            Console.WriteLine("Contoh  Array ke 3(Mencari nilai tertinggi)");
            int[] angka = { 12, 28, 21, 18, 14 };
            int max = angka[0];
            for(int i = 1;i < angka.Length;i++)
            {
                if (angka[i] > max)
                {
                    max = angka[i];
                }
            }
            Console.WriteLine("Nilai tertinggi: " + max);
            Console.WriteLine();

            Console.WriteLine("Contoh Array ke 4(Modifikasi Elemen Array)");
            string[] kota = { "Sidoarjo", "Surabaya", "Malang" };
            Console.WriteLine("Sebelum diubah: " + kota[0]);
            kota[0] = "Sidoarjo Jaya";
            Console.WriteLine("Setelah diubah: " + kota[0]);
            Console.WriteLine();

            Console.WriteLine("Contoh Array ke 5{Menampilkan isi array secara terbalik)");
            int[] angkaRev = { 0, 1, 2, 3, 4, 5, };
            for (int i = angkaRev.Length -1; i >= 0; i--)
            {
                Console.Write(", " + angkaRev[i]);
            }
            Console.WriteLine();

            Console.WriteLine("=====LIST=====");

            Console.WriteLine("Contoh list ke 1(list siswa)");
            List<string> SiswaList = new List<string>();
            SiswaList.Add("Andi");
            SiswaList.Add("Budi");
            SiswaList.Add("Agus");

            foreach (string s in SiswaList)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            Console.WriteLine("Contoh list ke 2(Menghapus Elemen list)");
            List<string> pelajaran = new List<string> { "C#", "Java", "Python", "PHP" };
            pelajaran.Remove("PHP");

            foreach( string p in pelajaran)
            {
                Console.WriteLine("Mapel: " + p);
            }
            Console.WriteLine();

            Console.WriteLine("Contoh list ke 3(menghitung Elemen list)");
            List<int> harga = new List<int> { 2000, 2500, 3000, 3500};
            Console.WriteLine("Harga barang: " + harga.Count);
            Console.WriteLine();

            Console.WriteLine("Contoh list ke 4(mengurutkan data(sort))");
            List<string> hewan = new List<string> { "kucing", "anjing", "rubah", "elang", "aligator" };
            hewan.Sort();
            foreach( string h in hewan)
            {
                Console.WriteLine($"{h}");
            }
            Console.WriteLine() ;

            Console.WriteLine("Contoh list ke 5(cek keberadaan elemen)");
            List<string> hobi = new List<string> { "Coding", "Gaming", "Reading" };
            if (hobi.Contains("Coding"))
            {
                Console.WriteLine("Hobi 'Coding' ada di dalam daftar!");
            }

        }
    }
}
