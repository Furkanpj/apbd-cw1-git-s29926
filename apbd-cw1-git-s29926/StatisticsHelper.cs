namespace apbd_cw1_git_s29926;

public static class StatisticsHelper
{
    public static double CalculateAverage(int[] values)
    {
        if (values.Length == 0)
            return 0;

        return values.Average();
    }
}