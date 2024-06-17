namespace UnJeuVidéo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character character1 = new Character();
            Character character2 = new Character();
            int attaquant = 0;
            bool isAlive = true;

            //User Input

            Console.WriteLine("Enter the name for character 1 : ");
            character1.nom = Console.ReadLine();
            Console.WriteLine("Enter the defense force for character 2 : ");
            character2.nom = Console.ReadLine();

            Console.WriteLine("Enter the Life points for both the characters : ");
            int.TryParse(Console.ReadLine(), out character1.pointsDeVie);
            character2.pointsDeVie = character1.pointsDeVie;

            Console.WriteLine("Enter the attack force for " + character1.nom + " : ");
            int.TryParse(Console.ReadLine(), out character1.forceDAttaque);
            Console.WriteLine("Enter the defense force for " + character1.nom + " : ");
            int.TryParse(Console.ReadLine(), out character1.forceDeDéfense);

            Console.WriteLine("Enter the attack force for " + character2.nom + " : ");
            int.TryParse(Console.ReadLine(), out character2.forceDAttaque);
            Console.WriteLine("Enter the defense force for " + character2.nom + " : ");
            int.TryParse(Console.ReadLine(), out character2.forceDeDéfense);

            //Game begins
            while (true)
            {
                Console.WriteLine("Enter 1 for " + character1.nom + " to attack or enter 2 for " + character2.nom + " to attack.");
                int.TryParse(Console.ReadLine(), out attaquant);
                if (attaquant == 1) //Character 1 attacks
                {
                    character2.Attack(character1);
                    isAlive = character2.IsAlive();

                    if (isAlive == false)
                    {
                        Console.WriteLine("GAME END! " + character2.nom + " is dead. And, " + character1.nom + " WINS!!!");
                        break;
                    }
                }
                else if (attaquant == 2)
                {
                    //character 2 attacks
                    character1.Attack(character2);
                    isAlive = character1.IsAlive();

                    if (isAlive == false)
                    {
                        Console.WriteLine("GAME END! " + character1.nom + " is dead. And, " + character2.nom + " WINS!!!");
                        break;
                    }
                }  
                else
                {
                    Console.WriteLine("Please enter valid option.");  
                }
            }
        }
    }
}
