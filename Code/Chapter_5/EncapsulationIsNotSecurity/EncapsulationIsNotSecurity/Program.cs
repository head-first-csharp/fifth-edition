using System.Reflection;

HasASecret keeper = new HasASecret();

// Uncommenting this Console.WriteLine statement causes a compiler error:
// 'HasASecret.secret' is inaccessible due to its protection level
// Console.WriteLine(keeper.secret);

// But we can still use reflection to get the value of the secret field
FieldInfo[] fields = keeper.GetType().GetFields(
                BindingFlags.NonPublic | BindingFlags.Instance);

// This foreach loop will cause "xyzzy" to be printed to the console
foreach (FieldInfo field in fields)
{
    Console.WriteLine(field.GetValue(keeper));
}