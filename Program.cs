using System;

namespace Abstraction_2685
{
    class Program
    {
        static void Main(string[] args)
        {
            int pilih;
            do
            {
            Console.WriteLine("\n======== Toko Laptop & Komputer Awan ========\n");
            Console.WriteLine("Barang apa yang ingin anda beli : ");
            Console.WriteLine("1. Laptop ");
            Console.WriteLine("2. Komputer ");
            Console.WriteLine("3. Keluar ");
            Console.WriteLine("Masukan Pilihan Anda [1/2]  = ");
            pilih =Convert.ToInt32(Console.ReadLine());
            
            if(pilih ==1)
            {
                Console.WriteLine("\n======== Laptop Toko Awan ========\n");
                Console.WriteLine("Laptop apa yang ingin ingin anda beli : ");
                Console.WriteLine("1. Acer ");
                Console.WriteLine("2. Asus");
                Console.WriteLine("3. Lenovo \n");
                Console.WriteLine("Masukan Pilihan Anda [1-3]  = ");
                int pilihlaptop =Convert.ToInt32(Console.ReadLine());

                if(pilihlaptop==1)
                {
                    // Laptop Acer 
                    Acer myAcer = new Acer();
                    myAcer.BeliLaptop();
                    myAcer.beliL();
                }

                else if(pilihlaptop==2)
                {
                    // Laptop Asus 
                    Asus myAsus = new Asus();
                    myAsus.BeliLaptop();
                    myAsus.beliL();
                }

                else if(pilihlaptop==3)
                {
                    // Laptop Lenovo
                    Lenovo myLenovo = new Lenovo();
                    myLenovo.BeliLaptop();
                    myLenovo.beliL();
                }

                else 
                {Console.WriteLine("Maaf Pilihan Tidak Tersedia");}

              
            }
            
            else if (pilih ==2)
            {
                Console.WriteLine("\n======== Komputer Toko Awan ========\n");
                Console.WriteLine("Komputer apa yang ingin ingin anda beli : ");
                Console.WriteLine("1. Komputer Biasa ");
                Console.WriteLine("2. Komputer Gaming");
                Console.WriteLine("3. Komputer VideoEditing \n");
                Console.WriteLine("Masukan Pilihan Anda [1-3]  = ");
                int pilihkomputer =Convert.ToInt32(Console.ReadLine());

                if(pilihkomputer==1)
                {
                    Biasa myBiasa = new Biasa();
                    myBiasa.BeliKomputer();
                }

                else if(pilihkomputer==2)
                {
                    Gaming myGaming = new Gaming();
                    myGaming.BeliKomputer();
                }

                else if(pilihkomputer==3)
                {
                    VideoEditing myVideoEditing = new VideoEditing();
                    myVideoEditing.BeliKomputer();
                }

                else
                {Console.WriteLine("Maaf Pilihan Tidak Tersedia");}

                
            }
                
            

            }while(pilih !=3);
            
            
        }
    }
}
