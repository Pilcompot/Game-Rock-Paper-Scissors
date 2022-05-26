using static Program.Program;

namespace Program
{
    class Program
    {
        public enum VARIANTS { ROCK, PAPER, SCISSORS }
        public class Player
        {
            public int count_Human;
            public int count_Bot;
            public string Human;
            public int Bot;
            public string result;
            public Player(string x, int y)
            {
                this.Human = x;
                this.Bot = y;
            }
            public static void Brosok(string Human, int Bot)
            {
                switch (Human)
                {
                    case "0": Console.WriteLine("Вы выбрали камень"); break;
                    case "1": Console.WriteLine("Вы выбрали ножницы"); break;
                    case "2": Console.WriteLine("Вы выбрали бумагу"); break;
                }
                switch (Bot)
                {
                    case 0: Console.WriteLine("Bot выбрал камень"); break;
                    case 1: Console.WriteLine("Bot выбрал ножницы"); break;
                    case 2: Console.WriteLine("Bot выбрал бумагу"); break;
                }
            }

            public void Compare(string Human, int Bot)
            {
                if ((Human == "0" && Bot == 1) || (Human == "1" && Bot == 2) || (Human == "2" && Bot == 0))
                {
                    count_Human++;
                    result = "Human";
                }
                else if ((Bot == 0 && Human == "1") || (Bot == 1 && Human == "2") || (Bot == 2 && Human == "0"))
                {
                    count_Bot++;
                    result = "Bot";
                }
                else
                {
                    result = "Ничья!";
                }
                Console.WriteLine("Победил игрок с именем: " + result);
            }
        }
    }

    class Game
    {
        static void Main(string[] args)
        {
            string vibor;
            Console.WriteLine("Добро пожаловать в игру Камень-Ножницы-Бумага");
            do
            {
                do
                {
                    Console.WriteLine("Сделайте выбор 0=Камень, 1=Ножницы, 2=Бумага, для выхода нажмите 3");
                    vibor = Console.ReadLine();
                } 
                while ((vibor != "0") && (vibor != "1") && (vibor != "2") && (vibor != "3"));
                Random random = new Random();
                int CPU = random.Next(3);
                Player pole = new Player(vibor, CPU);
                if (vibor != "3")
                {
                    Player.Brosok(vibor, CPU);
                    pole.Compare(vibor, CPU);
                }
            } while (vibor != "3");
        }
    }
}