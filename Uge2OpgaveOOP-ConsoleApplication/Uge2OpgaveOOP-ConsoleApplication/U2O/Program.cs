﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2O
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create your expression here
            Expression expr = new PlusExpression (new NegateExpression(new ConstantExpression(4)), 
                new ConstantExpression(8));
            // Example:
            //Expression expr = new PlusExpression(
            //    new ConstantExpression(4),
            //    new MultiplyExpression(
            //        new ConstantExpression(1),
            //        new ConstantExpression(2)));    

            // We print the textual representation
            Console.Write(expr.ToString());

            Console.Write(" = ");

            // ... and then the result of evaluating
            Console.WriteLine(expr.Evaluate());

            Console.ReadKey();


        }
    }
}
