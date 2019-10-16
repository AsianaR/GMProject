using System;

namespace FirstGame
{
    class Program
    {

        static readonly int Height = 10;
        static readonly int Width = 10;
        public static char charter = '@';
        public static char wall = '#';
        public static char empty = ' ';
        public static char door = '|';
        public static char finish = 'F';
        public static int xf, yf, yc, xc;
        static char [,] field = new char[Height, Width];
       

        static void Main(string[] args)
        {
            Console.WriteLine("Press ENTER to play...");
            Generate();
                Input();
            while (EndGame()==false)
            {
                Input();
                Refresh();
            }

            
        }


        static void Generate()
        {
            int random, res;
            
            for (int i=0; i<Width; i++)
            {
                for(int j=0; j<Height; j++)
                {
                    random = ClassLibrary.Rnd.RandAtoB(1, 15);
                    res = (random % 2 == 0 ? field[i, j] = wall : field[i, j] = empty);
                }            
            }
            xf = ClassLibrary.Rnd.RandAtoB(0, Width);
            yf = ClassLibrary.Rnd.RandAtoB(0, Height);
            field[xf, yf] = finish;

            xc = ClassLibrary.Rnd.RandAtoB(0, Width);
            yc = ClassLibrary.Rnd.RandAtoB(0, Height);
            field[xc, yc] = charter;
        }


        static void Input()
        {       
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.W:
                    if (field[xc - 1, yc] != wall && xc < Width && yc < Height && xc >= 0 && yc - 1 >= 0)
                    {
                        field[xc , yc] = empty;
                        field[xc - 1, yc] = charter;
                        xc -= 1;
                    }
                    break;
                case ConsoleKey.A:
                    if (field[xc, yc - 1] != wall && xc < Width && yc < Height && xc>=0 && yc - 1 >= 0)
                    {
                        field[xc, yc] = empty;
                        field[xc, yc - 1] = charter;
                        yc -=1;
                    }
                    break;
                case ConsoleKey.S:
                    if (field[xc + 1, yc ] != wall && xc < Width && yc < Height && xc >= 0 && yc - 1 >= 0)
                    {
                        field[xc, yc] = empty;
                        field[xc + 1, yc ] = charter;
                        xc += 1;
                    }
                    break;
                case ConsoleKey.D:
                    if (field[xc, yc + 1] != wall && xc < Width && yc < Height && xc >= 0 && yc - 1 >= 0)
                    {
                        field[xc, yc] = empty;
                        field[xc, yc + 1] = charter;
                        yc += 1;
                    }
                    break;
            }
        }

        static void Refresh()
        {

            Console.Clear();
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Console.Write(field[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static bool EndGame()
        {
            if (field[xf, yf] == field[xc,yc])
            {
                return true;
            }
            return false;
        }
    }
}
