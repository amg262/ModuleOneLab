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
             
             /*
             * return null just run and print
             */
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
            /*
             * return null just run and print
             */
            return null;
        }

        /*
         * Method for assignment that gets input for number of drinks had
         * Has preset values that will multiply based on input
         */
        public string AssignmentOne()
        {
         
         
            /*
             * preset values used for math
             */
            double cals = 110;
            double sugar = 27;
            double caff = 80;
            
            /*
             * Getting console input variable used in math
             */
            Console.WriteLine("Enter Number Monsters Drank:");
            string monsters = Console.ReadLine();

            /*
            * assigning variables and converting for math below
            */
            double monstersNum = Convert.ToInt32(monsters);


            /*
             * validating input and getting number based on input
             */
            double calories = monsters != "" ? monstersNum * 2 * cals : 0;
            double sugars = monsters != "" ? monstersNum * 2 * sugar : 0;
            double caffeine = monsters != "" ? monstersNum * 2 * caff : 0;
            
            /*
             * writing the output based on math equation
             */
            Console.WriteLine(calories);
            Console.WriteLine(sugars);
            Console.WriteLine(caffeine);

            /*
             * return null just run and print
             */
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
           // A.LabA();
            //A.LabB();
            A.AssignmentOne();
        }
    }
}