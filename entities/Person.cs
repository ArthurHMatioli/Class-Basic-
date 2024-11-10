namespace AMST5_Task19_Tarefa.entities
{
    public class Person     // Aq é onde eu crio os subs da minha classe, e coloco cada um como get e set para que eu tenha permissão de usar ele la no program.cs
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public Person() { }           // Construtor padrão      (Com ele crio objetos sem precisar impor valor sobre eles.)

        // Construtor com "Regras"    (Com ele posso definir valores especificos para cada objeto que eu criei.)
        public Person(string name, string gender, int age)  // Aq é onde eu separo os parametros do construtor das propriedades de classe. (No caso os parametros do construtor são os 
        {                                                   // que estão em letra minusculas e as propriedades de classe são aqueles que estão com letras maiusculas.)
                                                            
            Name = name;
            Gender = gender;
            Age = age;
        }

        public void Mostrar()       // Aq é onde eu preparo a mensagem que sera mostrada "Por isso o nome MOSTRAR", após eu receber as informações lá dos codigos do program.cs
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"De Acordo Com Os Documentos Obtidos Você Tem {Age} Anos");
            Console.WriteLine($"Seu Gênero é: {Gender}");
            Console.WriteLine($"E Seu Nome é: {Name}");
            Console.WriteLine("--------------------------------Seu Documento Foi Feito Com Sucesso--------------------------------");
            Console.WriteLine("Agradeço Por Usar E Desfrutar Do Código Feito Por Arthur Henrique Matioli Do 1ºAMS");
        }
    }
}