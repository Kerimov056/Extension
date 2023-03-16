namespace Extension._Indexer._Enum.Extension;

public static class MatchCountExtension
{
    public static int MatchCount(this string sentence, string rumor)
    {
        int count = 0;
        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] == ' ')
            {
                count++;
            }
        }

        int say = 0;
        char separator = ' ';
        string word = "";
        string[] arr = new string[count + 1];
        int a = 0;
        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] == separator)
            {
                arr[a] = word;
                a++;
                word = "";
                continue;
            }
            word += sentence[i];
        }
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == rumor)
            {
                say++;
            }
        }
        return say;
    }
}
