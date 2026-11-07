// 文字列Sの中にある LOVE の部分列の数を数える
public static class Practices
{
    public static void Run()
    {
        Console.ReadLine(); // 1行目のNは使わない
        string s = Console.ReadLine() ?? "";

        // それぞれの文字列を作れる数
        long l = 0, lo = 0, lov = 0, love = 0;

        foreach (char c in s)
        {
            if (c == 'L') l++;              // Lが1個増える
            else if (c == 'O') lo += l;     // 今あるLの数だけLOが増える
            else if (c == 'V') lov += lo;   // 今あるLOの数だけLOVが増える
            else if (c == 'E') love += lov; // 今あるLOVの数だけLOVEが増える
        }

        Console.WriteLine(love);
    }

    // Map1
    public static void Run1()
    {
        string[] inputNum = Console.ReadLine().Split(' ');
        int h = int.Parse(inputNum[0]);
        int w = int.Parse(inputNum[1]);

        char[,] inputArray = new char[h, w];

        for (int i = 0; i < h; i++)
        {

            string s = Console.ReadLine() ?? "";
            for (int j = 0; j < w; j++)
            {
                inputArray[i, j] = s[j];
            }
        }
        // 入力値検査

        // string s = Console.ReadLine() ?? "";
        string[] inputConvertNum = Console.ReadLine().Split(' ');
        int hNum = int.Parse(inputConvertNum[0]);
        int wNum = int.Parse(inputConvertNum[1]);

        if(inputArray[hNum, wNum] == '.')
        {
            inputArray[hNum, wNum] = '#';
        }
        else
        {
            inputArray[hNum, wNum] = '.';
        }

        for (int i = 0; i < h; i++)
        {
            for (int j = 0; j < w; j++)
            {
                Console.Write(inputArray[i, j]);
            }
            Console.WriteLine();
        }
        // Console.WriteLine("Hello, World!");
    }
}
