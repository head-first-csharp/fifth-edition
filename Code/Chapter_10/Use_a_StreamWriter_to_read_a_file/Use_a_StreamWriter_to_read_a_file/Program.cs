var folder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
Console.WriteLine($"Reading and writing files in this folder: {folder}");

StreamReader reader = new(Path.Combine(folder, "secret_plan.txt"));
StreamWriter writer = new(Path.Combine(folder, "emailToCaptainA.txt"));

writer.WriteLine("To: CaptainAmazing@objectville.net");
writer.WriteLine("From: Commissioner@objectville.net");
writer.WriteLine("Subject: Can you save the day...again?");
writer.WriteLine();
writer.WriteLine("We’ve discovered the Swindler’s terrible plan:");

while (!reader.EndOfStream)
{
    var lineFromThePlan = reader.ReadLine();
    writer.WriteLine($"The plan -> {lineFromThePlan}");
}
writer.WriteLine();
writer.WriteLine("Can you help us?");

writer.Close();
reader.Close();