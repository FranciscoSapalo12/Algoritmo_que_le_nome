using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimo_que_le_nome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Enunciado========================
            /*1. Crie um algoritimo que lê o nome de uma pessoa e escrever "Olá"
             * seguido do nome da pessoa.
             */
            //Estrutura de dados
            string nome;
            //Algaritimo

            Console.WriteLine("Qual é o seu nome?");
            nome = Console.ReadLine();

            Console.WriteLine("Olá" + nome);
            Console.ReadLine();
        }
    }
}
