using DrTelegramBotTemplate.Basic.Keyboards;

namespace DrTelegramBotTemplate.Basic.UpdateReceiver;

public static class MessageReceiver
{
    public static async Task HandleNewMessagesAsync(ITelegramBotClient bot, Message message,
        CancellationToken cancelToken)
    {
        var from = message.From;
        if (from == null) throw new Exception("Error!");

        if (message.Text == "Show me random number!")
        {
            var rnd = new Random();
            await bot.SendTextMessageAsync(from.Id, "Here is the random number in keyboard",
                replyMarkup: MarkUpKeyboards.NumberKeyboardMarkup(rnd.Next()));
            return;
        }

        await bot.SendTextMessageAsync(from.Id, "This is what you've sent: 👇👇",
            replyMarkup: MarkUpKeyboards.MainKeyboardMarkup, cancellationToken: cancelToken);
        await bot.CopyMessageAsync(from.Id, from.Id, message.MessageId, cancellationToken: cancelToken);
    }
}