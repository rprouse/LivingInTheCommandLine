using Spectre.Console;

namespace LivingInTheCommandLine.Slides;

internal class MakeItBeautifulSlide : ISlide
{
    public void Title()
    {
        Console.CursorTop = 10;

        var font = FigletFont.Load(@"fonts/ANSI Shadow.flf");
        AnsiConsole.Write(
            new FigletText(font, "Make It")
                .Centered()
                .Color(Color.Gold1));

        AnsiConsole.Write(
            new FigletText(font, "Beautiful")
                .Centered()
                .Color(Color.OrangeRed1));
    }

    public void Content()
    {
        AnsiConsole.Cursor.SetPosition(0, 20);
        var root = new Tree("A Prettier Command Prompt");
        root.Style("darkslategray2");

        var shell = root.AddNode("[yellow1]Use a modern Terminal and Shell[/]");

        var ps = root.AddNode("[plum1]PowerShell[/]");
        ps.AddNode("[silver]oh-my-posh[/]");
        ps.AddNode("[silver]posh-git[/]");
        ps.Collapse();

        var linux = root.AddNode("[green]Linux/Mac[/]");
        linux.AddNode("[silver]oh-my-zsh[/]");
        linux.AddNode("[silver]oh-my-bash[/]");
        linux.Collapse();

        AnsiConsole.Write(root);

        Console.ReadLine();
        ps.Expand();
        Console.Clear();
        AnsiConsole.Cursor.SetPosition(0, 20);
        AnsiConsole.Write(root);

        Console.ReadLine();
        linux.Expand();
        Console.Clear();
        AnsiConsole.Cursor.SetPosition(0, 20);
        AnsiConsole.Write(root);
    }
}
