public class InputReader
{
    private readonly string filePath;

    public InputReader(String filePath)
    {
        this.filePath = filePath;
    }

	public int[] readInput()
	{
        string inputText = File.ReadAllText(this.filePath);
        string[] inputStrArr;
        int[] inputIntsArr;

        // handle the case when the input txt contains something
        // that is not an integer or cannot be parsed into an integer
        try
        {
            inputStrArr = inputText.Split(' ');
            inputIntsArr = Array.ConvertAll(inputStrArr, int.Parse);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            inputIntsArr = new int[0];
            return inputIntsArr;
        }

        return inputIntsArr;
    }
}