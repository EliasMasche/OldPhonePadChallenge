using System.Text;

namespace OldPhonePadChallenge;

public class PhonePad
{
    static void Main(string[] args)
    {
        Console.WriteLine(OldPhonePad("33#"));
        Console.WriteLine(OldPhonePad("227*#"));
        Console.WriteLine(OldPhonePad("4433555 555666#"));
        Console.WriteLine(OldPhonePad("8 88777444666*664#"));
        Console.WriteLine(OldPhonePad("4433555 555666#"));
    }
    
    /// <summary>
    /// Converts the numerical input of an old phone pad into a text message as typed 
    /// emulating the behavior of an old phone pad.
    /// </summary>
    /// <param name="input">PhonePad input string.</param>
    /// <returns>Message output from PhonePad as String.</returns>
    public static String OldPhonePad(string input)
    {
        if(string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            return "Invalid input";

        StringBuilder result = new();
        Dictionary<char, string> dictionary = new() {
            {'1', "&')"},
            {'2', "ABC"},
            {'3', "DEF"},
            {'4', "GHI"},
            {'5', "JKL"},
            {'6', "MNO"},
            {'7', "PQRS"},
            {'8', "TUV"},
            {'9', "WXYZ"},
            {'0', " "}
        };
        var count = 0;
        var lastChar = '\0';

        for (int i = 0; i < input.Length; i++)
        {
            var actualChar = input[i];
            if (actualChar.Equals('#'))
                break;
            if (input[i + 1].Equals('*'))
            {
                input = input.Remove(i, 2);
                continue;
            }
            if (actualChar.Equals(' ') || !actualChar.Equals(lastChar))
            {
                CheckMapping(count, dictionary, lastChar, result);
                count = 0;
                lastChar = '\0';
            }
            if (actualChar ==lastChar && count <= 3)
            {
                count++;
            }
            else
            {
                CheckMapping(count, dictionary, lastChar, result);
                count = 1;
                lastChar = actualChar;
            }
        }

        CheckMapping(count, dictionary, lastChar, result);
        
        return result.ToString();
    }

    /// <summary>
    /// Internal Usage 
    /// Checks for a mapped character from a dictionary to the result based on the provided count and last letter.
    /// <param name="count">The count used to calculate the character index.</param>
    /// <param name="dictionary">A dictionary for mapping the characters to strings of possible values.</param>
    /// <param name="lastLetter">The character used to retrieve and compare with a corresponding string from the dictionary.</param>
    /// <param name="result">The parameter of type StringBuilder to which the selected character will be appended.</param>
    /// </summary>
    private static void CheckMapping(int count, Dictionary<char, string> dictionary, 
        char lastLetter, StringBuilder result)
    {
        if (count <= 0 || !dictionary.TryGetValue(lastLetter, out var letters)) return;
        if (letters != "")
        {
            result.Append(letters[( count - 1 ) % letters.Length]);
        }
    }
}
