namespace _2015DayOne;

public static class FloorTracker
{
    public static int TrackFloor(string path)
    {
        var splitPath = path.ToCharArray();
        int finalFloor = 0;
        foreach (var floor in splitPath)
        {
            Console.WriteLine(floor);
            Console.WriteLine(finalFloor);

            if (floor == '(')
            {
                finalFloor += 1;
            }
            if (floor == ')')
            {
                finalFloor -= 1;
            }
        }
        
        return finalFloor;
    }
}