namespace HotelCsharp.Models
{
    public class Cliente : Pessoa
    {
        public Cliente() : base()
        {
        }

        public Cliente(string nome, string cpf, string telefone) : base(nome, cpf, telefone)
        {
            Nome = nome;
            CPF = cpf;
            Telefone = telefone;
        }

        public override void SeApresentar()
        {
            System.Console.WriteLine("Prazer, sou o cliente " + Nome);
            System.Console.WriteLine();
        }
    }
}