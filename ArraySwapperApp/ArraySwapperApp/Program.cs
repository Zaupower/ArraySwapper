class Program
{
    static void Main(string[] args)
    {
        String word = "";
        
        Console.WriteLine("Please input word");
        word = Console.ReadLine();

        if (word != null)
        {
            char[] revertedWord = new char[100];
            revertedWord =  ispalidrome(word);
            string t = new string(revertedWord);
            Console.WriteLine(revertedWord);
            Console.WriteLine("(" + word + ")" + " => " + t);
        }
    }

    public static char[] ispalidrome(string word)
    {
        char[] wordCharacters = word.ToCharArray();
        char[] revertedResult = new char[wordCharacters.Length];
        string reverString = "";
        
        for (int i = 0; i < wordCharacters.Length ; i++)
        {
            revertedResult[i] = wordCharacters[(wordCharacters.Length - 1) - i];
        }

        Console.WriteLine(revertedResult);

        return revertedResult;
    }
}