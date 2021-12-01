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

            Console.WriteLine("Digite a sua data de nascimento: (dd/MM/aaaa)");
            string? textoDataNascimento = Console.ReadLine();
            int ano = Convert.ToInt32(textoDataNascimento?.Substring(6, 4));
            int mes = Convert.ToInt32(textoDataNascimento?.Substring(3, 2));
            int dia = Convert.ToInt32(textoDataNascimento?.Substring(0, 2));
            
            Pessoa novoObjetoPessoa = new("Maria", "Silva", new DateTime(ano, mes, dia));
            Console.WriteLine($"O nome da pessoa do novo objeto é: {novoObjetoPessoa.Nome} {novoObjetoPessoa.Sobrenome}. {novoObjetoPessoa.CalculaIdade()}");   
        }
    }
}