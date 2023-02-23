internal class Program
{
    [STAThread]
    private static void Main(string[] args)
    {
        var guid = Guid.NewGuid().ToString().ToUpper();
        Console.WriteLine(guid);
        Console.WriteLine("Press 'C' key to copy guid to clipboard. Press any other key to cancel.");
        if (Console.ReadKey(true).Key == ConsoleKey.C)
        {
            Clipboard.SetText(guid);
            Console.WriteLine($"{guid} copied to clipboard!");
        }
    }
}