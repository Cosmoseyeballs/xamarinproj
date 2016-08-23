using System;
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
            Expression expr = new PlusExpression(new NegateExpression(new ConstantExpression(4)),
                4.0.ToExpression());
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



            Console.WriteLine("----------------------");


            var b = new Bird("Argentavis", 2, 2, 13);
            Console.WriteLine(b);



            Console.WriteLine("-----------  delegate filter -----------");

            var animals = new List<Animal>()
            {
                new Animal("Hund", AnimalType.Mammal,4,2),
                new Animal("Laks", AnimalType.Fish,0,2),
                new Animal("Flue", AnimalType.Insect,6,8000),
                new Animal("Tudse", AnimalType.Amphibians,4,2)
            };

            var aa = animals.FilterOut(a => a.Eye > 2);

            foreach (var animal in aa)
            {
                Console.WriteLine(animal.Name);
            }


            Console.ReadKey();
        }
    }
}
