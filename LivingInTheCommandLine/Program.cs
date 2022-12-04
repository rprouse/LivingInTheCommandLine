using LivingInTheCommandLine.Slides;
using Spectre.Console;

var slides = new ISlide[]
{
    new TitleSlide()
};

foreach (var slide in slides)
{
    slide.Show();
}

AnsiConsole.ResetColors();
AnsiConsole.Clear();