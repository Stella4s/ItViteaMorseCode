using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItViteaMorseCode
{
    public class TranslateMorse
    {

        public TranslateMorse()
        {

        }

        #region static dictionaries
        private static readonly Dictionary<char, string> dictToMorse = new Dictionary<char, string>
        {
            { 'A', ".-" },
            { 'B', "-..." },
            { 'C', "-.-." },
            { 'D', "-.." },
            { 'E', "." },
            { 'F', "..-." },
            { 'G', "--." },
            { 'H', "...." },
            { 'I', ".." },
            { 'J', ".---" },
            { 'K', "-.-" },
            { 'L', ".-.." },
            { 'M', "--" },
            { 'N', "-." },
            { 'O', "---" },
            { 'P', ".--." },
            { 'Q', "--.-" },
            { 'R', ".-." },
            { 'S', "..." },
            { 'T', "-" },
            { 'U', "..-" },
            { 'V', "...-" },
            { 'W', ".--" },
            { 'X', "-..-" },
            { 'Y', "-.--" },
            { 'Z', "--.." },
            { '1', ".----" },
            { '2', "..---" },
            { '3', "...--" },
            { '4', "....-" },
            { '5', "....." },
            { '6', "-...." },
            { '7', "--..." },
            { '8', "---.." },
            { '9', "----." },
            { '0', "-----" },
            { ' ', " " },
        };
        private static readonly Dictionary<string, char> dictFromMorse = new Dictionary<string, char>
        {
            { ".-"      ,'A'},
            { "-..."    ,'B'},
            { "-.-."    ,'C'},
            { "-.."     ,'D'},
            { "."       ,'E'},
            { "..-."    ,'F'},
            { "--."     ,'G'},
            { "...."    ,'H'},
            { ".."      ,'I'},
            { ".---"    ,'J'},
            { "-.-"     ,'K'},
            { ".-.."    ,'L'},
            { "--"      ,'M'},
            { "-."      ,'N'},
            { "---"     ,'O'},
            { ".--."    ,'P'},
            { "--.-"    ,'Q'},
            { ".-."     ,'R'},
            { "..."     ,'S'},
            { "-"       ,'T'},
            { "..-"     ,'U'},
            { "...-"    ,'V'},
            { ".--"     ,'W'},
            { "-..-"    ,'X'},
            { "-.--"    ,'Y'},
            { "--.."    ,'Z'},
            { ".----"   ,'1'},
            { "..---"   ,'2'},
            { "...--"   ,'3'},
            { "....-"   ,'4'},
            { "....."   ,'5'},
            { "-...."   ,'6'},
            { "--..."   ,'7'},
            { "---.."   ,'8'},
            { "----."   ,'9'},
            { "-----"   ,'0'},
            { " "       ,' '},
        };
        #endregion

        public string ToMorse(string input)
        {
            string output = "", value = "";
            //Changes input string to uppercase, then array so it can be used to get dictionary entries.
            char[] charArr = input.ToUpper().ToCharArray();

            //For each char in the array check if there is a key in the dictionary and add that to the output string.
            //If the key can't be found, put # instead for unrecognised char. (To prevent crashing if the user adds unrecognisable characters.)
            foreach (char c in charArr)
            {
                if (dictToMorse.TryGetValue(c, out value))
                    output += value + " ";
                else
                    output += "#" + " ";
            }
            return output;
        }

        public string FromMorse(string input)
        {
            string output = "", value = "";
            return output;
        }
    }
}
