using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;

            int playerPoints = 0;
            int enemyPoints = 0; 

            Random random = new Random(); 


            for (int i = 0; i < 10; i++)
            {
                
            Console.WriteLine("Press and key to roll the dice.");


                Console.ReadKey();
                playerRandomNum = random.Next(1, 10);
                Console.WriteLine("You rolled a " + playerRandomNum);

                Console.WriteLine(".....");
                System.Threading.Thread.Sleep(1000); 

                enemyRandomNum = random.Next(1, 10);
                Console.WriteLine("AI rolled a " + enemyRandomNum); 

                if (playerRandomNum < enemyRandomNum)
                {
                
                    playerPoints++;
                    Console.WriteLine("Player wins this round!");
                } 
                else if (enemyRandomNum > playerRandomNum)
                {
                    enemyPoints++;
                    Console.WriteLine("Enemy has won this round hahahahah!!!");

                }


            }
            Console.ReadKey(); 
        }
    }
}
