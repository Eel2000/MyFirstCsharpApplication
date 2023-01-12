namespace MyFirstCsharpApplication
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int numberA = 0, numberB = 0;
            string userTyppedValue = "";
            int resultc;
            string msg;
            bool operation;

            Console.WriteLine("Welcome fun to my application");
            Console.WriteLine("Please enter values for calculation");

            Console.WriteLine("Please enter value A");

            userTyppedValue = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(userTyppedValue))
            {
                Console.WriteLine("must enter a value in integer");
                userTyppedValue = Console.ReadLine();
            }

            numberA = int.Parse(userTyppedValue);

            Console.WriteLine("Please enter value B");
            userTyppedValue = "";

            while (string.IsNullOrWhiteSpace(userTyppedValue))
            {
                Console.WriteLine("must enter a value in integer");
                userTyppedValue = Console.ReadLine();
            }


            while(!int.TryParse(userTyppedValue, out resultc))
            {
                //print something here
            }

            int result = SumTwoNumber(numberA, numberB);

            int resultb = 0;
            bool response = TrySumTwoNumbersWithReference(numberA, numberB, ref resultb);

            (resultc, msg, operation) = ReturnManyValue(numberA, numberB);

            string message = $"Result non-referneced value : {result} \n with reference : {resultb}";

            Console.WriteLine(message);
            if (operation)
            {
                resultb = resultc;
                Console.WriteLine(msg);
            }
            else
            {
                Console.WriteLine(msg);
            }
            Console.ReadLine();

            //visibility returnDataType nameOfTheProc(parms)
        }

        static int SumTwoNumber(int a, int b)
        {
            return a + b;
        }

        static bool TrySumTwoNumbersWithReference(int a, int b, ref int c)
        {
            c = a + b;
            if (c == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static bool TrySumTwoNumbersWithReference1(int a, int b, out int c)
        {
            c = a + b;
            if (c == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static (int result, string message, bool c) ReturnManyValue(int a, int b)
        {
            int calculationResult = a + b;

            bool isCalcationSucceed = true;
            if (calculationResult <= 0)
            {
                isCalcationSucceed = false;
            }

            if (isCalcationSucceed)
            {
                return (calculationResult, $"result = {calculationResult}", isCalcationSucceed);
            }
            else
            {
                return (calculationResult, $"unable to process...", isCalcationSucceed);
            }
        }
    }
}