using System;
using инструменты_ДанЗам;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Instrument[] instruments = new Instrument[] { new Gitara(1), new Baraban(2), new Truba(3) };
            for (int i = 0; i < instruments.Length; i++)
            {
                instruments[i].play();
            }
        }
    }
}