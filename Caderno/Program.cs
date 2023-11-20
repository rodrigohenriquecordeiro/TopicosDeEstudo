internal class Program
{
    private static void Main(string[] args)
    {
        Dudu();

        //Rodrigo();

        Console.ReadLine();
    }

    static void Dudu()
    {
        string nome = "";

        Console.Write("Digite um nome: ");
        nome = Console.ReadLine();

        if (nome == "Dudu")
        {
            Console.WriteLine("Acesso liberado!");
        }
        else
        {
            Console.WriteLine("Acesso negado");
        }
    }

    static void Rodrigo()
    {
        Console.Write("Digite um nome: "); 
        Console.Write(string.Equals(Console.ReadLine(), "Rodrigo") ? "Acesso liberado" : "Acesso negado!");
    }
}