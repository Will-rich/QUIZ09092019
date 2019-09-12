using System;

namespace hellodunia
{
    class bangundatar
    {
        public string nampil()
        {
            return "Hello William";
        }

        public void luas_persegi()
        {
            int sisi, luas;

            Console.Write("nilai sisi adalah ");
            sisi=Convert.ToInt32(Console.ReadLine());

            luas=sisi*sisi;
            Console.WriteLine("luas persegi adalah "+luas+"\n");

    
        }
    

        public void luas_segitiga()
        {
            int alas,tinggi;
            double pi;
            pi=0.5;
            double luas;

            Console.Write("nilai alas adalah ");
            alas=Convert.ToInt32(Console.ReadLine());

            Console.Write("nilai tinggi adalah ");
            tinggi=Convert.ToInt32(Console.ReadLine());

            luas=pi*alas*tinggi;
            Console.WriteLine("luas segitiga adalah "+luas+"\n");


        }
    
        public void luas_lingkaran()
        {
            int r;
            double phi;
            phi=3.14;
            double luas;

            Console.Write("nilai jari-jari adalah ");
            r=Convert.ToInt32(Console.ReadLine());

            luas=phi*r*r;
            Console.WriteLine("Luas lingkaran adalah "+luas+"\n");
            

        }
        

    }
}
