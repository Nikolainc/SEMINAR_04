class Program
{
    static void Main(string[] args)
    {
        #region Задача 25
        //Задача 25: Напишите цикл, который принимает на вход два числа(A и B) и возводит число A в натуральную степень B.
        //3, 5-> 243(3⁵)
        //2, 4-> 16

        //int A;
        //int B;
        //Console.Write("Введите число А: ");
        //int.TryParse(Console.ReadLine(), out A);
        //Console.Write("Введите число В: ");
        //int.TryParse(Console.ReadLine(), out B);

        //Console.WriteLine($"{A} в степени {B} = {DegreeNumber(A,B)}");

        #endregion

        #region Задача 27
        //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
        //452-> 11
        //82-> 10
        //9012-> 12

        //int number;
        //int.TryParse(Console.ReadLine(), out number);

        //Console.WriteLine(SumOfNumbers(number));

        #endregion

        #region Задача 29
        //Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
        //1, 2, 5, 7, 19-> [1, 2, 5, 7, 19]
        //6, 1, 33-> [6, 1, 33]
        //int[] array = NewArray(8);
        //Console.WriteLine($"[{String.Join(", " , array)}]");

        #endregion

    }

    #region Задача 25

    static int DegreeNumber(int number, int degree)
    {
        return (int)Math.Pow(number, degree);
    }

    #endregion

    #region Задача 27

    static int SumOfNumbers(int number)
    {
        int sum = 0;

        while (number > 9)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum + number;
    }

    #endregion

    #region Задача 29

    static int[] NewArray(int range = 8)
    {
        int[] array = new int[range];
        Random rand = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(0, 100);
        }
        return array;
    }

    #endregion
}