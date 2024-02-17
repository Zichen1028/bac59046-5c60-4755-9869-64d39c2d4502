class Program
{
    static void Main(string[] args)
    {
        string filePath = @"../../../Input.txt";
        InputReader inputReader = new InputReader(filePath);
        int[] inputArr = inputReader.readInput();

        SolutionAlgorithm solutionAlgorithm = new SolutionAlgorithm();
        int[] outputs = solutionAlgorithm.calculateSolution(inputArr);

        OutputWriter outputWriter = new OutputWriter();
        outputWriter.processOutputResult(outputs, inputArr);
    }
}