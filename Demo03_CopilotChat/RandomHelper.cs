namespace Demolice.Demo03_CopilotChat;

public static class RandomHelper
{
    /// <summary>
    /// Už nikdo neví, co tohle vlastně dělá
    /// Vysvětlit + Optimalizovat
    /// </summary>
    public static string Gertruda(int c)
    {
        var r = new Random();
        var s = "";
        for (int i = 0; i < c; i++)
        {
            int q = 0;
            while (true)
            {
                q = r.Next(65, 123);
                if ((q >= 65 && q <= 90) || (q >= 97 && q <= 122))
                    break;
            }

            s += Convert.ToChar(q);
        }

        return s;
    }
}