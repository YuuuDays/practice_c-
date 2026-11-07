// 入力例を標準入力にセットして、今解いている問題を実行する

class Program
{
    static void Main()
    {
        // sample入力値
        string inputString = SampleInputs.Map1;
        Console.SetIn(new StringReader(inputString));
    
        Practices.Run1();
    }
}

