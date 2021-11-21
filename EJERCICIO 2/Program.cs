using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolBinario arbol = new ArbolBinario();
            arbol.InsertarNodo(5, "Historia Clinica 5", "Paciente 5");
            arbol.InsertarNodo(1, "Historia Clinica 1", "Paciente 1");
            arbol.InsertarNodo(6, "Historia Clinica 6", "Paciente 6");
            arbol.InsertarNodo(10, "Historia Clinica 10", "Paciente 10");
            arbol.InsertarNodo(11, "Historia Clinica 11", "Paciente 11");
            arbol.InsertarNodo(15, "Historia Clinica 15", "Paciente 15");

            //Busqueda por dato
            Console.WriteLine("--------------------------");
            Console.WriteLine("Buscamos Historia Clinica 15...");
            Console.WriteLine("--------------------------");
            arbol.BuscarPorValor(arbol.GetRaiz(), "Historia Clinica 15", 0);
            Console.WriteLine("");

           


            //INORDEN - PREORDEN - POSTORDEN
            Console.WriteLine("--------------------------");
            Console.WriteLine("Inorden:");
            arbol.Inorden(arbol.GetRaiz());
            Console.WriteLine("");


            //Busqueda por dato
            Console.WriteLine("--------------------------");
            Console.WriteLine("Buscamos Historia Clinica 15...");
            Console.WriteLine("--------------------------");
            arbol.BuscarPorValor(arbol.GetRaiz(), "Historia Clinica 15", 0);
            Console.WriteLine("");





            Console.Read();


        }
    }
}
