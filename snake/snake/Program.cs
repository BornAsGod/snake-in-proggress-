using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    struct Position 
    {
        public int X;
        public int Y;
        public Position(int x,int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
      
    class Program
    {
        static void Main(string[] args)
        {
            Position[] directions = new Position[]
            {
                new Position(0,1),
                new Position(0,-1),
                new Position(1,0),
                new Position(-1,0),
            };
            int direction = 0;
            Queue<Position>Elements=new  Queue<Position>();

            for (int i = 0; i < 5; i++)
            {
                Elements.Enqueue(new Position(0, i));
            }

            foreach (var Position in Elements)
            {
                Console.SetCursorPosition(Position.Y, Position.X);
                Console.WriteLine("0");
            }
            
            while (true)
            {
                ConsoleKeyInfo userInput = Console.ReadKey();
                if (userInput.Key==ConsoleKey.LeftArrow)
                {
                    direction = 1;
                }
                if (userInput.Key == ConsoleKey.RightArrow)
                {
                    direction = 0;
                }
                if (userInput.Key == ConsoleKey.UpArrow)
                {
                    direction = 3;
                }
                if (userInput.Key == ConsoleKey.DownArrow)
                {
                    direction = 2;
                }


                
                Position head = Elements.Last();
                Elements.Dequeue();
                Position newDirection=directions[direction];
                Position newHead = new Position(head.X + newDirection.X,head.Y+newDirection.Y);
                Elements.Enqueue(newHead);
                Console.Clear();

                foreach (var Position in Elements)
                {
                    Console.SetCursorPosition(Position.Y, Position.X);
                    Console.WriteLine("0");
                }
            }
        }
    }
}
