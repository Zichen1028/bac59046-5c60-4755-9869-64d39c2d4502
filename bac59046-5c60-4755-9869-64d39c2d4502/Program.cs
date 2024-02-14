using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main(string[] args)
    {
        string filePath = @"../../../Input.txt";
        string input = File.ReadAllText(filePath);

        // Print the input value
        Console.WriteLine("Output is: " + input);
    }
}