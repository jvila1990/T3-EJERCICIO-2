using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO2
{
    class ArbolBinario
    {
        public Nodo raiz;

        public Nodo GetRaiz()
        {
            return raiz;
        }

        public void Inorden(Nodo raiz)
        {
            if (raiz != null)
            {
                Inorden(raiz.izquierdo);
                Console.WriteLine("{0},  {1} ,{2}", raiz.valor, raiz.valor2, raiz.valor3);
                Inorden(raiz.derecho);
            }
        }

        public void Preorden(Nodo raiz)
        {
            if (raiz != null)
            {
                Console.WriteLine("{0},  {1} ,{2}", raiz.valor, raiz.valor2, raiz.valor3);
                Preorden(raiz.izquierdo);
                Preorden(raiz.derecho);
            }
        }

        public void Postorden(Nodo raiz)
        {
            if (raiz != null)
            {
                Postorden(raiz.izquierdo);
                Postorden(raiz.derecho);
                Console.WriteLine("{0},  {1} ,{2}", raiz.valor, raiz.valor2, raiz.valor3);
            }
        }

        public void InsertarNodo(int valor, string valor2, string valor3)
        {
            Nodo puntero;
            Nodo padre;
            Nodo nodo = new Nodo
            {
                valor = valor,
                valor2 = valor2,
                valor3 = valor3,
            };
            if (raiz != null)
            {
                puntero = raiz;
                while (true)
                {
                    padre = puntero;
                    if (valor < puntero.valor)
                    {
                        puntero = puntero.izquierdo;
                        if (puntero == null)
                        {
                            padre.izquierdo = nodo;
                            break;
                        }
                    }
                    else
                    {
                        puntero = puntero.derecho;
                        if (puntero == null)
                        {
                            padre.derecho = nodo;
                            break;
                        }
                    }
                }
            }
            else
            {
                raiz = nodo;
            }
        }

        public void BuscarPorValor(Nodo puntero, string valor2, int contador)
        {
            if (puntero != null)
            {
                contador += 1;
                if (puntero.valor2 == valor2)
                {
                    Console.WriteLine("{0} encontrado en posición {1}", puntero.valor2, puntero.valor);
                    Console.WriteLine("Total de iteraciones:" + contador);
                    return;
                }
                BuscarPorValor(puntero.izquierdo, valor2, contador);
                BuscarPorValor(puntero.derecho, valor2, contador);
            }
            else
            {
                Console.WriteLine("Total de iteraciones:" + contador);
            }
        }

        public void BuscarPorLlave(int llave)
        {
            int contador = 0;
            Nodo puntero = raiz;
            while (puntero != null)
            {
                contador += 1;
                if (puntero.valor == llave)
                {
                    Console.WriteLine("Llave {0} encontrada", puntero.valor);
                    Console.WriteLine("Valor de la llave: {0} ", puntero.valor2);
                    Console.WriteLine("Total de iteraciones:" + contador);
                    return;
                }
                else
                {
                    if (llave > puntero.valor)
                    {
                        puntero = puntero.derecho;
                    }
                    else
                    {
                        puntero = puntero.izquierdo;
                    }
                }
            }
            Console.WriteLine("No se encontró la llave");
            Console.WriteLine("Total de iteraciones:" + contador);
        }


    }
}
