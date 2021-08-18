using System;

namespace Module1Lab
{
    
    /*
     * Class that contains the needed methods in addition to the main
     * method running on console running. Contains 2 methods for Lab A
     * and Lab B that get user parameters, convert them to correct data type
     * used for math used below that methods calculate.
     */
    class Program
    {


        /*
         * LabB runs math on a recipe based on input number that
         * will dictate how the ratios will be by have pre-made ratios
         *
         * @return null
         */
        public string LabB()
        {

            /*
            * assigning variables
            */
            double cupcakes = 8;
            double eggs = 4 / cupcakes;
            double sugar = 1 / cupcakes;
            double cheese = 3 / cupcakes;
            double vanilla = 1 / cupcakes;
            
            
            /*
             * get console input and convert to double for math
             */
            Console.WriteLine("Enter Number Cupcakes:");
            string numCupcakes = Console.ReadLine();
            double numCakes = Convert.ToDouble(numCupcakes);

            

            /*
             * assigning variables and validating input
             */
            double n0 = numCakes * 1 / 2;
            double n1 = numCakes * 1 /  8;
            double n2 = numCakes * 3 / 8;
            double n4 = numCakes * 1 / 8;
            double numEggs = numCupcakes != null ?  numCakes * 1 / 2 : numCakes = 0;
            double numSugar = numCupcakes != null ?  numCakes * 1 / 8 : numCakes = 0;
            double numCheese = numCupcakes != null ?  numCakes * 3 / 8 : numCakes = 0;
            double numVanilla = numCupcakes != null ?  numCakes * 1 / 8 : numCakes = 0;

   
            /*
             * output the variables assigned from ratio math
             */
             Console.WriteLine(numEggs );
             Console.WriteLine(numSugar);
             Console.WriteLine(numCheese);
             Console.WriteLine(numVanilla);
            
            // Console.WriteLine(n0 );
            // Console.WriteLine(n1);
            // Console.WriteLine(n2);
            // Console.WriteLine(n4);
            return null;
        }
        
        /*
         * Lab A runs the math done on the input values
         * Takes 2 input numbers and finds product, sum, diff
         *
         * @return null
         */
        public string LabA()
        {
         
            /*
             * Getting console input of 2 variables used below
             */
            Console.WriteLine("Enter Number 1:");
            string numOne = Console.ReadLine();
            Console.WriteLine("Enter Number 2:");
            string numTwo = Console.ReadLine();

            /*
            * assigning variables and converting for math below
            */
            int numOneInt = Convert.ToInt32(numOne);
            int numTwoInt = Convert.ToInt32(numTwo);

            /*
            * validating input and writeing the math output
            */
            if ((numOne != null) && numTwo != null)
            {
                Console.WriteLine(numOneInt + numTwoInt);
                Console.WriteLine(numOneInt - numTwoInt);
                Console.WriteLine(numOneInt * numTwoInt);
            }
            
            return null;
        }
        
        /*
         * main console method that instantiates a new Program class
         * and runs LabA and LabB methods that will use console.writeline
         * to output the labs required parameters and functions.
         */
        static void Main(string[] args)
        {
            /*
             * create new class and run both methods
             */
            Program A = new Program();
            A.LabA();
            A.LabB();
        }
    }
}