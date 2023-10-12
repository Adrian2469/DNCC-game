using System;

namespace pertemuan2
{
    class Program
    {
        static void Main(string[] args)
        {
        /*
            // Operator Aritmatika
            var penjumlahan = 10 + 5;
            var pengurangan = 10 - 5;
            var perkalian = 10 * 5;
            var pembagian = 10 / 5;
            var modulo = 10 % 5;
            Console.WriteLine("Hasil penjumlahan : " + penjumlahan);
            Console.WriteLine("Hasil pengurangan : " + pengurangan);
            Console.WriteLine("Hasil perkalian : " + perkalian);
            Console.WriteLine("Hasil pembagian : " + pembagian);
            Console.WriteLine("Hasil modulo : " + modulo);
        */
        /*
            // Operator Penugasan
            int a = 10;
            
            a += 5;
            Console.WriteLine("Hasilnya adalah : " + a);
            a -= 5;
            Console.WriteLine("Hasilnya adalah : " + a);
            a *= 5;
            Console.WriteLine("Hasilnya adalah : " + a);
            a /= 5;
            Console.WriteLine("Hasilnya adalah : " + a);
            a %= 5;
            Console.WriteLine("Hasilnya adalah : " + a);
        */
        /*
            // Increment Decrement
            int a = 5;
            Console.WriteLine("++a nilainya : " + ++a);
            Console.WriteLine("a++ nilainya : " + a++);
            Console.WriteLine("a nilainya : " + a);
            Console.WriteLine("=====================");

            int b = 10;
            Console.WriteLine("++b nilainya : " + ++b);
            Console.WriteLine("b++ nilainya : " + b++);
            Console.WriteLine("b nilainya : " + b);
        */
        /*
            // Operator Perbandingan
            int a = 10;
            int b = 5;
            Console.WriteLine(a != b);
            Console.WriteLine(a == b);
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a <= b);
        */
        /*
            // Operator Logika
            int a = 10;
            string name = "joni";
            if (a != 10 || name == "jon")
            {
                Console.WriteLine("Benar");
            }
            else
            {
                Console.WriteLine("Salah");
            }
        */
            /*
            // Array
            string[] divisiDncc = {"Game","Web","Jaringan","Mobile","Data","Mulmed"};
            Console.WriteLine(divisiDncc[0]);
            Console.WriteLine(divisiDncc[1]);
            Console.WriteLine(divisiDncc[2]);
            Console.WriteLine(divisiDncc[3]);
            Console.WriteLine(divisiDncc[4]);
            Console.WriteLine(divisiDncc[5]);
            */
            /*
            // Array 2 Dimensi
            int[,] number = {{1,2},{3,4}};
            Console.WriteLine(number[0,1]);
            Console.WriteLine(number[1,0]);
            */
            /*
            // Array 3 Dimensi
            int[,,] number = {{{1,2},{3,4}},{{5,6},{7,8}}};
            Console.WriteLine(number[0,1,1]);
            */
        /*    
            // List
            var names = new List<string> {"Ucup","memet","joni"};
            for(int i=0; i<names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("=====================");

            // Add
            names.Add("Umi");
            names.AddRange(new string[2] {"Jono","Adi"});
            for(int i=0; i<names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("=====================");

            // Remove
            names.Remove("Ucup");
            for(int i=0; i<names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("=====================");

            // Remove at
            names.RemoveAt(0);
            for(int i=0; i<names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
        */
        /*
            // Pengkondisian
            // If Else
            int nilai = 80;
            if(nilai >= 85)
            {
                Console.WriteLine("Grade A");
            }
            else if(nilai >= 78)
            {
                Console.WriteLine("Grade B");
            } 
            else if(nilai >= 70)
            {
                Console.WriteLine("Grade C");
            }
            else 
            {
                Console.WriteLine("Grade D");
            }  
            Console.WriteLine("=====================");

            // Switch Case
            switch(nilai){
                case >= 85 :
                Console.WriteLine("Grade A");
                break;
                case >= 78 :
                Console.WriteLine("Grade B");
                break;
                case >= 70 :
                Console.WriteLine("Grade C");
                break;
                default:
                Console.WriteLine("Grade D");
                break;
            }
        */
        /*
            // Ternary Operator
            string hasil = (5 > 6) ? "Benar" : "Salah";
            Console.WriteLine(hasil);
        */
        /*
            // Perulangan
            var names = new List<string> {"Ucup","memet","joni"};

            // For
            for(int i=0;i<3;i++)
            {
                Console.WriteLine(names[i]);
            }
            
            // While (Cek kondisi dulu lalu lakukan)
            
            int i = 0;
            while(i<3){
                Console.WriteLine(i);
                i++;
            }
            Console.WriteLine("=====================");

            // Do While (Lakukan dulu lalu cek kondisi)
            int j = 2;
            do{
                Console.WriteLine(j);
                j++;
            } while(j<4);

            // For Each
            foreach(var name in names)
            {
                Console.WriteLine(name);
            }
            
        */
        /*    
            // Break (Menghentikan perulangan)
            for(int i=0;i<10 ;i++){
                Console.WriteLine(i);
                if(i==5){
                    break;
                }
            }
            Console.WriteLine("=====================");
            // Continue (Melanjutkan looping)
            for(int j=0;j<10 ;j++){
                if(j%2==1){
                    continue;
                }
                Console.WriteLine(j);
            }
        */
            // Function
        /*    
            FungsiCetak();

            int hasil=tambah();
            Console.WriteLine(hasil);
            
            Tampil("Adrian");
        */
        }

        static void FungsiCetak(){
                Console.WriteLine("Halo, saya Adrian");
        }

        static int tambah(){
            int a=10;
            int b=5;
            return a+b;
        }

        static void Tampil(string name){
            Console.WriteLine("Halo " + name);
        }
    }
}