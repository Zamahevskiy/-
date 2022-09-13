using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace инструменты_ДанЗам
{
    public class Baraban : Instrument
    {
        int Size;
        public Baraban(int Size)
        {
            this.Size = Size;
        }

        public void play()
        {
            Console.WriteLine($"Играет барабан, размером {Size}");
        }
    }
}
