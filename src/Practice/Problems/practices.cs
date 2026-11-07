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
        // 1行目：マップの行数（列数は各行の文字列の長さでわかるので使わない）
        int[] size = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        int h = size[0];

        // 2行目から：マップを1行ずつcharの配列にして読む
        char[][] map = new char[h][];
        for (int y = 0; y < h; y++)
        {
            map[y] = Console.ReadLine()!.ToCharArray();
        }

        // 最後の行：入れ替えるマスの位置
        int[] pos = Console.ReadLine()!.Split(' ').Select(int.Parse).ToArray();
        int py = pos[0];
        int px = pos[1];

        // . なら # に、それ以外なら . にする
        map[py][px] = map[py][px] == '.' ? '#' : '.';

        // 1行ずつ文字列に戻して表示する
        foreach (char[] row in map)
        {
            Console.WriteLine(new string(row));
        }

        // ---- 元のコード ----
        // string[] inputNum = Console.ReadLine().Split(' ');
        // int h = int.Parse(inputNum[0]);
        // int w = int.Parse(inputNum[1]);
        //
        // char[,] inputArray = new char[h, w];
        //
        // for (int i = 0; i < h; i++)
        // {
        //
        //     string s = Console.ReadLine() ?? "";
        //     for (int j = 0; j < w; j++)
        //     {
        //         inputArray[i, j] = s[j];
        //     }
        // }
        // // 入力値検査
        //
        // // string s = Console.ReadLine() ?? "";
        // string[] inputConvertNum = Console.ReadLine().Split(' ');
        // int hNum = int.Parse(inputConvertNum[0]);
        // int wNum = int.Parse(inputConvertNum[1]);
        //
        // if(inputArray[hNum, wNum] == '.')
        // {
        //     inputArray[hNum, wNum] = '#';
        // }
        // else
        // {
        //     inputArray[hNum, wNum] = '.';
        // }
        //
        // for (int i = 0; i < h; i++)
        // {
        //     for (int j = 0; j < w; j++)
        //     {
        //         Console.Write(inputArray[i, j]);
        //     }
        //     Console.WriteLine();
        // }
        // // Console.WriteLine("Hello, World!");
    }
}
