namespace Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GoldenRetriever goldenRetriever = new GoldenRetriever();
            Pastor_Aleman pastor_Aleman = new Pastor_Aleman();
            Chihuahua chihuahua = new Chihuahua();

            Console.WriteLine("Por favor elija una raza de perro:");
            Console.WriteLine("1. Golden Retriever\n2. Chihuahua\n3. Pastor Aleman\n");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine(goldenRetriever.comer());
                Console.WriteLine(goldenRetriever.jugar());
                Console.WriteLine(goldenRetriever.orinar());
                Console.WriteLine(goldenRetriever.defecar());
                Console.WriteLine(goldenRetriever.dormir());
            }
            else if (input == "2")
            {
                Console.WriteLine(pastor_Aleman.comer());
                Console.WriteLine(pastor_Aleman.jugar());
                Console.WriteLine(pastor_Aleman.orinar());
                Console.WriteLine(pastor_Aleman.defecar());
                Console.WriteLine(pastor_Aleman.dormir());
            }
            else if (input == "3")
            {
                Console.WriteLine(chihuahua.comer());
                Console.WriteLine(chihuahua.jugar());
                Console.WriteLine(chihuahua.orinar());
                Console.WriteLine(chihuahua.defecar());
                Console.WriteLine(chihuahua.dormir());
            }
            else
            {
                Console.WriteLine("Esta opcion no es valida.");
            }
        }
    }
}