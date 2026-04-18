using Dntc.Attributes;
using DotnetSnes.Core;

namespace TestingSNES;

public static class Game
{
    [CustomFunctionName("main")]
    public static int Main()
    {
        while (true)
        {
            Interrupt.WaitForVBlank();
        }

        return 0;
    }
}
