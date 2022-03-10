class Gamer_S_L
{
    public int DICE_VALUE = 0;
    public int PLAYER_ONE = 0;
    public void method1()
    {
        Console.WriteLine("welcome to snake and ladder game");
        Random r1 = new Random();
        DICE_VALUE = r1.Next(1, 7);
        switch (DICE_VALUE)
        {
            case 1:
                Console.WriteLine(" \n dice value - 1");
                break;
            case 2:
                Console.WriteLine(" \n dice value - 2");
                break;
            case 3:
                Console.WriteLine("\n  dice value - 3");
                break;
            case 4:
                Console.WriteLine("\n dice value -4");
                break;
            case 5:
                Console.WriteLine("\n dice value -5");
                break;
            default:
                Console.WriteLine("\n dice value - 6");
                break;
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