using LivingInTheCommandLine.Slides;
using Spectre.Console;

namespace LivingInTheCommandLine.Slides;

internal class AutomateEverythingSlide : ISlide
{
    public void Title()
    {
        Console.CursorTop = 10;

        var font = FigletFont.Load(@"fonts/ANSI Shadow.flf");
        AnsiConsole.Write(
            new FigletText(font, "Automate")
                .Centered()
                .Color(Color.SkyBlue1));

        AnsiConsole.Write(
            new FigletText(font, "Everything")
                .Centered()
                .Color(Color.GreenYellow));
    }

    public void Content()
    {

    }
}
