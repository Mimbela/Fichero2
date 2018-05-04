using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fichero2
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter fichero;
            fichero = File.CreateText("RegistrodeUsuario.txt");//creamos el fichero

            string frase = " "; //inicializamos la frase

            do
            {
                Console.WriteLine("Introduce una frase: ");
                frase = Console.ReadLine();

                if (frase.ToUpper() != "FIN")
                    fichero.WriteLine(frase);
                 
            } while (frase.ToUpper() != "FIN");

        }
    }
}


//hacer que el usuario ponga varias veces una frase hasta que escriba la palabra fin