/// <summary>
/// Given an input string, write a function that returns the Run Length Encoded string for the 
/// input string.
/// “wwwwaaadexxxxxx" => “w4a3d1e1x6”.
/// </summary>

namespace AlgonDS
{
    public class RunLengthEncodingDecoding
    {
        public string Encode(string value)
        {
            var c = value[0];
            var counter = 1;
            var output = string.Empty;
            for (var i = 1; i < value.Length; i++)
            {
                if (c == value[i])
                {
                    counter++;
                }
                else
                {
                    output += c.ToString() + counter.ToString();
                    c = value[i];
                    counter = 1;
                }
            }
            output += c.ToString() + counter.ToString();

            return output;
        }

        public string Decode(string value)
        {
            if (string.IsNullOrEmpty(value) || value.Length == 1) return value;

            var output = string.Empty;
            for (int i = 0; i < value.Length; i+=2)
            {
                output += new string(value[i], (int)char.GetNumericValue(value[i + 1]));
            }

            return output;
        }
    }
}
