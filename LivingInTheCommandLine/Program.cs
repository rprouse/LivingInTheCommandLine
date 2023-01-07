using LivingInTheCommandLine.Slides;
using Spectre.Console;

var slides = new ISlide[]
{
    new TitleSlide(),
    new MakeItBeautifulSlide(),
    new CloudAndDevelopmentSlide(),
    new AutomateEverythingSlide(),
};

foreach (var slide in slides)
{
    Show(slide.Title);
    Show(slide.Content);
}

AnsiConsole.ResetColors();
AnsiConsole.Clear();

static void Show(Action slide)
{
    Console.Clear();
    slide();
    Console.ReadLine();
    AnsiConsole.ResetColors();
}