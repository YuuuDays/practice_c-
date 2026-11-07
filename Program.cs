using System;

class Program
{
    static void Main()
    {
        // 1行目のNは使わないので読み飛ばす
        Console.ReadLine();
        string s = Console.ReadLine() ?? "";

        // それぞれの文字列を作れる数
        long l = 0, lo = 0, lov = 0, love = 0;

        foreach (char c in s)
        {
            if (c == 'L') l++;            // Lが1個増える
            else if (c == 'O') lo += l;   // 今あるLの数だけLOが増える
            else if (c == 'V') lov += lo; // 今あるLOの数だけLOVが増える
            else if (c == 'E') love += lov; // 今あるLOVの数だけLOVEが増える
        }

        Console.WriteLine(love);
    }
}
