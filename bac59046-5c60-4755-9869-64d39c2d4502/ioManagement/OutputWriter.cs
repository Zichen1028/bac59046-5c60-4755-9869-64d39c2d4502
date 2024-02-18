public class OutputWriter
{
	/**
	 * process the output as the results
	 * @param outputArr		an array that contains two ints as the results
	 *						which indicates the starting index and the end index
	 *						of the subsequence
	 * @param originArr		an array that contains the original ints from the 
	 *						input content
	 */
	public void processOutputResult(int[] outputArr, int[] originArr)
	{
		int indexStart = outputArr[0];
		int indexEnd = outputArr[1];
		Console.WriteLine("#####################Solution output starts#####################");

		for (int i = indexStart; i < indexEnd; i++)
        {
            Console.WriteLine(originArr[i]);
        }

        Console.WriteLine("#####################Solution output ends#####################");
    }
}


