using System;

namespace Module1Lab
{
    class Program
    {


        public string LabB()
        {

            double cupcakes = 8;
            double eggs = 4 / cupcakes;
            double sugar = 1 / cupcakes;
            double cheese = 3 / cupcakes;
            double vanilla = 1 / cupcakes;
            
            
            
            Console.WriteLine("Enter Number Cupcakes:");
            string numCupcakes = Console.ReadLine();
            double numCakes = Convert.ToDouble(numCupcakes);


            double n0 = numCakes * 1 / 2;
            double n1 = numCakes * 1 /  8;
            double n2 = numCakes * 3 / 8;
            double n4 = numCakes * 1 / 8;
            double numEggs = numCupcakes != null ?  numCakes * (eggs / numCakes) : numCakes = 0;
            double numSugar = numCupcakes != null ?  numCakes * (sugar / numCakes) : numCakes = 0;
            double numCheese = numCupcakes != null ?  numCakes * (cheese / numCakes) : numCakes = 0;
            double numVanilla = numCupcakes != null ?  numCakes * (vanilla / numCakes) : numCakes = 0;

   
            // Console.WriteLine(numEggs );
            // Console.WriteLine(numSugar);
            // Console.WriteLine(numCheese);
            // Console.WriteLine(numVanilla);
            
            Console.WriteLine(n0 );
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n4);
            return null;
        }
        public string LabA()
        {
            // Type your username and press enter
            
            
            Console.WriteLine("Enter Number 1:");
            string numOne = Console.ReadLine();
            Console.WriteLine("Enter Number 2:");
            string numTwo = Console.ReadLine();

            int numOneInt = Convert.ToInt32(numOne);
            int numTwoInt = Convert.ToInt32(numTwo);

            Console.WriteLine(numOneInt + numTwoInt);
            Console.WriteLine(numOneInt - numTwoInt);
            Console.WriteLine(numOneInt * numTwoInt);
            
            
            
            
            
            
   
            return null;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Program A = new Program();
            //A.LabA();
            A.LabB();
        }
    }
}