namespace DrTelegramBotTemplate.Basic;

public static class Client
{
    public static readonly ITelegramBotClient Bot = new TelegramBotClient("TOKEN");

    public static User Me = null!;
}