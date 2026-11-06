using System;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate MathOperation1 class
            MathOperation1 mathOp = new MathOperation1();

            //Call method with two integers
            mathOp.MathOperation(5, 3);

            //Call method by specifying parameters by name
            mathOp.MathOperation(i: 4, j: 2);

            Console.ReadLine();
        }
    }
}
