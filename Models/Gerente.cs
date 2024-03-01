using HotelCsharp.Interfaces;

namespace HotelCsharp.Models
{
    public class Gerente : Pessoa, IGerente
    {
        public Gerente()
        {
        }

        public Gerente(string nome, string cpf, string telefone) : base(nome, cpf, telefone)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
        }

        public void ArrumarACama()
        {
            System.Console.WriteLine("sou gerente e sei arrumar a cama ");
            System.Console.WriteLine();
        }

        public void AtenderOTelefone()
        {
            System.Console.WriteLine("sou gerente e sei atender o telefone ");
            System.Console.WriteLine();
        }

        public void ConhecerMuitoBemOHotel()
        {
            System.Console.WriteLine("sou gerente e conheço tudo do hotel ");
            System.Console.WriteLine();
        }

        public void FalarOBasicoDeIngles()
        {
            System.Console.WriteLine("sou gerente e domino ingles ");
            System.Console.WriteLine();
        }

        public void LimparOQuarto()
        {
            System.Console.WriteLine("sou gerente e sei limpar o quarto ");
            System.Console.WriteLine();
        }

        public override void SeApresentar()
        {
            System.Console.WriteLine("Prazer sou o gerente " + Nome);
            System.Console.WriteLine();
        }
    }
}