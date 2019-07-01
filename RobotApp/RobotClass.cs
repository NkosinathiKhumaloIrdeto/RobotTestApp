using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace RobotApp
{
    class RobotClass
    {
        public static int x = 0;
        public static int y = 0;

        public static void Main(string[] arg) {

            string n, e, w, s;

            Console.WriteLine("Specify North (Numeric) : ");
            n = "N"+ Console.ReadLine().ToString();

            Console.WriteLine("Specify East (Numeric) : ");
            e = "E" + Console.ReadLine().ToString();

            Console.WriteLine("Specify West (Numeric) : ");
            w = "W" + Console.ReadLine().ToString();

            Console.WriteLine("Specify South (Numeric) : ");
            s = "S" + Console.ReadLine().ToString();

            Console.WriteLine(robot_movement(n, e, s, w));
        }

        public static int robot_movement(string N, string E, string W, string S)
        {

            string iMovement = "";
            ArrayList alist = new ArrayList();
            string[] numbers = { N, E, W, S };

            for (int i = 0; i < numbers.Length; i++)
            {
                addToList(numbers[i], alist, iMovement);
            }

            return alist.Count;
        }

        public static void addToList(string f_positions, ArrayList alist, string cpos)
        {

            string direction = f_positions.Substring(0, 1); //N;E;W;S
            string position = f_positions.Substring(1, 1); //1;2;3

            for (int i = 0; i < int.Parse(position); ++i)
            {

                switch (direction)
                {
                    case "N":
                        cpos = y.ToString(); //0.1f;
                        y++;
                        break;
                    case "S":
                        cpos = y.ToString();//0.1f;
                        y--;
                        break;
                    case "E":
                        cpos = x.ToString();//1.0f;
                        x++;
                        break;
                    case "W":
                        cpos = x.ToString(); //1.0f;
                        x--;
                        break;
                }

                if (!alist.Contains(x + ":" + y))
                {
                    alist.Add(x + ":" + y);
                }    

            }

        }
    }
}
