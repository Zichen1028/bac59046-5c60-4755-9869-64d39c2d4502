namespace UnitTests;

public class SolutionAlgorithmTests
{
    private SolutionAlgorithm _solutionAlgorithm { get; set; } = null!;

    private string completeTestCaseInputFilePath = @"../../../CompleteTestCaseInputFile.txt";

    private string completeTestCaseOutputFilePath = @"../../../CompleteTestCaseOutputFile.txt";

    [SetUp]
    public void Setup()
    {
        _solutionAlgorithm = new SolutionAlgorithm();
    }

    [Test]
    public void CompleteTestCase_ShouldAllReturnExpectedArr()
    {
        List<string> inputLinesList = readLinesFromFile(completeTestCaseInputFilePath);
        List<string> outputLinesList = readLinesFromFile(completeTestCaseOutputFilePath);

        for (int i = 0; i < inputLinesList.Count; i++) 
        {
            int[] inputIntsArr = readInputIntsArr(inputLinesList[i]);
            int[] expectedOutputResultArr = readInputIntsArr(outputLinesList[i]);
            int[] resultIndexArr = _solutionAlgorithm.calculateSolution(inputIntsArr);

            int indexStart = resultIndexArr[0];
            int indexEnd = resultIndexArr[1];

            List<int> resultInts = new List<int>();
            for (int j = indexStart; j < indexEnd; j++)
            {
                Console.WriteLine(inputIntsArr[j]);
                resultInts.Add(inputIntsArr[j]);
            }

            // Assert the calculated result is equal to the
            // expected result retrieved from "CompleteTestCaseOutputFile.txt"
            Assert.That(resultInts, Is.EqualTo(expectedOutputResultArr));
        }
    }

    private List<string> readLinesFromFile(string filePath)
    {
        var lines = File.ReadLines(filePath);
        List<string> linesList = new List<string>();
        foreach (var line in lines)
        {
            linesList.Add(line);
        }

        return linesList;
    }

    private int[] readInputIntsArr(string line)
    {
        string[] inputStrArr;
        inputStrArr = line.Split(' ');
        return Array.ConvertAll(inputStrArr, int.Parse);
    }
}
