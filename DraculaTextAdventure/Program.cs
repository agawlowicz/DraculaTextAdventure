using System;
using System.Threading;

namespace DraculaTextAdventure
{
    class Program
    {
        public static bool cont = true;

        static void Main(string[] args)
        {
            while (cont == true)
            {
                Decisions.Instructions();

                Decisions.GamePlay();

            }
        }
    }
}
