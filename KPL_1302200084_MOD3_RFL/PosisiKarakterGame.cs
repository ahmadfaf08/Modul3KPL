using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPL_1302200084_MOD3_RFL
{
    internal class PosisiKarakterGame
    {
        enum State { TombolX, TombolW, Exit };

        public static void Mulai()
        {
            Console.WriteLine("Masukan State");
            State state = State.TombolX;
            while (state != State.Exit)
            {
                string command = Console.ReadLine();
                switch (command)
                {
                    case "TombolX":
                        Console.WriteLine("posisi landing");
                        Console.WriteLine();
                        break;
                    case "TombolW":
                        Console.WriteLine("posisi take off");
                        Console.WriteLine();
                        break;
                    case "Exit":
                        state = State.Exit;
                        break;
                    default:
                        Console.WriteLine("Masukan Ulang State");
                        break;

                }
            }
        }
    }
}

