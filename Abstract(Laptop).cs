using System;

    //abstract class Laptop
    abstract class Laptop
    {
        //Abstract Method 
        public abstract void BeliLaptop();
        //regular method
        public void beliL()
        {
            Console.WriteLine("Terimakasih Telah Membeli Laptop Dari Toko Kami :D");
        }
        
    }

    //inherit dari class laptop
    class Acer : Laptop
    {
        public override void BeliLaptop()
        {
            Console.WriteLine("Membeli Laptop Acer ....\n");
            Console.WriteLine("Acer Predator Dengan Spesifikasi : ");
            Console.WriteLine("Prosesor     : Intel Intel i7");
            Console.WriteLine("Ram          : 8 GB DDR4");
            Console.WriteLine("Storage      : 1000 GB HDD\n\n");
        }
    }

        //inherit dari class laptop
    class Asus : Laptop
    {
        public override void BeliLaptop()
        {
            Console.WriteLine("Membeli Laptop Asus ....\n");
            Console.WriteLine("Asus ROG Dengan Spesifikasi : ");
            Console.WriteLine("Prosesor     : Intel Core i7");
            Console.WriteLine("Ram          : 8 GB DDR4");
            Console.WriteLine("Storage      : 1000 GB SSHD\n\n");
        }
    }

    //inherit dari class laptop
    class Lenovo : Laptop
    {
        public override void BeliLaptop()
        {
            Console.WriteLine("Membeli Laptop Lenovo ....\n");
            Console.WriteLine("Lenovo thinkpad Dengan Spesifikasi : ");
            Console.WriteLine("Prosesor     : Intel core i5");
            Console.WriteLine("Ram          : 8 GB DDR4");
            Console.WriteLine("Storage      : 1000 GB HDD\n\n");
        }
    }
