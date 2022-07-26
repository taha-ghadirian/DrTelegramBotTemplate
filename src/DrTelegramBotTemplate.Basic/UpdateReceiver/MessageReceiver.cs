namespace DrTelegramBotTemplate.Basic.UpdateReceiver;

public static class MessageReceiver
{
    public static async Task HandleNewMessagesAsync(ITelegramBotClient bot, Message message,
        CancellationToken cancelToken)
    {
        var from = message.From;
        if (from == null) throw new Exception("Error!");

        await bot.SendTextMessageAsync(from.Id, "This is what you've sent: 👇👇", cancellationToken: cancelToken);
        await bot.CopyMessageAsync(from.Id, from.Id, message.MessageId, cancellationToken: cancelToken);
    }
}