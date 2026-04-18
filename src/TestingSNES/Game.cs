using Dntc.Attributes;
using DotnetSnes.Core;

namespace TestingSNES;

public static class Game
{
    [CustomFunctionName("main")]
    public static int Main()
    {
        Video.SetScreenOn();

        while (true)
        {
            Interrupt.WaitForVBlank();
        }

        return 0;
    }
}
