using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
class Program
{
    static void Main(string[] args)
    {
        // Teste com Iphone
        Iphone iphone = new Iphone("1234567890", "iPhone 13", "012345678901234", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        // Teste com Nokia
        Nokia nokia = new Nokia("9876543210", "Nokia 3310", "987654321098765", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Snake II");

        Console.ReadLine();
    }
}