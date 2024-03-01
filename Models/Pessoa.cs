using HotelCsharp.Interfaces;

namespace HotelCsharp.Models
{
    public abstract class Pessoa : IPessoa
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }

        public Pessoa()
        {
        }

        public Pessoa(string nome, string cpf, string telefone)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
        }

        public virtual void SeApresentar()
        {
            System.Console.WriteLine("Sou a pessoa " + Nome);
            System.Console.WriteLine();
        }
    }
}