class Program
{
    static void Main(string[] args)
    {
        InputReader inputReader = new InputReader();
        int[] inputArr = inputReader.readInput();

        SolutionAlgorithm solutionAlgorithm = new SolutionAlgorithm();
        int[] outputs = solutionAlgorithm.calculateSolution(inputArr);

        OutputWriter outputWriter = new OutputWriter();
        outputWriter.processOutputResult(outputs, inputArr);
    }
}