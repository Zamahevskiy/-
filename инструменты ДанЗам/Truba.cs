using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace инструменты_ДанЗам
{
    public class Truba : Instrument
    {
        int Diametr;
        public Truba(int Diameter)
        {
            this.Diametr = Diametr;
        }

        public void play()
        {
            Console.WriteLine($"Играет труба, диаметр {Diametr} ");
        }
    }
}
