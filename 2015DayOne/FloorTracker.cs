namespace _2015DayOne;

public class FloorTracker
{
    public static int TrackFloor(string path)
    {
        var splitPath = path.Split().ToArray();
        var finallFloor = 0;
        foreach (var floor in splitPath)
        {
            if (floor == "(") finallFloor += 1;
            if (floor == ")") finallFloor -= 1;
        }

        return finallFloor;
    }
}