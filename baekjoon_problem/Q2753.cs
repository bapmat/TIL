using System;
					
public class Program
{
	public static void Main()
	{
        // 입력한 값
		int inputText = Convert.ToInt32(Console.ReadLine());
		
		// 윤년은 연도가 4의 배수이면서, 100의 배수가 아닐 때 또는 400의 배수일 때이다.
		//if (inputText % 4 == 0 && (inputText % 100 != 0 || inputText % 400 == 0))
		if (DateTime.IsLeapYear(inputText))
		{
			Console.WriteLine("1");
		}
		else 
		{
			Console.WriteLine("0");
		}
	}
}