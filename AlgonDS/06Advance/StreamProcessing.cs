using System.Diagnostics;
using System.Linq;

/// <summary>
/// https://adventofcode.com/2017/day/9
/// A large stream blocks your path. According to the locals, it's not safe to cross the stream at the moment because it's full of garbage. 
/// You look down at the stream; rather than water, you discover that it's a stream of characters.
/// 
/// You sit for a while and record part of the stream (your puzzle input). The characters represent groups - 
/// sequences that begin with { and end with }. Within a group, there are zero or more other things, separated by commas: 
/// either another group or garbage. Since groups can contain other groups, a } only closes the most-recently-opened unclosed group - 
/// that is, they are nestable. Your puzzle input represents a single, large group which itself contains many smaller ones.
///
///Sometimes, instead of a group, you will find garbage.Garbage begins with<and ends with>.Between those angle brackets, 
///almost any character can appear, including { and }. Within garbage, < has no special meaning.
///
///In a futile attempt to clean up the garbage, some program has canceled some of the characters within it using !: inside garbage, 
///any character that comes after ! should be ignored, including<,>, and even another !.
///
///You don't see any characters that deviate from these rules. Outside garbage, you only find well-formed groups, and garbage always 
///terminates according to the rules above.
/// 
/// Your goal is to find the total score for all groups in your input. Each group is assigned a score 
/// which is one more than the score of the group that immediately contains it. (The outermost group gets a score of 1.)
/// {}, score of 1.
/// {{{}}}, score of 1 + 2 + 3 = 6.
/// {{},{}}, score of 1 + 2 + 2 = 5.
/// {{{},{},{{}}}}, score of 1 + 2 + 3 + 3 + 3 + 4 = 16.
/// {<a>,<a>,<a>,<a>}, score of 1.
/// {{<ab>},{<ab>},{<ab>},{<ab>}}, score of 1 + 2 + 2 + 2 + 2 = 9.
/// {{<!!>},{<!!>},{<!!>},{<!!>}}, score of 1 + 2 + 2 + 2 + 2 = 9.
/// {{<a!>},{<a!>},{<a!>},{<ab>}}, score of 1 + 2 = 3.
/// </summary>

namespace AlgonDS
{
    public class StreamProcessing
    {
        const char GroupOpen = '{';
        const char GroupClose = '}';
        const char GarbageOpen = '<';
        const char GarbageClose = '>';
        const char IgnoreNextChar = '!';

        public int FindTotalScore(string streams)
        {
            var scoreCounter = 0;
            var garbageCounter = 0;
            var ignoreCharCounter = 0;
            var totalScore = 0;

            for (var i = 0; i <= streams.Length - 1; i++)
            {
                switch (streams[i])
                {
                    case GroupOpen:
                        if (garbageCounter > 0 || ignoreCharCounter > 0) break;
                        if (streams.Substring(i).Count(s => s == GroupClose) == 0) break; //no end char "}" 
                        if (streams.Substring(i).Count(s => s == GroupClose) <= scoreCounter) break; //if opening greater than closing then dont count
                                                                                                     //Console.WriteLine("Open Matched");
                        scoreCounter++;
                        break;
                    case GarbageOpen:
                        if (ignoreCharCounter > 0) break;
                        if (streams.Substring(i).Count(s => s == GarbageClose) == 0) break; //no end char ">"
                        if (streams.Substring(i).Count(s => s == GarbageClose) <= garbageCounter) break; //if opening greater than closing then dont count
                                                                                                         //if (streams.Substring(i).Count(s => s==GarbageClose) >= streams.Substring(i).Count(s => s=="!>")) 
                        garbageCounter++;
                        break;
                    case GarbageClose:
                        if (ignoreCharCounter > 0) break;
                        if (garbageCounter > 0) garbageCounter--;
                        if ((streams.Length - 1 > i + 1) && streams.Substring(i + 1).Count(s => s == GarbageClose) == 0) garbageCounter = 0; //if no opening garbaage then make all opening to zero
                        break;
                    case GroupClose:
                        if (garbageCounter > 0 || ignoreCharCounter > 0) break;
                        if (scoreCounter > 0)
                        {
                            totalScore += scoreCounter;
                            scoreCounter--;
                        }
                        break;
                    case IgnoreNextChar:
                        if (ignoreCharCounter > 0) break;
                        ignoreCharCounter += 2;
                        break;
                    default:
                        break;
                }
                if (ignoreCharCounter > 0) ignoreCharCounter--;
            }

            return totalScore;
        }
    }
}
