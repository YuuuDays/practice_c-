// 入力例を標準入力にセットして、今解いている問題を実行する

class Program
{
    static void Main()
    {
        string inputString = SampleInputs.Love;
        Console.SetIn(new StringReader(inputString));
        
        LoveSubsequence.Run();
    }
}
// LoveSubsequence.Run();
