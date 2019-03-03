/// <summary>
/// Problem Statement :  Sequence that reads the same backward as forward
/// Examples : MADAM, CIVIC
/// </summary>

namespace AlgonDS
{
    public class Palindrome
    {
        //option 3
        public bool IsWordPalindrome(string word)
        {
            if (string.IsNullOrEmpty(word)) return true;

            word = word.ToLower().Trim();

            var r2l = word.Length - 1;
            var l2r = 0;

            for (int i = 0; i < word.Length; i++)
            {
                if (r2l <= l2r) return true;

                if (word[r2l] != word[l2r])
                    return false;

                r2l--;
                l2r++;
            }

            return true;

        }

        //option 2
        //public bool IsWordPalindrome(string word)
        //{
        //    if (string.IsNullOrEmpty(word)) return true;

        //    word = word.ToLower().Trim();

        //    var reversedString = (new ReverseString()).ReverseMe(word);

        //    if (reversedString == word)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        ////Option 1
        //public bool IsWordPalindrome(string word)
        //{

        //    if (string.IsNullOrEmpty(word)) return true;

        //    word = word.ToLower().Trim();

        //    var reversedString = (new ReverseString()).ReverseMe(word);

        //    if (reversedString.Equals(word))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
