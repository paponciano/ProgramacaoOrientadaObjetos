using System;
using ProgramacaoOrientadaObjetos.Cadastros;

namespace ProgramacaoOrientadaObjetos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Pessoa objetoPessoa = new();
            objetoPessoa.Nome = "Paulo";
            objetoPessoa.Sobrenome = "Ponciano";
            Console.WriteLine($"O nome da pessoa é: {objetoPessoa.Nome} {objetoPessoa.Sobrenome}");

            Pessoa novoObjetoPessoa = new("Maria", "Silva", DateTime.Now);
            Console.WriteLine($"O nome da pessoa do novo objeto é: {novoObjetoPessoa.Nome} {novoObjetoPessoa.Sobrenome}");

        }
    }
}