using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace VERIFICACIÓN_DE_UNA_CLAVE_3_OPORTUNIDADES
{
    class Program
    {
        static void Main(string[] args)
        {
            byte K, SW;
            string CLAVE;
            SW = 0; K = 0;
            do
            {
                Console.Write("DIGITE CLAVE: "); CLAVE = Console.ReadLine();
                if ((CLAVE.ToUpper() == "ARIEL"))
                {
                    SW = 1;
                }
                else
                {
                    K++;
                }
            } while (((K < 3) & (SW == 0)));
            if (SW == 1)
            {
                Console.WriteLine("BIENVENIDO " + CLAVE);
            }
            else
            {
                Console.WriteLine("OPORTUNIDADES TERMINADAS");
            }
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
    }
}