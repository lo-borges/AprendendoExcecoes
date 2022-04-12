﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendendoExceções
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Metodo();
            }
            catch (DivideByZeroException excecao)
            {
                Console.WriteLine("Não é possível divisão por 0");
            }
            catch (Exception excecao)
            {
                Console.WriteLine(excecao.Message);
                Console.WriteLine(excecao.StackTrace);
            }

            Console.ReadLine();
        }

        static int Dividir(int numero, int divisor)
        {
            try
            {
                return numero / divisor;
            }
            catch (Exception)
            {
                Console.WriteLine("Exceção com numero= " + numero + " e divisor= " + divisor);
                throw;
            }
        }

        static void Metodo()
        {
            TestaDivisao(0);

        }

        static void TestaDivisao(int divisor)
        {
            Dividir(10, divisor);
        }
    }
}
