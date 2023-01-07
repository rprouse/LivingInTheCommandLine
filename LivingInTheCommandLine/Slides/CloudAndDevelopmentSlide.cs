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
        Console.CursorTop = 20;
        // Create a table
        var table = new Table();
        table.Border(TableBorder.Rounded);
        table.Centered();

        // Add some columns
        table.AddColumn(new TableColumn("Source Control").Centered());
        table.AddColumn(new TableColumn("Cloud Tools").Centered());
        table.AddColumn(new TableColumn("REPLs").Centered());

        // Add some rows
        table.AddRow("git", "az", "csi");
        table.AddRow("gh", "aws", "python");
        table.AddRow("", "gcloud", "node");
        table.AddRow("", "", "etc.");

        // Render the table to the console
        AnsiConsole.Write(table);
    }
}
