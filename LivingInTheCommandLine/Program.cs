using Spectre.Console;

AnsiConsole.Clear();

Console.CursorTop = 10;

var font = FigletFont.Load(@"fonts\ANSI Shadow.flf");
AnsiConsole.Write(
    new FigletText(font, "Living")
        .Centered()
        .Color(Color.DarkGreen)); 

AnsiConsole.Write(
    new FigletText(font, "in the")
        .Centered()
        .Color(Color.Grey));

AnsiConsole.Write(
    new FigletText(font, "Command Line")
        .Centered()
        .Color(Color.DarkGreen));

AnsiConsole.WriteLine();
AnsiConsole.WriteLine();

AnsiConsole.Markup("[Green]READY[/] > ");


Console.ReadLine();