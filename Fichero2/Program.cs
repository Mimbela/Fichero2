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
            //************hacer que el usuario ponga varias veces una frase hasta que escriba la palabra fin
            //*************creamos el fichero STREAMWRITER
            //StreamWriter fichero;
            //fichero = File.CreateText("RegistrodeUsuario.txt");

            //string frase = " "; //*****************inicializamos la frase

            //do
            //{
            //    Console.WriteLine("Introduce una frase: ");
            //    frase = Console.ReadLine();

            //    if (frase.ToUpper() != "FIN")
            //        fichero.WriteLine(frase);

            //} while (frase.ToUpper() != "FIN");
            //fichero.Close();
            //*******************************************************************************************************************************************

            //*****LEEMOS EL FICHERO STREAMREADER POR LÍNEAS

            //StreamReader fichero;
            //string linea;

            //fichero = File.OpenText("RegistrodeUsuario.txt");
            //linea = fichero.ReadLine();
            //Console.WriteLine(linea);
            //Console.WriteLine(fichero.ReadLine());
            //Console.WriteLine(fichero.ReadLine());

            //fichero.Close();

            //Console.ReadKey();

            //************LEEMOS TODO EL FICHERO ENTERO Y NO POR LÍNEAS

            //StreamReader fichero;
            //string linea;

            //fichero = File.OpenText("RegistrodeUsuario.txt");
            ////si está en otra ruta ponemos @"c:\ejemplos\fichero1.txt ó @"..\ejemplos\fichero1.txt"

            //do
            //{
            //    linea = fichero.ReadLine();
            //    if (linea != null)
            //        Console.WriteLine(linea);


            //} while (linea != null);
            //fichero.Close();
            //Console.ReadKey();

            //****************AÑADIMOS MAS LÍNEAS AL REGISTRO DE USUARIO SOBRE UN FICHERO QUE YA EXISTE

            //StreamWriter fichero;
            //fichero = File.AppendText("RegistrodeUsuario.txt");
            //fichero.WriteLine("otra linea mas");

            //fichero.Close();

            //**************************SI ABRO UN FICHERO Y PUEDA QUE NO EXISTA
            //****************************SIN TERMINAR

            //try
            //{

            //StreamReader fichero;
            //string linea;

            //fichero = File.OpenText("RegistrodeUsuario.txt");
            

            //do
            //{
            //    linea = fichero.ReadLine();
            //    if (linea != null)
            //        Console.WriteLine(linea);


            //} while (linea != null);
            //fichero.Close();
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
            //Console.ReadKey();

        }
    }
}


