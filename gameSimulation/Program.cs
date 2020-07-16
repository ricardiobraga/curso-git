using System;

namespace gameSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(1600, 900);

            Console.WriteLine("Criação do personagem: ");
            Console.WriteLine();
            Console.Write("Digite o Nome do personagem: ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Escolha uma classe para o personagem: ");
            Console.Write("Digite (1) para Ranger, (2) para Warrior ou (3) para Mago: ");
            int classC = int.Parse(Console.ReadLine());

            Player p1 = new Player(name);

            p1.LifeCalc();
            p1.PClass(classC);

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(p1);
            Console.WriteLine();

        }
    }
}
