namespace aula04;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("-----------Login-----------");

        // solicitar o nome do usuario

        Console.WriteLine("Digite seu nome: ");

        string? name = Console.ReadLine();
        Console.WriteLine("Nome do usuario: " + name);
    }
}