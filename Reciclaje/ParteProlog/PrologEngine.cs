using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SbsSW.SwiPlCs;

namespace Reciclaje.ParteProlog
{
    public static class PrologEngine
    {
        public static bool Start(string filePath)
        {
            if (PlEngine.IsInitialized)
                return true;

            string currentSystemPath = Environment.GetEnvironmentVariable("Path");
            
            Environment.SetEnvironmentVariable(@"Path", currentSystemPath + @";swipl;swipl\bin");

            string[] args = { "-q", "-f", filePath };

            try
            {
                PlEngine.Initialize(args);
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}