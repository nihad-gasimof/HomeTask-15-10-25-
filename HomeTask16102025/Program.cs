using System.Threading.Channels;

namespace HomeTask16102025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CutYoxlayan Call
            //Console.WriteLine("ededi daxil edin");
            //int x=Convert.ToInt32(Console.ReadLine());
            //bool cavab = CutYoxlayan(x);
            //Console.WriteLine(cavab);
            #endregion
            #region FtoC
            //Console.WriteLine("Dereceni daxil edin");
            //double F=Convert.ToDouble(Console.ReadLine());
            //double C = FtoC(F);
            //Console.WriteLine(C);
            #endregion
            #region Bolenler call
            //Console.WriteLine("Ededi daxil edin");
            //int x=Convert.ToInt32(Console.ReadLine());
            //int[] bolenler = Bolenler(x);
            //foreach (var item in bolenler)
            //{
            //    if (item!=0)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            #endregion
            #region Faktorial call
            //Console.WriteLine("Ededi daxil edin");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int factorial = Factorial(a);
            //Console.WriteLine(factorial);
            #endregion
            #region SadeYoxlanis call
            //Console.WriteLine("Ededi daxil edin");
            //int a = Convert.ToInt32(Console.ReadLine());
            //bool sade= SadeYoxlanis(a);
            //Console.WriteLine(sade);
            #endregion
            #region Avarage call
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //double result = Avarage(numbers);
            //Console.WriteLine(result);
            #endregion
            #region SAdeleriCap call
            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int[] sadeler = SadeleriCap(numbers);
            //foreach (var item in sadeler)
            //{
            //    if (item != 0)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            #endregion
            #region Calculator call
            //Console.WriteLine("1 ci ededi daxil edin");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2 ci ededi daxil edin");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Emeliyyati daxil edin (+,-,*,/)");
            //char c= Convert.ToChar(Console.ReadLine());
            //var result= Calculator(a, b, c);
            //Console.WriteLine(result);
            #endregion
        }

        public static bool CutYoxlayan(int x)
        {
            if (x % 2 == 0)
            {
                return true;
            }
            return false;
        }
        public static double FtoC(double F)
        {
            double C = (F - 32) * 5 / 9;
            return C;
        }
        public static int[] Bolenler(int x)
        {
            int[] bolenler = new int[x];
            int pointer = 0;
            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    bolenler[pointer] = i;
                    pointer++;
                }
            }
            return bolenler;
        }
        static int Factorial(int n)
        {
            if (n == 1) return 1;
            return n * Factorial(n - 1);
        }
        static bool SadeYoxlanis(int n)
        {
            if (n < 2)
            {
                return false;
            }
            for (int j = 2; j < n; j++)
            {
                if (n % j == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static double Avarage(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            double avg = sum / numbers.Length;
            return avg;
        }
        public static int[] SadeleriCap(int[] numbers)
        {
            int[] numbers2 = new int[numbers.Length];
            int num = 0;
            int sira = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                bool sade = true;

                num = numbers[i];
                if (num <= 2)
                {
                    sade = false;

                }
                for (int j = 2; j < num; j++)
                {

                    if (num % j == 0)
                    {
                        sade = false;

                    }
                }
                if (sade)
                {
                    numbers2[sira] = num;
                    sira++;

                }
            }
            return numbers2;
        }


        public static int Calculator(int a, int b, char c)
        {
            int netice = 0;
            switch (c)
            {
                case '+':
                    netice = a + b;
                    return netice;
                case '-':
                    netice = a - b;
                    return netice;
                case '*':
                    return netice = a * b;
                case '/':
                    if (b != 0) return netice = a / b;
                    else Console.WriteLine("0-a bolme olmaz");
                            return 0;



                default:
                    Console.WriteLine("Emeliyyati duzgun daxil edin");
                    break;
            }
            return netice;
        }
    }
}