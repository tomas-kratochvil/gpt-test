namespace Demolice.Demo03_CopilotChat;

public class BrokenService
{
    /// <summary>
    /// V této metodě je záměrně chyba
    /// Přidat logování do třídy
    /// Vyzkoušet Debug mód
    /// </summary>
    public string GetCode()
    {
        var hexChars = "0123456789ABCDEF";
        var rnd = new Random();
        var result = "";

        for (int i = 0; i < 10; i++)
        {
            int index = rnd.Next(0, hexChars.Length + 1);
            result += hexChars[index];
        }

        return result;
    }
}