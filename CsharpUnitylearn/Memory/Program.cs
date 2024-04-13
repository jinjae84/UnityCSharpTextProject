namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = 10;

            SomeFunction(value);
            Console.WriteLine(value);

            Memory myMemory = new Memory();
            myMemory.SomeFunction(value);

            Console.WriteLine("myMemory의 value" + myMemory.value);
        }

            static void SomeFunction(int value)
            {
                value = 100;

            Console.WriteLine();
        }
        


        }
    }
}


    