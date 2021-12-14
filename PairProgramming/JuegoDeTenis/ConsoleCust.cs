using System;
using System.Collections.Generic;
using System.Text;

namespace JuegoDeTenis
{
    public class ConsoleCust : IConsole
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void WriteLine(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
