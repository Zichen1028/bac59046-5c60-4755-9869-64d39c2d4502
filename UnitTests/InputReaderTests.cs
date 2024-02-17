namespace UnitTests;

public class InputReaderTests
{
    private InputReader _inputReader1 { get; set; } = null!;

    private InputReader _inputReader2 { get; set; } = null!;


    [SetUp]
    public void Setup()
    {
        string correctTestInputFilePath = @"../../../CorrectTestInputFile.txt";
        string ErrorTestInputFilePath = @"../../../ErrorTestInputFile.txt";

        _inputReader1 = new InputReader(correctTestInputFilePath);
        _inputReader2 = new InputReader(ErrorTestInputFilePath);
    }

    [Test]
    public void ReadInput_ShouldReturnExpectedInputIntsTest1()
    {
        int[] expectedInputIntsArr = { 6, 2, 4, 6, 1, 5, 9, 2 }; 

        // Act
        int[] testInputArr = _inputReader1.readInput();

        // Assert
        Assert.That(testInputArr, Is.EqualTo(expectedInputIntsArr));
    }

    [Test]
    public void ReadInput_ShouldReturnEmptyIntsArrWhenInputFileContainsNotIntegersTest2()
    {
        int[] expectedInputIntsArr = new int[0];

        // Act
        int[] testInputArr = _inputReader2.readInput();

        // Assert
        Assert.That(testInputArr, Is.EqualTo(expectedInputIntsArr));
    }
}
