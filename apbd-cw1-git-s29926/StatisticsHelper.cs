namespace apbd_cw1_git_s29926;

public static class StatisticsHelper
{
    public static double CalculateAverage(int[] values)
    {
        if (values.Length == 0)
            return 0;

        return values.Average();
    }
    public static int CalculateMax(int[] values)
    {
        if (values.Length == 0)
            return 0;

        return values.Max();
    }
    public static int CalculateMin(int[] values)
    {
        if (values.Length == 0)
            return 0;

        return values.Min();
    }
}