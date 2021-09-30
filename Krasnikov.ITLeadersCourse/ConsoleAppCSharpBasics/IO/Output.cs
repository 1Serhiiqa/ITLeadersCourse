public class Output
{
    private static IOutput output;

    public static IOutput Out
    {
        get
        {
            if (output == null)
            {
                output = new OutputFactory().GetOutputInstance(typeof(ConsoleOutput));
            }

            return output;
        }
    }
}