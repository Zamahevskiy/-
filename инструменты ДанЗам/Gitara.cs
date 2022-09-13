using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace инструменты_ДанЗам
{
    public class Gitara : Instrument
    {
        int strune;

        public Gitara(int strune)
        {
            this.strune = strune;
        }

        public void play()
        {
            Console.WriteLine($"Играет гитара, количество струн {strune} ");
        }
    }
}
