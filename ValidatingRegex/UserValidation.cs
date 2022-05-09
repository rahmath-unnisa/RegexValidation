using System.Text.RegularExpressions;

namespace ValidatingRegex
{
    public class NameValidation
    {
        public const string FIRSTNAME_REGEX = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public string FirstName(string firstname)
        {
            if (Regex.IsMatch(firstname, FIRSTNAME_REGEX))
            {
                Console.WriteLine("First Name Matches");
            }
            else
            {
                Console.WriteLine("Verify First Name Again");
            }
            return firstname;
        }
    }
}