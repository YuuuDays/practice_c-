#if DEBUG
using System.Runtime.CompilerServices;

// デバッグ実行のときだけ、Mainより先に標準入力をここの文字列に差し替える
// Program.csには何も書かなくていいので、Program.csはそのまま提出できる
static class TestInput
{
    public static string input = """
    10
    LOVEHEAVYE
    """;

    [ModuleInitializer]
    internal static void Setup() => Console.SetIn(new StringReader(input));
}
#endif
