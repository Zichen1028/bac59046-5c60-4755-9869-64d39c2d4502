public class SolutionAlgorithm
{
    /**
        * Algorithm of the solution
        * @param inputArr      the input array to be calculated
        * @return outputArr    the output array that contains two nums as the result
        */
    public int[] calculateSolution(int[] inputArr)
    {
        // start calculating here
        int subSeqLength = 1;
        int longest = 1;
        int indexStart = 0;
        int indexEnd = 0;

        for (int i = 0; i < inputArr.Length - 1; i++)
        {
            if (inputArr[i] < inputArr[i + 1])
            {
                ////if this is the case, increment
                subSeqLength++; 

                //we assign the longest and new bounds
                if (subSeqLength > longest) 
                {
                    longest = subSeqLength;

                    //this is to make sure the index start is correct
                    indexStart = i + 2 - subSeqLength;
                    indexEnd = i + 2;
                }
            }
            else
            {
                //otherwise initiate the straight length as 1
                subSeqLength = 1;
            } 
        }

        int[] outputArr = { indexStart, indexEnd };
        return outputArr;
    }
}


