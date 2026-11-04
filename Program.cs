class Program
{
    const string Target = "LOVE";

    static void Main()
    {
        // 標準入力用
        #if DEBUG
        Console.SetIn(new StringReader(TestInput.input));
        #endif

        // 1行目のNは使わないので読み飛ばす
        Console.ReadLine();
        var s = Console.ReadLine()!;

        Console.WriteLine(CountSubsequences(s, Target));
    }

    // sの中にあるtargetの部分列の数を返す
    static int CountSubsequences(string s, string target)
    {
        // counts[i] : targetの先頭i文字を作る方法の数（counts[0]は空文字の1通り）
        var counts = new int[target.Length + 1];
        counts[0] = 1;

        foreach (char c in s)
        {
            // 同じ文字を二重に使わないよう、後ろから更新する
            for (int i = target.Length - 1; i >= 0; i--)
            {
                if (c == target[i])
                {
                    counts[i + 1] += counts[i];
                }
            }
        }

        return counts[target.Length];
    }
}
