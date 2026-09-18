namespace ElvesLookElvesSay;

public class LookSay
{
    public long CountNumberOcurrance(long value)
    {
        var valueArr= value.ToString().ToCharArray();

        int tempCount = 0;
        string result = "";

        for (int i = 0; i < valueArr.Length; i++)
        {
            while (i < valueArr.Length - 1)
            {
                if (valueArr[i] == valueArr[i + 1])
                {
                    tempCount++;
                    i++;
                }
                else
                {
                    break;
                }
            }

            tempCount++;
            result += $"{tempCount}{valueArr[i]}";
            tempCount = 0;
        }
        return long.Parse(result);

    }


    
}