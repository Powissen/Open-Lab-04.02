using System;

namespace Open_Lab_04._02
{
    public class Doubler
    {
        public string DoubleChar(string original)
        {
            string output = "";
            for (int letter = 0; letter < original.Length; letter++)
            {
                output += original[letter] + original[letter].ToString();
            }
            return output;
        }
    }
}
