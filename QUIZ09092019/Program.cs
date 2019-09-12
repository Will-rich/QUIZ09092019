using System;
using hellodunia;
using sampaijumpa;

namespace QUIZ09092019
{
    class Program
    {
        static void Main(string[] args)
        {
            bangundatar halo=new bangundatar();
            bangunruang halo1=new bangunruang();

            Console.WriteLine("kelas saya X TKJ 1"+"\n");

            halo.nampil();
            halo.luas_persegi();
            halo.luas_segitiga();
            halo.luas_lingkaran();
            halo1.volume_balok();
            halo1.volume_kubus();

        }
    }
}
