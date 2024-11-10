using AMST5_Task19_Tarefa.entities;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();          //Aq eu uso o construtor padrão la do person.cs

        Console.Write("Insira Sua Idade: ");                // Aq começa as perguntas que vão proporcionar as informações do "MOSTRAR" lá do Person.cs
        person.Age = int.Parse(Console.ReadLine());

        Console.Write("Insira Seu Gênero: ");
        person.Gender = Console.ReadLine();

        Console.Write("Insira Seu Nome: ");
        person.Name = Console.ReadLine();
 
        person.Mostrar();     // Aq já exibe o "MOSTRAR"
    }
}