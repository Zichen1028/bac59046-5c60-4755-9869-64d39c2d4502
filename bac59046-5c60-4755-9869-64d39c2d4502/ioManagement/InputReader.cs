public class InputReader
{
	public int[] readInput()
	{
        string filePath = @"../../../Input.txt";
        string inputText = File.ReadAllText(filePath);

        string[] input = inputText.Split(' ');
        return Array.ConvertAll(input, int.Parse);
    }
}