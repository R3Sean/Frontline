using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace Frontline
{
    /// <summary>
    /// String helper. Static Class to Help with String Functions
    /// </summary>
    public static class StringHelper
    {
        
        /// <summary>
        /// Unboxes the parenthesis one group at a time with a regex parsing routine.
        /// </summary>
        /// <returns>The top tier of values.</returns>
        /// <param name="inputString">Input string.</param>
        public static List<string> UnboxParenthesis(string inputString)
        {
            List<string> retList = new List<string>();

			string pattern = @"(?>\w+\.)?\w+\((?>\((?<DEPTH>)|\)(?<-DEPTH>)|[^()]+)*\)(?(DEPTH)(?!))|\w+";
			
			MatchCollection matches = Regex.Matches(inputString, pattern);

			foreach (Match match in matches)
			{
                retList.Add(match.Groups[0].Value);
			}

            return retList;
        }

        /// <summary>
        /// Gets the leader string.  The true value of the array item.
        /// </summary>
        /// <returns>The leader string.</returns>
        /// <param name="nestedStraggler">String with Nested straggler.</param>
        public static string GetLeader(string nestedStraggler)
        {
            return nestedStraggler.Substring(0, nestedStraggler.IndexOf('('));
        }

        /// <summary>
        /// Gets the nested string from an upper tier element.
        /// </summary>
        /// <returns>The nested string.</returns>
        /// <param name="s">The collection in parenthesis</param>
        public static string GetNestedString(string s)
        {
            return s.Substring(s.IndexOf('('), s.Length - s.IndexOf('('));
        }


        /// <summary>
        /// Reverses the words.
        /// </summary>
        /// <returns>The words.</returns>
        /// <param name="words">Words.</param>
		public static string ReverseWords(string words)
		{
			StringBuilder sb = new StringBuilder();
			string[] wordList = words.Split(new char[0]);
			foreach (var word in wordList)
			{
				string cleanWord = Regex.Replace(word, @"[^0-9a-zA-Z]+", String.Empty).ToString();
				List<int> caps = FindCapitalLetterIndexes(cleanWord);
				List<string> letters = GetReversedLettersAsStringList(cleanWord, caps);
				List<int> spec = FindSpecialCharIndexList(word);
				List<string> specChars = FindSpecialChars(word);

				sb.Append(ReverseTheWord(letters, spec, specChars) + " ");

			}

			return sb.ToString().Trim();

		}

		/// <summary>
		/// Reverses the word.
		/// </summary>
		/// <returns>The the word.</returns>
		/// <param name="letterList">Letter list.</param>
		/// <param name="specialCharIndex">Special char index.</param>
		/// <param name="specialCharList">Special char list.</param>
		public static string ReverseTheWord(List<string> letterList, List<int> specialCharIndex, List<string> specialCharList)
		{

			StringBuilder sb = new StringBuilder();

			for (int c = 0; c < specialCharList.Count(); c++)
			{
				if (letterList.Count >= specialCharIndex[c])
				{
					letterList.Insert(specialCharIndex[c], specialCharList[c]);
				}
				else
				{
					letterList.Add(specialCharList[c]);
				}

			}

			foreach (var s in letterList)
			{
				sb.Append(s);
			}
			return sb.ToString();
		}

		/// <summary>
		/// Finds the special chars.
		/// </summary>
		/// <returns>The special chars.</returns>
		/// <param name="word">Word.</param>
		public static List<string> FindSpecialChars(string word)
		{
			List<string> retList = new List<string>();

			foreach (var c in Regex.Matches(word, ".{1}").Cast<Match>().Select(match => match.Value).ToList())
			{
				if (!Char.IsLetterOrDigit(Convert.ToChar(c)))
				{
					retList.Add(c);
				}

			}

			return retList;
		}

		/// <summary>
		/// Finds the special char index list.
		/// </summary>
		/// <returns>The special char index list.</returns>
		/// <param name="word">Word.</param>
		public static List<int> FindSpecialCharIndexList(string word)
		{
			List<int> retList = new List<int>();
			for (int i = 0; i < word.Length; i++)
			{
				if (!Char.IsLetterOrDigit(word[i]))
				{
					retList.Add(i);
				}
			}

			return retList;

		}

		



		/// <summary>
		/// Finds the capital letter indexes.
		/// </summary>
		/// <returns>The capital letter indexes.</returns>
		/// <param name="word">Word.</param>
		public static List<int> FindCapitalLetterIndexes(string word)
        {
            List<int> retList = new List<int>();
            for (int i = 0; i < word.Length; i++)
            {
                if(Char.IsUpper(word[i]) && Char.IsLetterOrDigit(word[i]))
                {
                    retList.Add(i);
                }
            }

            return retList;
        }

        /// <summary>
        /// Gets the reversed letters as string list.
        /// </summary>
        /// <returns>The reversed letters as string list.</returns>
        /// <param name="word">Word.</param>
        /// <param name="capsIndex">Caps index.</param>
        public static List<string> GetReversedLettersAsStringList(string word, List<int> capsIndex)
        {
            List<string> retList = new List<string>();

            char[] revWord = word.ToCharArray();
            Array.Reverse(revWord);
            for (int i = 0; i <= revWord.GetUpperBound(0); i++)
            {
				if (capsIndex.Contains(i))
				{
					retList.Add(revWord[i].ToString().ToUpper());
				}
				else
				{
					retList.Add(revWord[i].ToString().ToLower());
				}
            }
                    

            return retList;
        }





    }
}
