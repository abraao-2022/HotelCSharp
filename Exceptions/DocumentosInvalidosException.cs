namespace HotelCsharp.Exceptions
{
    public class DocumentosInvalidosException : Exception
    {
        public DocumentosInvalidosException() : base("Documentos invalidos, verifique!")
        {
        }

        public DocumentosInvalidosException(string mensagem) : base(mensagem)
        {

        }
    }
}