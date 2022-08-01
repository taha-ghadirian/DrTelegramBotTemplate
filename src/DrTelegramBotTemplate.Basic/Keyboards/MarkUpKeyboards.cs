using Telegram.Bot.Types.ReplyMarkups;

namespace DrTelegramBotTemplate.Basic.Keyboards;

public static class MarkUpKeyboards
{
    public static ReplyKeyboardMarkup MainKeyboardMarkup = new(new[]
    {
        new[]
        {
            new KeyboardButton("First row (Normal button)"),
            KeyboardButton.WithWebApp("First row (Web App)", new WebAppInfo() { Url = "https://telegram.org" }),
        },
        new[]
        {
            KeyboardButton.WithRequestContact("Second row (Contact Request)"),
            KeyboardButton.WithRequestPoll("Second row (Pull request)"),
        },
        new[]
        {
            KeyboardButton.WithRequestLocation("Third row (Location request)"),
        },
        new []
        {
            new KeyboardButton("Show me random number!")
        }
    })
    {
        ResizeKeyboard = true,
        InputFieldPlaceholder = "Random placeholder",
    };


    // How can you pass parameters? Use them as a method!
    public static ReplyKeyboardMarkup NumberKeyboardMarkup(int number)
    {
        return new ReplyKeyboardMarkup(new[]
        {
            new KeyboardButton($"Here is the number: {number}")
        })
        {
            OneTimeKeyboard = true,
            ResizeKeyboard = true,
        };
    }
}