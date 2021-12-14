using System;
using System.Collections.Generic;
using System.Text;

namespace JuegoDeTenis
{
    public interface IConsole
    {
        void WriteLine(string msg);
        string ReadLine();
    }
}
