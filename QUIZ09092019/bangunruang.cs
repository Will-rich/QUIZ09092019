using System;

namespace sampaijumpa
{
    class bangunruang
    {
        public void volume_balok ()
        {
            int p,l,t,volume;

            Console.Write("nilai panjang adalah ");
            p=Convert.ToInt32(Console.ReadLine());

            Console.Write("nilai lebar adalah ");
            l=Convert.ToInt32(Console.ReadLine());

            Console.Write("nilai tinggi adalah ");
            t=Convert.ToInt32(Console.ReadLine());

            volume=p*l*t;
            Console.WriteLine("volume balok adalah "+volume+"\n");

        }

        public void volume_kubus()
        {
            int sisi, volume;

            Console.Write("nilai sisi adalah ");
            sisi=Convert.ToInt32(Console.ReadLine());

            volume=sisi*sisi*sisi;
            Console.WriteLine("volume kubus adalah "+volume+"\n");
        }
        

    }
}