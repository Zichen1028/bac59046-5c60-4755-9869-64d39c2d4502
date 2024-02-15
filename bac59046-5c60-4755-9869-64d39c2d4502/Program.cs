﻿class Program
{
    static void Main(string[] args)
    {
        string filePath = @"../../../Input.txt";
        string inputText = File.ReadAllText(filePath);

        string[] inputArr = inputText.Split(' ');
        int[] arr = Array.ConvertAll(inputArr, int.Parse);

        // start calculating here
        int subSeqLength = 1;
        int longest = 1;
        int indexStart = 0;
        int indexEnd = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] < arr[i + 1])//We need to check if the current is equal to the next
            {
                subSeqLength++;//if it is we increment
                if (subSeqLength > longest)//we assign the longest and new bounds
                {
                    longest = subSeqLength;
                    indexStart = i + 2 - subSeqLength;//make sure the index start is correct
                    indexEnd = i + 2;
                }
            }
            else
            {
                subSeqLength = 1;//else re-initiate the straight length
            }
        }

        for (int i = indexStart; i < indexEnd; i++)
        {
            Console.WriteLine(arr[i]);
        }
        
    }
}