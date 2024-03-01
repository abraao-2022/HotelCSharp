using HotelCsharp.Exceptions;
using HotelCsharp.Interfaces;
using HotelCsharp.Models;

Console.WriteLine("***********************************");
Console.WriteLine("********** Hotel Csharp ***********");
Console.WriteLine("***********************************");
Console.WriteLine();


ICamareira camareira1 = new Camareira("Joana da silva", "12345678901", "021977886655");
ICamareira camareira2 = new Camareira("Maria da silva", "12345678911", "021977886633");

IRecepcionista recepcionista1 = new Recepcionista()
{
    Nome = "Mariana Silveira",
    CPF = "98765432101",
    Telefone = "021988552233",
};
IRecepcionista recepcionista2 = new Recepcionista("Jessica Albuquerque", "98765432102", "021986548755");

IGerente gerente1 = new Gerente("Fulano de tal", "7788996655441", "02118852211");
IGerente gerente2 = new Gerente("Ciclano de tal", "7788996655461", "02118852212");


Hotel hotel = new Hotel("Hotel CSharp", new Endereco()
{
    CEP = "25985630",
    Rua = "Rua xyz",
    Numero = 58,
    Complemento = "Esquina 3",
    Bairro = "Lugar Nenhum",
    Cidade = "Qualquer lugar"
});

hotel.ContratarCamareira(camareira1);
hotel.ContratarCamareira(camareira2);

hotel.ContratarRecepcionista(recepcionista1);
hotel.ContratarRecepcionista(recepcionista2);

hotel.ContratarGerente(gerente1);

hotel.ContratarCamareira(gerente2);
hotel.ContratarRecepcionista(gerente2);

hotel.Gerente.SeApresentar();

foreach (var camareira in hotel.Camareiras)
{
    camareira.SeApresentar();
}

foreach (var recepcionista in hotel.Recepcionistas)
{
    recepcionista.SeApresentar();
}

IRHTerceirizado rh = new RH("RH Csharp", hotel);

var camareira3 = new Camareira
{
    Nome = "Eugenia ferraz"
};
rh.ContratarCamareira(camareira3);

var recepcionista3 = new Recepcionista("Joice Lima", "12345678901", "021999885544");
rh.ContratarRecepcionista(recepcionista3);

var promoverCamareira = new Camareira
{
    Nome = "Eugenia Lima"
};
try
{
    rh.PromoverParaGerente(promoverCamareira);
}
catch (DocumentosInvalidosException ex)
{
    System.Console.WriteLine(ex.Message);
}

var promoverRecepcionista = new Recepcionista
{
    Nome = "Amanda Vasconcelos",
    CPF = "01234567887"
};

try
{
    rh.PromoverParaGerente(promoverRecepcionista);
}
catch (DocumentosInvalidosException ex)
{
    System.Console.WriteLine(ex.Message);
}

System.Console.WriteLine();