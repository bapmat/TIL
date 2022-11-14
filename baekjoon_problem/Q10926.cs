using System;

public class Program
{
    public static void Main()
    {
        // 입력받은 값
        string inputText = Console.ReadLine().ToLower();
        if (inputText.Length < 51)
        {
            // 중복체크
            bool dupFlag = false;
            switch (inputText.Trim())
            {
                case "joonas":
                case "baekjoon":
                    dupFlag = true;
                    break;
                default:
                    dupFlag = false;
                    break;
            }
            // 중복 아니면 원래대로, 중복이면 '??!'
            string outputText = (dupFlag ? inputText + "??!" : inputText);
            Console.WriteLine(outputText);
        }
        else
        {
            Console.WriteLine("길이는 50자를 넘지 않는다.");
        }
    }
}