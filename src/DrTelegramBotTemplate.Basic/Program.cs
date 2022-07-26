using DrTelegramBotTemplate.Basic.DevelopmentUtilities;
using DrTelegramBotTemplate.Basic.UpdateReceiver;
using Telegram.Bot.Polling;
using Telegram.Bot.Types.Enums;

Client.Me = await Client.Bot.GetMeAsync();
Console.WriteLine(Client.Me.ToJson());

using var cts = new CancellationTokenSource();

var receiveOptions = new ReceiverOptions
{
    Limit = 100,
    AllowedUpdates = new[]
    {
        UpdateType.Message
    }
};

Client.Bot.StartReceiving(
    updateHandler: UpdateBus.UpdateHandler,
    pollingErrorHandler: UpdateBus.ErrorHandler,
    receiverOptions: receiveOptions,
    cancellationToken: cts.Token
);

Console.WriteLine($"Start receiving for @{Client.Me.Username}");

ApplicationBreaker.ListenToKey(ConsoleKey.Escape);