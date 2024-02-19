## Problem
Develop a function that takes one string input of any number of integers separated by a single whitespace. The function then outputs the longest increasing subsequence (increased by any number) present in that sequence. If more than 1 sequence exists with the longest length, output the earliest one. You may develop supporting functions as many as you find reasonable.

### Test Cases
* All 11 test cases in the code-test.txt instruction are fully covered by the unit tests

### Continuous integration
* The automation CI is created by GitHub Actions (only for main branch)
* The project will be building and running all the unit tests in the CI process
* The successfully compiled docker image will be published 
* In the practical developing environment, this step should be followed by pushing the docker image into AWS ECR and then deployed to ECS

## Requirements
For building and running the application you need:
.NET core 7.0

## Running the application locally
* You can pull the repo from GitHub to build and run
* or you can retrieve the docker image here: https://github.com/zichen1028/bac59046-5c60-4755-9869-64d39c2d4502/pkgs/container/bac59046-5c60-4755-9869-64d39c2d4502

### Run the console project
* In the root directory, run the command ```dotnet run --project ./bac59046-5c60-4755-9869-64d39c2d4502```
### Run the unit tests
* In the root directory, run the command ```dotnet test ./UnitTests```

