using HotelCsharp.Interfaces;

namespace HotelCsharp.Models
{
    public class Recepcionista : Pessoa, IRecepcionista
    {
        public Recepcionista()
        {
        }

        public Recepcionista(string nome, string cpf, string telefone) : base(nome, cpf, telefone)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
        }

        public void AtenderOTelefone()
        {
            System.Console.WriteLine("sei atender o telefone");
            System.Console.WriteLine();
        }

        public void FalarOBasicoDeIngles()
        {
            System.Console.WriteLine("sei falar o basico de ingles ");
            System.Console.WriteLine();
        }

        public override void SeApresentar()
        {
            System.Console.WriteLine("Prazer, sou a recepcionista " + Nome);
            System.Console.WriteLine();
        }
    }
}