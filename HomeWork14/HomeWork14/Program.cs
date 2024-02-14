namespace Lesson14 
{
    public class ClassOne 
    {
        public delegate void ShowDelegate(bool valsue);

        public ShowDelegate Show;

        public int Multilpy(int a, int b)
        {
            return a * b;
        }
    }

    public class ClassTwo
    {
        private int result;

        public Func<int, bool> Calc(Func<int, int, int> multiply, int num1, int num2)
        {
            result = multiply(num1, num2);

            return Result;
        }

        public bool Result(int num)
        {
            
            return result % num == 0;
        }
    }

    public class Program
    {
        
        public static void Show(bool value)
        {
            Console.WriteLine($"Number is divisible without remainder: {value}");
        }

        static void Main(string[] args)
        {
           
            ClassOne class1 = new ClassOne();
            ClassTwo class2 = new ClassTwo();

            Func<int, bool> resultDelegate = class2.Calc(class1.Multilpy, 145, 2);

            class1.Show = Show;

            class1.Show += delegate (bool value)
            {
                Console.WriteLine($"Result anonymous method: {value}");
            };

            class1.Show(resultDelegate(2));
        }
    }
}
