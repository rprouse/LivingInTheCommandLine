using Spectre.Console;

namespace LivingInTheCommandLine.Slides;

internal abstract class Slide
{
    public void Show()
    {
        AnsiConsole.Clear();
        Content();
        Console.ReadLine();
    }

    protected abstract void Content();
}
