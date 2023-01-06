using Spectre.Console;

namespace LivingInTheCommandLine.Slides
{
    internal class MakeItBeautifulSlide : ISlide
    {
        public void Show()
        {
            AnsiConsole.Clear();

            Console.CursorTop = 10;

            var font = FigletFont.Load(@"fonts/ANSI Shadow.flf");
            AnsiConsole.Write(
                new FigletText(font, "Make It")
                    .Centered()
                    .Color(Color.Yellow));

            AnsiConsole.Write(
                new FigletText(font, "Beautiful")
                    .Centered()
                    .Color(Color.Red));

            Console.ReadLine();
        }
    }
}
