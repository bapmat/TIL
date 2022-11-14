using System;

public class Program
{
    public static void Main()
    {
        // 입력한 값
        int inputText1 = int.Parse(Console.ReadLine());
        int inputText2 = int.Parse(Console.ReadLine());

        int positional_100 = (inputText2 / 100);           // 100의 자리수
        int positional_10 = (inputText2 % 100) / 10;     // 10의 자리수  
        int positional_1 = (inputText2 % 10);              // 1의 자리수  

        int calc_1 = inputText1 * positional_1;
        int calc_10 = inputText1 * positional_10;
        int calc_100 = inputText1 * positional_100;
        int calc = (calc_100 * 100) + (calc_10 * 10) + (calc_1 * 1);

        Console.WriteLine(calc_100);
        Console.WriteLine(calc_10);
        Console.WriteLine(calc_1);
        Console.WriteLine(calc);
    }
}