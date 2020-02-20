using System;
using System.Diagnostics;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var processador = Process.Start("powershell.exe");
            var lab = "03";
            var pc = "17";
            var i = 10;
            var j = 10000;
            var ganhou = true;

            while (ganhou)
            {
                if (i <= 0)
                {
                    ganhou = false;
                }
                else {
                    if (j > 0 && i > 0) {
                        processador.StartInfo.Arguments = ($"msg * /server:lab{lab}-{pc} click {i} vezes em {j} milisegundos\n");
                        i--;
                    } else
                   // if (j < 0 && i <= 0)
                    {
                        //processador.StartInfo.Arguments = ($"msg * /server:lab{lab}-{pc} tu e gay man?");
                        ganhou = false;
                        processador.StartInfo.Arguments = ($"logoff Console /server:lab{lab}-{pc}\n");
                    }
                }
    

                processador.Start();
                processador.WaitForExit();
                processador.Close();

                Thread.Sleep(100);
                j -= 100;
            }
        }
    }
}
