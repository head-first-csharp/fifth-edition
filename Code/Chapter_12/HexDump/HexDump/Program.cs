if (args.Length != 1)
{
    Console.WriteLine("usage: HexDump filename");
    return;
}

using (var input = GetInputStream(args))
{
    var position = 0;
    var buffer = new byte[16];
    while (true)
    {
        // Read up to the next 16 bytes from the file into a buffer
        var bytesRead = input.Read(buffer, 0, buffer.Length);
        if (bytesRead == 0) return;

        // Write the position (or offset) in hex, followed by a colon and space
        Console.Write("{0:x4}: ", position);
        position += bytesRead;

        // Write the hex value of each character in the byte array
        for (var i = 0; i < 16; i++)
        {
            if (i < bytesRead)
                Console.Write("{0:x2} ", (byte)buffer[i]);
            else
                Console.Write("   ");
            if (i == 7) Console.Write("-- ");
        }

        // Write the actual characters in the buffer
        for (int i = 0; i < bytesRead; i++)
        {
            if (buffer[i] < 32)
                buffer[i] = (byte)'?';
            Console.Write((char)buffer[i]);
        }
        Console.WriteLine();
    }
}

Stream GetInputStream(string[] args)
{
    if ((args.Length != 1) || !File.Exists(args[0]))
        return Console.OpenStandardInput();
    else
    {
        try
        {
            return File.OpenRead(args[0]);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.Error.WriteLine("Unable to read {0}, dumping from stdin: {1}",
                                    args[0], ex.Message);
            return Console.OpenStandardInput();
        }
    }
}