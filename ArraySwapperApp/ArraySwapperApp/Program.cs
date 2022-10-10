class Program
{
    static void Main(string[] args)
    {
        string wordInput = userInputString();
        
        Console.WriteLine("Word readed: " + wordInput);
        
        reverseString(wordInput);
    }

    public static String userInputString()
    {
        int arraySizeCounter = 0;
        String readInput = "";
        String tmpRead = "";
        Console.WriteLine("Input characters to swap one by one");
        Console.WriteLine("to start swapping input: swap");

        while (true)
        {
            readInput = Console.ReadLine();
            if (readInput == "swap" && tmpRead.Length > 0)
            {
                return tmpRead;
            }
            tmpRead += readInput;
        }
    }
    
    public static bool reverseString(String word)
    {
        char[] wordCharacters = word.ToCharArray();
        char[] resultReverse = new Char[wordCharacters.Length];
        Console.WriteLine(wordCharacters.Length/2 );
        for (int i = 0; i < wordCharacters.Length/2 ; i++)
        {
            /*
            if (wordCharacters[i] != wordCharacters[ (wordCharacters.Length -1 ) - i] )
            {
                return false;
            }*/

            resultReverse[i] = wordCharacters[(wordCharacters.Length - 1) - i];
        }
        Console.WriteLine(resultReverse);
        return true;
    }
}