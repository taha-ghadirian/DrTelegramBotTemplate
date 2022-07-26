namespace DrTelegramBotTemplate.Basic.DevelopmentUtilities;

public static class ApplicationBreaker
{
    /// <summary>
    ///     This method will pause the thread and listen for <see cref="key" /> to continue.
    /// </summary>
    /// <param name="key">Close key</param>
    public static void ListenToKey(ConsoleKey key)
    {
        while (true)
        {
            var inputKey = Console.ReadKey();
            if (inputKey.Key == key)
                break;
        }
    }
}