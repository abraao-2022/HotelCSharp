using HotelCsharp.Interfaces;

namespace HotelCsharp.Models
{
    public class Camareira : Pessoa, ICamareira
    {
        public Camareira()
        {
        }

        public Camareira(string nome, string cpf, string telefone) : base(nome, cpf, telefone)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
        }

        public void ArrumarACama()
        {
            System.Console.WriteLine("Sei arrumar a cama.");
            System.Console.WriteLine();
        }

        public void LimparOQuarto()
        {
            System.Console.WriteLine("Sei limpar o quarto.");
            System.Console.WriteLine();
        }

        public override void SeApresentar()
        {
            System.Console.WriteLine("Prazer, sou a camareira " + Nome);
            System.Console.WriteLine();
        }
    }
}