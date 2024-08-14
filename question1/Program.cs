//TUTORIAL SHEET 1


/////////////////////////////// QUESTION1 /////////////////////////////////////////////////

// using System;

// class Program
// {
//     static void Main()
//     {

//         Console.Write("Enter your first name: ");
//         string firstName = Console.ReadLine();

//         Console.Write("Enter your last name: ");
//         string lastName = Console.ReadLine();

//         Console.Write("Enter your age: ");
//         int age = int.Parse(Console.ReadLine());

//         string fullName = firstName + " " + lastName;

//         int yearsUntil100 = 100 - age;
//         Console.WriteLine($"Hello, {fullName}. You will turn 100 in {yearsUntil100} .");
//     }
// }



///////////////////////////////// QUESTION 2  //////////////////////////////////////////////////
///////////////////////////////// QUESTION 2 ///////////////////////////////////////////////////

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter a word: ");
//         string word = Console.ReadLine();

//         for (int i = 0; i < word.Length; i++)
//         {
//             Console.WriteLine($"Character {i + 1}: {word[i]}");
//         }
//     }
// }


///////////////////////////////// QUESTION 3  //////////////////////////////////////////////////
///////////////////////////////// QUESTION 3 ///////////////////////////////////////////////////

// using System;

// class Program
// {
//     static void Main()
//     {

//         Console.Write("Enter the first string: ");
//         string firstString = Console.ReadLine();

//         Console.Write("Enter the second string: ");
//         string secondString = Console.ReadLine();

//         // Compare the two strings, ignoring case
//         if (string.Equals(firstString, secondString, StringComparison.OrdinalIgnoreCase))
//         {
//             Console.WriteLine("The strings are equal.");
//         }
//         else
//         {
//             Console.WriteLine("The strings are not equal.");
//         }
//     }
// }


///////////////////////////////// QUESTION 4  //////////////////////////////////////////////////
///////////////////////////////// QUESTION 4  //////////////////////////////////////////////////

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Ask the user for the radius of the circle
//         Console.Write("Enter the radius of the circle: ");
//         double radius = Convert.ToDouble(Console.ReadLine());

//         // Calculate the area and circumference of the circle
//         double area = Math.PI * Math.Pow(radius, 2);
//         double circumference = 2 * Math.PI * radius;

//         // Display the results using string interpolation
//         Console.WriteLine($"For a circle with radius {radius}, Area: {area:F2}, Circumference: {circumference:F2}");
//     }
// }

///////////////////////////////// QUESTION 5  //////////////////////////////////////////////////
///////////////////////////////// QUESTION 5  //////////////////////////////////////////////////

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter a sentence: ");
//         string sentence = Console.ReadLine();

//         string firstWord = sentence.Split(' ')[0];

//         int vowelCount = 0;
//         string vowels = "aeiouAEIOU";

//         foreach (char c in firstWord)
//         {
//             if (vowels.Contains(c))
//             {
//                 vowelCount++;
//             }
//         }

//         Console.WriteLine($"The first word is '{firstWord}', which contains {vowelCount} vowels.");
//     }
// }


///////////////////////////////// QUESTION 6  //////////////////////////////////////////////////
///////////////////////////////// QUESTION 6  //////////////////////////////////////////////////

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter a string: ");
//         string inputString = Console.ReadLine();

//         char[] charArray = inputString.ToCharArray();
//         Array.Reverse(charArray);
//         string reversedString = new string(charArray);

//         bool isPalindrome = string.Equals(inputString, reversedString, StringComparison.OrdinalIgnoreCase);

//         Console.WriteLine($"Reversed String: {reversedString}");

//         if (isPalindrome)
//         {
//             Console.WriteLine("The string is a palindrome.");
//         }
//         else
//         {
//             Console.WriteLine("The string is not a palindrome.");
//         }
//     }
// }


///////////////////////////////// QUESTION 7  //////////////////////////////////////////////////
///////////////////////////////// QUESTION 7  //////////////////////////////////////////////////


// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter a string: ");
//         string inputString = Console.ReadLine();

//         // Create a dictionary to store the frequency of each character
//         Dictionary<char, int> charFrequencies = new Dictionary<char, int>();

//         // Count the frequency of each character in the string
//         foreach (char c in inputString)
//         {
//             if (charFrequencies.ContainsKey(c))
//             {
//                 charFrequencies[c]++;
//             }
//             else
//             {
//                 charFrequencies[c] = 1;
//             }
//         }

//         Console.WriteLine("Character frequencies:");
//         foreach (KeyValuePair<char, int> entry in charFrequencies)
//         {
//             Console.WriteLine($"{entry.Key}: {entry.Value}");
//         }
//     }
// }


///////////////////////////////// QUESTION 8 //////////////////////////////////////////////////
///////////////////////////////// QUESTION 8 //////////////////////////////////////////////////

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Ask the user for their birthdate
//         Console.Write("Enter your birthdate (YYYY-MM-DD): ");
//         string inputDate = Console.ReadLine();

//         try
//         {
//             // Parse the input string to a DateTime object
//             DateTime birthdate = DateTime.ParseExact(inputDate, "yyyy-MM-dd", null);

//             // Calculate the number of days lived
//             DateTime today = DateTime.Today;
//             TimeSpan ageSpan = today - birthdate;
//             int daysLived = (int)ageSpan.TotalDays;

//             // Display the result using string formatting
//             Console.WriteLine($"You have lived {daysLived} days.");
//         }
//         catch (FormatException)
//         {
//             Console.WriteLine("The format of the date is incorrect. Please use YYYY-MM-DD.");
//         }
//     }
// }


///////////////////////////////// QUESTION 9 //////////////////////////////////////////////////
///////////////////////////////// QUESTION 9 //////////////////////////////////////////////////

// using System;
// using System.Globalization;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter a sentence: ");
//         string sentence = Console.ReadLine();

//         // Capitalize the first letter of each word
//         TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
//         string capitalizedSentence = textInfo.ToTitleCase(sentence.ToLower());

//         Console.WriteLine($"Capitalized Sentence: {capitalizedSentence}");
//     }
// }


///////////////////////////////// QUESTION 10 //////////////////////////////////////////////////
///////////////////////////////// QUESTION 10 //////////////////////////////////////////////////
///
// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter a sentence: ");
//         string sentence = Console.ReadLine();

//         // Split the sentence into individual words
//         string[] words = sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

//         Console.WriteLine($"Number of words: {words.Length}");

//         for (int i = 0; i < words.Length; i++)
//         {
//             Console.WriteLine($"Word {i + 1}: {words[i]}");
//         }
//     }
// }

///////////////////////////////// QUESTION 11 //////////////////////////////////////////////////
///////////////////////////////// QUESTION 11 //////////////////////////////////////////////////

// using System;
// using System.Linq;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter the first string: ");
//         string firstString = Console.ReadLine();

//         Console.Write("Enter the second string: ");
//         string secondString = Console.ReadLine();

//         // Normalize the strings: remove spaces and convert to lowercase
//         string normalizedFirstString = new string(firstString.Where(c => !char.IsWhiteSpace(c)).ToArray()).ToLower();
//         string normalizedSecondString = new string(secondString.Where(c => !char.IsWhiteSpace(c)).ToArray()).ToLower();

//         // Check if the normalized strings are anagrams
//         bool areAnagrams = AreAnagrams(normalizedFirstString, normalizedSecondString);

//         if (areAnagrams)
//         {
//             Console.WriteLine("The strings are anagrams.");
//         }
//         else
//         {
//             Console.WriteLine("The strings are not anagrams.");
//         }
//     }

//     static bool AreAnagrams(string str1, string str2)
//     {
//         if (str1.Length != str2.Length)
//         {
//             return false;
//         }

//         // Sort both strings and compare
//         char[] str1Array = str1.ToCharArray();
//         char[] str2Array = str2.ToCharArray();
//         Array.Sort(str1Array);
//         Array.Sort(str2Array);

//         return str1Array.SequenceEqual(str2Array);
//     }
// }

///////////////////////////////// QUESTION 12 //////////////////////////////////////////////////
///////////////////////////////// QUESTION 12 //////////////////////////////////////////////////

// using System;
// using System.Text;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter a string: ");
//         string inputString = Console.ReadLine();

//         // Compress the string
//         string compressedString = CompressString(inputString);
//         Console.WriteLine($"Compressed String: {compressedString}");
//     }

//     static string CompressString(string str)
//     {
//         if (string.IsNullOrEmpty(str))
//         {
//             return str;
//         }

//         StringBuilder compressed = new StringBuilder();
//         int count = 1;

//         for (int i = 1; i < str.Length; i++)
//         {
//             if (str[i] == str[i - 1])
//             {
//                 count++;
//             }
//             else
//             {
//                 compressed.Append(str[i - 1]);
//                 compressed.Append(count);
//                 count = 1;
//             }
//         }

//         // Append the last character and its count
//         compressed.Append(str[str.Length - 1]);
//         compressed.Append(count);

//         // Return the compressed string if it's smaller; otherwise, return the original string
//         return compressed.Length < str.Length ? compressed.ToString() : str;
//     }
// }

///////////////////////////////// QUESTION 13 //////////////////////////////////////////////////
///////////////////////////////// QUESTION 13 //////////////////////////////////////////////////

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter 'e' to encrypt or 'd' to decrypt: ");
//         char action = Console.ReadLine()[0];

//         Console.Write("Enter a string: ");
//         string inputString = Console.ReadLine();
//         Console.Write("Enter shift amount: ");
//         int shiftAmount = int.Parse(Console.ReadLine());

//         // Perform the requested action
//         string result;
//         if (action == 'e')
//         {
//             result = CaesarCipher(inputString, shiftAmount);
//             Console.WriteLine($"Encrypted String: {result}");
//         }
//         else if (action == 'd')
//         {
//             result = CaesarCipher(inputString, -shiftAmount);
//             Console.WriteLine($"Decrypted String: {result}");
//         }
//         else
//         {
//             Console.WriteLine("Invalid action. Please enter 'e' or 'd'.");
//         }
//     }

//     static string CaesarCipher(string str, int shift)
//     {
//         shift = shift % 26; // Normalize shift to stay within 0-25
//         char[] buffer = str.ToCharArray();
        
//         for (int i = 0; i < buffer.Length; i++)
//         {
//             char ch = buffer[i];

//             if (char.IsLetter(ch))
//             {
//                 char offset = char.IsUpper(ch) ? 'A' : 'a';
//                 buffer[i] = (char)(((ch + shift - offset) % 26 + 26) % 26 + offset);
//             }
//         }

//         return new string(buffer);
//     }
// }


///////////////////////////////// QUESTION 14 //////////////////////////////////////////////////
///////////////////////////////// QUESTION 14 //////////////////////////////////////////////////

// using System;
// using System.Collections.Generic;
// using System.Linq;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter a sentence: ");
//         string sentence = Console.ReadLine();

//         // Find the longest word
//         List<string> longestWords = FindLongestWords(sentence);
//         Console.WriteLine($"Longest word(s): {string.Join(", ", longestWords)}");
//     }

//     static List<string> FindLongestWords(string sentence)
//     {
//         if (string.IsNullOrWhiteSpace(sentence))
//         {
//             return new List<string>();
//         }

//         // Split the sentence into words
//         string[] words = sentence.Split(new[] { ' ', ',', '.', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

//         // Find the length of the longest word
//         int maxLength = words.Max(word => word.Length);

//         // Find all words with the maximum length
//         var longestWords = words.Where(word => word.Length == maxLength).ToList();

//         return longestWords;
//     }
// }



///////////////////////////////// QUESTION 15 //////////////////////////////////////////////////
///////////////////////////////// QUESTION 15 //////////////////////////////////////////////////

// using System;
// using System.Linq;

// class Program
// {
//     static void Main()
//     {
//         // Ask the user to enter a sentence
//         Console.Write("Enter a sentence: ");
//         string inputSentence = Console.ReadLine();

//         // Check if the sentence is a palindrome
//         bool isPalindrome = IsPalindrome(inputSentence);

//         // Display the result
//         if (isPalindrome)
//         {
//             Console.WriteLine("The sentence is a palindrome.");
//         }
//         else
//         {
//             Console.WriteLine("The sentence is not a palindrome.");
//         }
//     }

//     static bool IsPalindrome(string sentence)
//     {
//         if (string.IsNullOrWhiteSpace(sentence))
//         {
//             return false;
//         }

//         // Remove non-alphanumeric characters and convert to lowercase
//         string cleanedSentence = new string(sentence
//             .Where(c => char.IsLetterOrDigit(c))
//             .Select(c => char.ToLower(c))
//             .ToArray());

//         // Check if the cleaned sentence is a palindrome
//         string reversedSentence = new string(cleanedSentence.Reverse().ToArray());
//         return cleanedSentence == reversedSentence;
//     }
// }


///////////////////////////////// QUESTION 16 //////////////////////////////////////////////////
///////////////////////////////// QUESTION 16 //////////////////////////////////////////////////

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         // Ask the user to enter a string
//         Console.Write("Enter a string: ");
//         string inputString = Console.ReadLine();

//         // Generate permutations
//         var permutations = GetPermutations(inputString);

//         // Display the permutations
//         Console.WriteLine("Permutations:");
//         foreach (var permutation in permutations)
//         {
//             Console.WriteLine(permutation);
//         }
//     }

//     static IEnumerable<string> GetPermutations(string str)
//     {
//         // Convert the string to a character array
//         char[] array = str.ToCharArray();
//         return Permute(array, 0, array.Length - 1);
//     }

//     static IEnumerable<string> Permute(char[] array, int start, int end)
//     {
//         if (start == end)
//         {
//             yield return new string(array);
//         }
//         else
//         {
//             for (int i = start; i <= end; i++)
//             {
//                 Swap(array, start, i);
//                 foreach (var perm in Permute(array, start + 1, end))
//                 {
//                     yield return perm;
//                 }
//                 Swap(array, start, i); // backtrack
//             }
//         }
//     }

//     static void Swap(char[] array, int i, int j)
//     {
//         char temp = array[i];
//         array[i] = array[j];
//         array[j] = temp;
//     }
// }

///////////////////////////////// QUESTION 17 //////////////////////////////////////////////////
///////////////////////////////// QUESTION 17 //////////////////////////////////////////////////

// using System;
// using System.Text.RegularExpressions;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter a password: ");
//         string password = Console.ReadLine();

//         // Evaluate the strength of the password
//         string strength = EvaluatePasswordStrength(password);
//         Console.WriteLine($"Password Strength: {strength}");
//     }

//     static string EvaluatePasswordStrength(string password)
//     {
//         if (string.IsNullOrEmpty(password))
//         {
//             return "Invalid";
//         }

//         bool hasUpperCase = Regex.IsMatch(password, "[A-Z]");
//         bool hasLowerCase = Regex.IsMatch(password, "[a-z]");
//         bool hasDigit = Regex.IsMatch(password, "[0-9]");
//         bool hasSpecialChar = Regex.IsMatch(password, "[^a-zA-Z0-9]");
//         bool isLongEnough = password.Length >= 8;

//         // Evaluate password strength based on conditions
//         if (isLongEnough && hasUpperCase && hasLowerCase && hasDigit && hasSpecialChar)
//         {
//             return "Strong";
//         }
//         else if (isLongEnough && (hasUpperCase || hasLowerCase) && (hasDigit || hasSpecialChar))
//         {
//             return "Moderate";
//         }
//         else
//         {
//             return "Weak";
//         }
//     }
// }

///////////////////////////////// QUESTION 18 //////////////////////////////////////////////////
///////////////////////////////// QUESTION 18 //////////////////////////////////////////////////

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter the main string: ");
//         string mainString = Console.ReadLine();

//         Console.Write("Enter the substring to find: ");
//         string substringToFind = Console.ReadLine();

//         Console.Write("Enter the substring to replace it with: ");
//         string substringToReplaceWith = Console.ReadLine();

//         // Replace all occurrences of the substring
//         string resultString = ReplaceSubstring(mainString, substringToFind, substringToReplaceWith);

//         Console.WriteLine($"Resulting String: {resultString}");
//     }

//     static string ReplaceSubstring(string input, string find, string replace)
//     {
//         // Use the String.Replace method to replace all occurrences of the substring
//         return input.Replace(find, replace);
//     }
// }


///////////////////////////////// QUESTION 19 //////////////////////////////////////////////////
///////////////////////////////// QUESTION 19 //////////////////////////////////////////////////


// using System;

// class Program
// {
//     static void Main()
//     {
//         // Ask the user to enter a sentence
//         Console.Write("Enter a sentence: ");
//         string sentence = Console.ReadLine();

//         // Reverse the order of words
//         string reversedSentence = ReverseWords(sentence);

//         // Display the reversed sentence
//         Console.WriteLine($"Reversed Sentence: {reversedSentence}");
//     }

//     static string ReverseWords(string sentence)
//     {
//         // Split the sentence into words
//         string[] words = sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

//         // Reverse the order of words
//         Array.Reverse(words);

//         // Join the words back into a single string
//         return string.Join(" ", words);
//     }
// }


///////////////////////////////// QUESTION 20 //////////////////////////////////////////////////
///////////////////////////////// QUESTION 20 //////////////////////////////////////////////////

// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Enter the number: ");
//         string number = Console.ReadLine().ToUpper();

//         Console.Write("Enter the current base (2 for binary, 8 for octal, 16 for hexadecimal): ");
//         int currentBase = int.Parse(Console.ReadLine());

//         Console.Write("Enter the desired base (10 for decimal, 8 for octal, 16 for hexadecimal): ");
//         int desiredBase = int.Parse(Console.ReadLine());

//         try
//         {
//             // Convert the number from the current base to decimal
//             int decimalNumber = Convert.ToInt32(number, currentBase);

//             // Convert the decimal number to the desired base
//             string convertedNumber = ConvertToBase(decimalNumber, desiredBase);

//             // Display the converted number
//             Console.WriteLine($"Converted Number: {convertedNumber}");
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine($"Error: {ex.Message}");
//         }
//     }

//     static string ConvertToBase(int number, int baseValue)
//     {
//         if (baseValue == 10)
//         {
//             return number.ToString();
//         }

//         const string chars = "0123456789ABCDEF";
//         string result = string.Empty;

//         while (number > 0)
//         {
//             result = chars[number % baseValue] + result;
//             number /= baseValue;
//         }

//         return string.IsNullOrEmpty(result) ? "0" : result;
//     }
// }
