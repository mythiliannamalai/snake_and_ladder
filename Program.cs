class Gamer_S_L
{
    public int DICE_VALUE = 0;
    public int PLAYER_ONE = 0;
    public int RAN_CHECK = 0;
    public int DICE_ROLL_COUNT = 0;
    

    public void method1()
    {
        Console.WriteLine("welcome to snake and ladder game");
        if (PLAYER_ONE < 0)
        {
            Console.WriteLine("Restart the game...");
        }

        while (PLAYER_ONE < 100)
        {
            Random r1 = new Random();
            DICE_VALUE = r1.Next(1, 7);
            switch (DICE_VALUE)
            {
                case 1:
                    Console.WriteLine(" \n dice value - 1");
                    PLAYER_ONE = (PLAYER_ONE + 1);
                    break;
                case 2:
                    Console.WriteLine(" \n dice value - 2");
                    PLAYER_ONE = (PLAYER_ONE + 2);
                    break;
                case 3:
                    Console.WriteLine("\n  dice value - 3");
                    PLAYER_ONE = (PLAYER_ONE + 3);
                    break;
                case 4:
                    Console.WriteLine("\n dice value -4");
                    PLAYER_ONE = (PLAYER_ONE + 4);
                    break;
                case 5:
                    Console.WriteLine("\n dice value -5");
                    PLAYER_ONE = (PLAYER_ONE + 5);
                    break;
                default:
                    Console.WriteLine("\n dice value - 6");
                    PLAYER_ONE = (PLAYER_ONE + 6);
                    break;
            }
            DICE_ROLL_COUNT++;
                Random r2 = new Random();
                RAN_CHECK = r2.Next(0, 3);
                switch (RAN_CHECK)
                {
                    case 0:
                        Console.WriteLine(" NO PLAY ");

                        break;
                    case 1:
                        Console.WriteLine(" LADDER");
                        break;
                    default:
                        Console.WriteLine(" SNAKE");
                        break;
                }
            Console.WriteLine("Player 1: " + PLAYER_ONE);
            
        }
    }
   
}
class Final
{
    public static void Main(string[] args)
    {
        Gamer_S_L program_check = new Gamer_S_L();
        program_check.method1();

    }
}