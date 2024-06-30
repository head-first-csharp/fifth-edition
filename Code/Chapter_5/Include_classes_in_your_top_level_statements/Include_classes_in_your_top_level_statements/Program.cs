new MessageWriter().WriteMessage();

class MessageWriter
{
    public string Message { get; set; } = "This is a message";

    public void WriteMessage()
    {
        Console.WriteLine($"The message is: {Message}");
    }

}
