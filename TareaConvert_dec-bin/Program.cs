using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TareaConvert_dec_bin
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numero;
            int res=0;
            string cad="";
            Console.WriteLine("=============Convercion de Decimal a Binario==============");
            Console.Write("Ingrese el numero a convertir_ ");
            Numero = Convert.ToInt32(Console.ReadLine());
            while(Numero>0)
            {
                res = Numero % 2;
                if(res == 0)
                {
                    cad = "0"+cad;
                }
                else
                {
                    cad = "1"+cad;
                }
                Numero =(int)Numero / 2;
            }
            Console.Write("El numero en Binario es:_ "+cad+" base2");
            Console.ReadKey();
        }
    }
}
