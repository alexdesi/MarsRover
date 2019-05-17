using System;
using System.Collections;
using System.Collections.Generic;

namespace Rover
{
    public class Rover
    {
        public Rover(int _x, int _y, char _direction)
        {
            Console.WriteLine(_x);
            Console.WriteLine(_y);
            Console.WriteLine(_direction);
            
            x = _x;
            y = _y;
            direction = _direction;
        }

        public int x { get; set; }
        public int y { get; set; }
        public char direction { get; }

        public IEnumerable<int> Position()
        {
            return new int[]
            {
                x,
                y
            };
        }
   
        public void execute(char command)
        {
            Console.WriteLine(">>>");
            Console.WriteLine(command);
            int incX = command == 'F' ? 1 : -1;

            switch (direction)
            {
            case 'E':
                x+= incX;
                break;
            case 'W':
                x-= incX;
                break;
            case 'N':
                y = command == 'F' ? y + 1 : y - 1;
                break;
            case 'S':
                break;                                
            }
        }
    }
}