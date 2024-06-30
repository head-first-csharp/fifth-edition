using Serilog;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File($"log-{DateTime.Now:yyyyMMdd-HHmmss}.log")
    .CreateLogger();

Log.Information("App started with {0} argument(s): {1}", args.Length, args);

var firstLine = "No first line was read";
try
{
    var lines = File.ReadAllLines(args[0]);
    firstLine = (lines.Length > 0) ? lines[0] : "The file was empty";
    if (lines.Length == 0) Log.Warning("No lines found in file");
}
catch (IndexOutOfRangeException)
{
    Log.Warning("Please specify a filename.");
}
catch (FileNotFoundException)
{
    Log.Error("Unable to find file: {0}", args[0]);
}
catch (UnauthorizedAccessException ex)
{
    Log.Error("File {0} could not be accessed: {1}",
                                    args[0], ex.Message);
}
finally
{
    Console.WriteLine(firstLine);
}
