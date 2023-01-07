using Spectre.Console;

namespace LivingInTheCommandLine.Slides;

internal class CloudAndDevelopmentSlide : ISlide
{
    public void Title()
    {
        Console.CursorTop = 10;

        var font = FigletFont.Load(@"fonts/ANSI Shadow.flf");
        AnsiConsole.Write(
            new FigletText(font, "Cloud")
                .Centered()
                .Color(Color.LightGoldenrod1));

        AnsiConsole.Write(
            new FigletText(font, "and")
                .Centered()
                .Color(Color.Silver));

        AnsiConsole.Write(
            new FigletText(font, "Development Tools")
                .Centered()
                .Color(Color.Orange3));
    }

    public void Content()
    {
    }
}
