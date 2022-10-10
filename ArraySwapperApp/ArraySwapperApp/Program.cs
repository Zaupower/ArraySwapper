class Program
{
    static void Main(string[] args)
    {
        String word = "";
        
        Console.WriteLine("Please input sequence, ex: 12345 or qwerty");
        word = Console.ReadLine();

        if (word != null)
        {
            char[] revertedWord;
            revertedWord =  ispalidrome(word);
            string wordSplit = String.Join(",", word.ToCharArray());
            string revertSplit = String.Join(",", revertedWord);
            
            Console.WriteLine("(" + String.Join(",", wordSplit) + ")" + " => (" +  String.Join(",", revertSplit) + ")");
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
        return revertedResult;
    }
}