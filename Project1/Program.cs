using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            var len = 100;
            Turtle.Speed = 9;

            //рисуем тело домика
            Turtle.Turn(90);
            Square(len);

            //Рисуем кришу
            Turtle.Turn(-60);
            Turtle.Move(len);
            Turtle.Turn(120);
            Turtle.Move(len);
            Turtle.Turn(30);

            //рисуем окошко
            Turtle.PenUp();
            Turtle.Move(2 * len / 3);
            Turtle.Turn(90);
            Turtle.Move(len / 3);
            Turtle.PenDown();
            Square(len / 3);



        }

        static void Square(int len)
        {
            Turtle.Move(len);
            Turtle.Turn(90);
            Turtle.Move(len);
            Turtle.Turn(90);
            Turtle.Move(len);
            Turtle.Turn(90);
            Turtle.Move(len);
            Turtle.Turn(90);
        }
    }
}
