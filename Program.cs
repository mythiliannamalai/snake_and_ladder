class Gamer_S_L
{
    public int DICE_VALUE = 0;
    public int PLAYER_ONE = 0;
    public int RAN_CHECK = 0;
    public int PLAYER_ONE_DICE_ROLL_COUNT = 0;
    public int PLAYER_TWO = 0;
    public int PLAYER_TWO_DICE_ROLL_COUNT = 0;
    int U1 = 0;
    int U2 = 0;
    public void method1()
    {
        Console.WriteLine("welcome to snake and ladder game");
        if (PLAYER_ONE < 0 || PLAYER_TWO < 0)
        {
            Console.WriteLine("Restart the game...");
        }
        else
        {            
            while (PLAYER_ONE < 100 && PLAYER_TWO < 100)
            {               
                Random r1 = new Random();
                DICE_VALUE = r1.Next(1, 7);
                switch (DICE_VALUE)
                {
                    case 1:
                        if (U1 == U2)                        
                        {
                            Console.WriteLine(" \n Player 1 dice value - 1");
                            PLAYER_ONE = (PLAYER_ONE + 1);
                        }
                        else
                        {
                            Console.WriteLine(" \n Player 2 dice value - 1");
                            PLAYER_TWO = (PLAYER_TWO + 1);
                        }
                        break;
                    case 2:
                        if (U1 == U2)
                        {
                            Console.WriteLine(" \n Player 1 dice value - 2");
                            PLAYER_ONE = (PLAYER_ONE + 2);
                        }
                        else
                        {
                            Console.WriteLine(" \n Player 2 dice value - 2");
                            PLAYER_TWO = (PLAYER_TWO + 2);
                        }
                        break;
                    case 3:
                        if (U1 == U2)
                        {
                            Console.WriteLine(" \n Player 1 dice value - 3");
                            PLAYER_ONE = (PLAYER_ONE + 3);
                        }
                        else
                        {
                            Console.WriteLine(" \n Player 2 dice value - 3");
                            PLAYER_TWO = (PLAYER_TWO + 3);
                        }
                        break;
                    case 4:
                        if (U1 == U2)
                        {
                            Console.WriteLine(" \n Player 1 dice value -4");
                            PLAYER_ONE = (PLAYER_ONE + 4);
                        }
                        else
                        {
                            Console.WriteLine(" \n Player 2 dice value - 4");
                            PLAYER_TWO = (PLAYER_TWO + 4);
                        }
                        break;
                    case 5:
                        if (U1 == U2)
                        {
                            Console.WriteLine(" \n Player 1 dice value -5");
                            PLAYER_ONE = (PLAYER_ONE + 5);
                        }
                        else
                        {
                            Console.WriteLine(" \n Player 2 dice value - 5");
                            PLAYER_TWO = (PLAYER_TWO + 5);
                        }
                        break;
                    default:
                        if (U1 == U2)
                        {
                            Console.WriteLine(" \n Player 1 dice value - 6");
                            PLAYER_ONE = (PLAYER_ONE + 6);
                        }
                        else
                        {
                            Console.WriteLine(" \n Player 2 dice value - 6");
                            PLAYER_TWO = (PLAYER_TWO + 6);
                        }
                        break;
                }
                if (PLAYER_ONE > 100)
                {
                    PLAYER_ONE = (PLAYER_ONE - DICE_VALUE);
                }
                if (PLAYER_TWO > 100)
                {
                    PLAYER_TWO = (PLAYER_TWO - DICE_VALUE);
                }
                Random r2 = new Random();
                RAN_CHECK = r2.Next(0, 3);
                switch (RAN_CHECK)
                {
                    case 0:
                        if (U1 == U2)
                        {
                            PLAYER_ONE_DICE_ROLL_COUNT++;
                            Console.WriteLine(" NO PLAY ");
                            Console.WriteLine("PLAYER 1: " + PLAYER_ONE);
                            Console.WriteLine("dice roll count PLAYER 1 : " + PLAYER_ONE_DICE_ROLL_COUNT);
                            U1++;
                        }
                        else
                        {
                            PLAYER_TWO_DICE_ROLL_COUNT++;
                            Console.WriteLine(" NO PLAY ");
                            Console.WriteLine("PLAYER 2: " + PLAYER_TWO);
                            Console.WriteLine("dice roll count PLAYER 2 : " + PLAYER_TWO_DICE_ROLL_COUNT);
                            U2++;
                        }
                        break;
                    case 1:
                        if (U1 == U2)
                        {
                            PLAYER_ONE_DICE_ROLL_COUNT++;
                            Console.WriteLine(" LADDER");
                            Console.WriteLine("PLAYER 1: " + PLAYER_ONE);
                            Console.WriteLine("dice roll count PLAYER 1 : " + PLAYER_ONE_DICE_ROLL_COUNT);
                            Random r3 = new Random();
                            int SECOND_CHANCE = r3.Next(1, 7);
                            PLAYER_ONE = (PLAYER_ONE + SECOND_CHANCE);
                            if (PLAYER_ONE > 100)
                            {
                                PLAYER_ONE = (PLAYER_ONE - DICE_VALUE);
                            }                            
                            PLAYER_ONE_DICE_ROLL_COUNT++;
                            Console.WriteLine("second chance value PLAYER 1 : " + PLAYER_ONE);
                            Console.WriteLine("dice roll count PLAYER 1 : " + PLAYER_ONE_DICE_ROLL_COUNT);
                            U1++;                            
                        }
                        else
                        {
                            PLAYER_TWO_DICE_ROLL_COUNT++;
                            Console.WriteLine(" LADDER");
                            Console.WriteLine("PLAYER 2: " + PLAYER_TWO);
                            Console.WriteLine("dice roll count PLAYER 2 : " + PLAYER_TWO_DICE_ROLL_COUNT);
                            Random r3 = new Random();
                            int SECOND_CHANCE = r3.Next(1, 7);
                            PLAYER_TWO = (PLAYER_TWO + SECOND_CHANCE);                            
                            if (PLAYER_TWO > 100)
                            {
                                PLAYER_TWO = (PLAYER_TWO - SECOND_CHANCE);
                            }
                            PLAYER_TWO_DICE_ROLL_COUNT++;
                            Console.WriteLine("second chance value PLAYER 2 : " + PLAYER_TWO);
                            Console.WriteLine("dice roll count PLAYER 2 : " + PLAYER_TWO_DICE_ROLL_COUNT);
                            U2++;
                        }
                        break;
                    default:
                        if (U1 == U2)
                        {
                            PLAYER_ONE_DICE_ROLL_COUNT++;
                            Console.WriteLine(" SNAKE");
                            Console.WriteLine("PLAYER 1: " + PLAYER_ONE);
                            Console.WriteLine("dice roll count PLAYER 2 : " + PLAYER_ONE_DICE_ROLL_COUNT);
                            U1++;
                        }
                        else
                        {
                            PLAYER_TWO_DICE_ROLL_COUNT++;
                            Console.WriteLine(" SNAKE");
                            Console.WriteLine("PLAYER 2 : " + PLAYER_TWO);
                            Console.WriteLine("dice roll count PLAYER 2 : " + PLAYER_TWO_DICE_ROLL_COUNT);
                            U2++;
                        }
                        break;
                }
            }
        }
        if(PLAYER_ONE==100)
        {
            Console.WriteLine(" \n \n *****PLAYER 1 WIN*****");
        }
        else
        {
            Console.WriteLine(" \n \n *****PLAYER 2 WIN*****");
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