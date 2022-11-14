using System;

public class Program
{
    public static void Main()
    {
        // 입력한 값 -> 이 값은 0보다 크거나 같고 10보다 작거나 같은 정수이다.
        string inputText = Console.ReadLine();

        // ' '으로 입력 문자 나누기
        string[] tmp = inputText.Split(' ');

        // 체스는 총 16개의 피스를 사용하며, 킹 1개, 퀸 1개, 룩 2개, 비숍 2개, 나이트 2개, 폰 8개로 구성되어 있다.
        int[] Chesspieces = new int[] { 1, 1, 2, 2, 2, 8 };

        for (int i = 0; i < Chesspieces.Length; i++)
        {
            if (int.Parse(tmp[i]) == Chesspieces[i])
            {
                Console.WriteLine(0);
            }
            else
            {
                // 만약 수가 양수라면 동혁이는 그 개수 만큼 피스를 더해야 하는 것이고, 음수라면 제거해야 하는 것이다.
                Console.WriteLine(Chesspieces[i] - int.Parse(tmp[i]));
            }
        }
    }
}