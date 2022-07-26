using Telegram.Bot.Exceptions;
using Telegram.Bot.Types.Enums;

namespace DrTelegramBotTemplate.Basic.UpdateReceiver;

public static class UpdateBus
{
    public static async Task UpdateHandler(ITelegramBotClient bot, Update update, CancellationToken cancelToken)
    {
        switch (update.Type)
        {
            case UpdateType.Unknown:
                break;
            case UpdateType.Message:
                await MessageReceiver.HandleNewMessagesAsync(bot, update.Message!, cancelToken);
                break;
            case UpdateType.InlineQuery:
                break;
            case UpdateType.ChosenInlineResult:
                break;
            case UpdateType.CallbackQuery:
                break;
            case UpdateType.EditedMessage:
                break;
            case UpdateType.ChannelPost:
                break;
            case UpdateType.EditedChannelPost:
                break;
            case UpdateType.ShippingQuery:
                break;
            case UpdateType.PreCheckoutQuery:
                break;
            case UpdateType.Poll:
                break;
            case UpdateType.PollAnswer:
                break;
            case UpdateType.MyChatMember:
                break;
            case UpdateType.ChatMember:
                break;
            case UpdateType.ChatJoinRequest:
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }

    public static Task ErrorHandler(ITelegramBotClient bot, Exception exception, CancellationToken cancelToken)
    {
        var errorMessage = exception switch
        {
            ApiRequestException apiRequestException
                => $"Telegram API Error:\n[{apiRequestException.ErrorCode}]\n{apiRequestException.Message}",
            _ => exception.ToString()
        };

        Console.WriteLine(errorMessage);
        return Task.CompletedTask;
    }
}