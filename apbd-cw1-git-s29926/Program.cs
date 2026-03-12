using apbd_cw1_git_s29926;

Console.WriteLine("Statistics application started.");
Console.WriteLine("Enter numbers separated by commas:");
string? input = Console.ReadLine();

if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Input cannot be empty. Please enter at least one number.");
    return;
}

int[] values = { 2, 4, 6, 8 };
Console.WriteLine("Average: " + StatisticsHelper.CalculateAverage(values));