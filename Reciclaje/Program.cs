using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.ExceptionServices;

namespace Reciclaje
{

    static class Program
    {
        static void Main(String[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Diagnostico());
        }

        static void ThrowEx1()
        {
            throw new AccessViolationException();
        }
    }
}
