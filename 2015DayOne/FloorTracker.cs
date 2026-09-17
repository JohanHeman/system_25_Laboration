namespace _2015DayOne;

public class FloorTracker
{
    public int TrackFloor(string path)
    {

        if (String.IsNullOrEmpty(path)) throw new Exception("The input can not be empty");
        var splitPath = path.ToCharArray();
        int finalFloor = 0;
        foreach (var floor in splitPath)
        {

            if (floor != '(' || floor != ')') throw new Exception("The symbol must be '(' or ')'");

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