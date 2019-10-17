using System;

namespace XZ_Game
{
    class Program
    {

        static int height = 3;
        static int width = 3;
        static int x1, y1, x2, y2;
        public static char player1 = 'x';
        public static char player2 = '0';
        static char empty = ' ';
        static char[,] field = new char[height, width];

        public static void Main(string[] args)
        {
                Generate();
            while(!IsWin1() && !IsWin2() && !NoWinner() )
            {

                Input();

                Refresh();

                

            }
            if (IsWin1()==true)
            {
                Console.WriteLine("First player WIN!");
            }
            if (IsWin2()==true)
            {
                Console.WriteLine("Second player WIN!");
            }
            if (NoWinner() == true)
            {
                Console.WriteLine("No WINNER");
            }
        }


        static void Generate()
        {
            for (int i = 0; i < height; i++)
            {

                for (int j = 0; j < width; j++)
                {
                    field[i, j] = empty;
                }
            }
        }

      

        static void Refresh()
        {
            Console.Clear();

            for (int i = 0; i < height; i++)
            {

                for (int j = 0; j < width; j++)
                {
                    Console.Write(field[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

            static void Input()
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Q:
                        if (field[0, 0] == empty)
                        {
                            field[0, 0] = player1;
                        }
                        break;
                    case ConsoleKey.W:
                        if (field[0, 1] == empty)
                        {
                            field[0, 1] = player1;
                        }
                        break;
                    case ConsoleKey.E:
                        if (field[0, 2] == empty)
                        {
                            field[0, 2] = player1;
                        }
                        break;
                    case ConsoleKey.A:
                        if (field[1, 0] == empty)
                        {
                            field[1, 0] = player1;
                        }
                        break;
                    case ConsoleKey.S:
                        if (field[1, 1] == empty)
                        {
                            field[1, 1] = player1;
                        }
                        break;
                    case ConsoleKey.D:
                        if (field[1, 2] == empty)
                        {
                            field[1, 2] = player1;
                        }
                        break;
                    case ConsoleKey.Z:
                        if (field[2, 0] == empty)
                        {
                            field[2, 0] = player1;
                        }
                        break;

                    case ConsoleKey.X:
                        if (field[2, 1] == empty)
                        {
                            field[2, 1] = player1;
                        }
                        break;
                    case ConsoleKey.C:
                        if (field[2, 2] == empty)
                        {
                            field[2, 2] = player1;
                        }
                        break;



                case ConsoleKey.U:
                    if (field[0, 0] == empty)
                    {
                        field[0, 0] = player2;
                    }
                    break;
                case ConsoleKey.I:
                    if (field[0, 1] == empty)
                    {
                        field[0, 1] = player2;
                    }
                    break;
                case ConsoleKey.O:
                    if (field[0, 2] == empty)
                    {
                        field[0, 2] = player2;
                    }
                    break;
                case ConsoleKey.H:
                    if (field[1, 0] == empty)
                    {
                        field[1, 0] = player2;
                    }
                    break;
                case ConsoleKey.J:
                    if (field[1, 1] == empty)
                    {
                        field[1, 1] = player2;
                    }
                    break;
                case ConsoleKey.K:
                    if (field[1, 2] == empty)
                    {
                        field[1, 2] = player2;
                    }
                    break;
                case ConsoleKey.B:
                    if (field[2, 0] == empty)
                    {
                        field[2, 0] = player2;
                    }
                    break;

                case ConsoleKey.N:
                    if (field[2, 1] == empty)
                    {
                        field[2, 1] = player2;
                    }
                    break;
                case ConsoleKey.M:
                    if (field[2, 2] == empty)
                    {
                        field[2, 2] = player2;
                    }
                    break;
            
                }       
            }


            static bool IsWin1()
            {
                char[] res = new char[3];
                for (int i = 0; i < 3; i++)
                {

                    for (int j = 0; j < 3; j++)
                    {
                        res[j]= field[i, j];
                    }
                    if (res[0] == player1 && res[1] == player1 && res[2] == player1)
                    {
                        return true;
                    }
                }
                for (int i = 0; i < 3; i++)
                {

                    for (int j = 0; j < 3; j++)
                    {
                        res[j]= field[j, i];
                     }
                    if (res[0] == player1 && res[1] == player1 && res[2] == player1)
                    {
                        return true;
                    }
                }
                if (field[0,0]== player1 && field[1,1]== player1 && field[2,2]== player1 || field[0,2]== player1 && field[1,1]== player1 && field[2,0]== player1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

           static bool IsWin2()
           {
                char[] res = new char[3];
                for (int i = 0; i < 3; i++)
                {

                    for (int j = 0; j < 3; j++)
                    {
                        res[j]= field[i, j];
                     }
                    if (res[0] == player2 && res[1] == player2 && res[2] == player2)
                    {
                        return true;
                    }
                }
                for (int i = 0; i < 3; i++)
                {

                    for (int j = 0; j < 3; j++)
                    {
                        res[j]= field[j, i];
                     }
                    if (res[0] == player2 && res[1] == player2 && res[2] == player2)
                    {
                        return true;
                    }
                }
            if (field[0, 0] == player2 && field[1, 1] == player2 && field[2, 2] == player2 || field[0, 2] == player2 && field[1, 1] == player2 && field[2, 0] == player2)
            {
                return true;
            }
                else
                {
                    return false;
                }

           }



        static bool NoWinner()
        {
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (field[i, j] != empty)
                    {
                        count += 1;
                    }
                }
            }
                if(count==9)
                {
                    return true;
                }
                else
                {
                    return false;
                }  
        }
        
    }
}
