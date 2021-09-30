public class ConsoleOutput : IOutput
{
    public void Write(object output = null)
    {
        Console.Write(output);
    }

    public void WriteLine(object output = null)
    {
        if (output == null)
        {
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine(output);
        }
    }
}