using LivingInTheCommandLine.Slides;
using Spectre.Console;

var slides = new Slide[]
{
    new TitleSlide()
};

foreach (var slide in slides)
{
    slide.Show();
}

AnsiConsole.ResetColors();
AnsiConsole.Clear();