using LivingInTheCommandLine.Slides;
using Spectre.Console;

var slides = new ISlide[]
{
    new TitleSlide(),
    new MakeItBeautifulSlide(),
};

foreach (var slide in slides)
{
    slide.Show();
}

AnsiConsole.ResetColors();
AnsiConsole.Clear();