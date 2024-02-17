namespace UnitTests;

public class SolutionAlgorithmTests
{
    private SolutionAlgorithm _solutionAlgorithm { get; set; } = null!;

    [SetUp]
    public void Setup()
    {
        _solutionAlgorithm = new SolutionAlgorithm();
    }

    [Test]
    public void CalculateSolution_ShouldReturnExpectedOutputTest1()
    {
        // Assign
        int[] inputTest = { 6, 2, 4, 6, 1, 5, 9, 2 };
        int[] expectedResultArr = { 1, 4 };

        // Act
        int[] resultArr = _solutionAlgorithm.calculateSolution(inputTest);

        // Assert
        Assert.That(resultArr, Is.EqualTo(expectedResultArr));
    }

    [Test]
    public void CalculateSolution_ShouldReturnExpectedOutputTest2()
    {
        // Assign
        int[] inputTest = { 6, 2, 4, 3, 1, 5, 9 };
        int[] expectedResultArr = { 4, 7 };

        // Act
        int[] resultArr = _solutionAlgorithm.calculateSolution(inputTest);

        // Assert
        Assert.That(resultArr, Is.EqualTo(expectedResultArr));
    }
}
