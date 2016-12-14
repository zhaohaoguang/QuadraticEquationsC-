﻿//name: bobby carver
//date: 11/11/2014
//file:quadEQ.CS


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace QuadraticEquations
{

    class quadEQ
    {
       


        static void Main(string[] args)
        {
            double a; // first input
            double b; //second input 
            double c; // third input 
            double x1 = 0.0; // root 1 
            double x2 = 0.0; // root 2 
            double x = 0.0;



            //introduction


            Console.WriteLine(" this is a quadtratic equasion solver, used to solve equasions. ");
            Console.WriteLine("\nPlease chose a value for A. only numeric values allowed.");
                a = double.Parse(Console.ReadLine());
            Console.WriteLine("\nPlease chose a value for B. only numeric values allowed.");
                b = double.Parse(Console.ReadLine());
            Console.WriteLine("\nPlease chose a value for C. only numeric values allowed.");
                c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("error no solution possible both A and B are 0");
                }
                else
                {
                    x = -c / b;
                }

            }
            else if (b * b == 4 * a * c)
            {
                x = -b / (2 * a);
            }
            else if (b * b > 4 * a * c)
            {
                //calc first real root

                x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);

                //calc second real root

                x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
                Console.WriteLine(" the first root of the quadratic equasion is {0}", x1);
                Console.WriteLine(" the Second  root of the quadratic equasion is{0}", x2);
                Console.ReadLine();
            }
            else
            {
                //imaginary roots
                Console.WriteLine(" this is an imaginary root.");
                Console.ReadLine();
            }
            
           
        }
    }
}
