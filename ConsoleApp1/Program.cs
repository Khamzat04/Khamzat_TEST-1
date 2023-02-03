using System;


namespace Test_Khamzat
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namn = new string[5];
            {
                Console.WriteLine("skriv ner 5 namn");

                namn[0] = Console.ReadLine();
                namn[1] = Console.ReadLine();
                namn[2] = Console.ReadLine();
                namn[3] = Console.ReadLine();
                namn[4] = Console.ReadLine();

                Console.WriteLine(" här är alla 5 namn du skrev " + namn[0] + namn[1] + namn[2] + namn[3] + namn[4]);



                int[] ålder = new int[5];
                Console.WriteLine("nu kan du skriva ner deras årder från första personen");

                ålder[0] = int.Parse(Console.ReadLine());
                ålder[1] = int.Parse(Console.ReadLine());
                ålder[2] = int.Parse(Console.ReadLine());
                ålder[3] = int.Parse(Console.ReadLine());
                ålder[4] = int.Parse(Console.ReadLine());

                int sum = ålder[0] + ålder[1] + ålder[2] + ålder[3] + ålder[4];

                Console.WriteLine("här är medel värdet på deras ålder" + sum / 5);

            }













        }
    }
}
