using Newtonsoft.Json;

namespace DrTelegramBotTemplate.Basic.DevelopmentUtilities;

public static class ConvertExtensionMethods
{
    public static string ToJson(this object obj)
    {
        return JsonConvert.SerializeObject(obj, Formatting.Indented);
    }
}