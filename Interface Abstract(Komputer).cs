using System;

    //interface abstarc
    interface IKomputer
    {
        void BeliKomputer();
    }

    // implement komputer biasa
    class Biasa : IKomputer
    {
        public void BeliKomputer()
        {
            Console.WriteLine("Membeli Komputer Biasa ...\n");
            Console.WriteLine("Rakitan Komputer Biasa Dengan Spesifikasi : ");
            Console.WriteLine("Prosesor     : Intel core i3");
            Console.WriteLine("Ram          : 4 GB DDR3");
            Console.WriteLine("Storage      : 500 GB HDD\n\n");
            Console.WriteLine("Terimakasih Telah Membeli Komputer Dari Toko Kami :D");
        }
    }

    // implement komputer gaming
    class Gaming : IKomputer
    {
        public void BeliKomputer()
        {
            Console.WriteLine("Membeli Komputer Gaming ...\n");
            Console.WriteLine("Rakitan Komputer Gaming Dengan Spesifikasi : ");
            Console.WriteLine("Prosesor     : Ryzen 7");
            Console.WriteLine("Ram          : 16 GB DDR4");
            Console.WriteLine("Storage      : 1000 GB HDD\n\n");
            Console.WriteLine("Terimakasih Telah Membeli Komputer Dari Toko Kami :D");
        }
    }

    // implement komputer Video Editing 
    class VideoEditing : IKomputer
    {
        public void BeliKomputer()
        {
            Console.WriteLine("Membeli Komputer Video Editing ...\n");
            Console.WriteLine("Rakitan Komputer Video Editing Dengan Spesifikasi : ");
            Console.WriteLine("Prosesor     : Intel core i7");
            Console.WriteLine("Ram          : 32 GB DDR4");
            Console.WriteLine("Storage      : 2000 GB HDD\n\n");
            Console.WriteLine("Terimakasih Telah Membeli Komputer Dari Toko Kami :D");
        }
    }