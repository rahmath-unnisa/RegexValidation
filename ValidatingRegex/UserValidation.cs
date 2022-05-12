﻿using System.Text.RegularExpressions;

namespace ValidatingRegex
{
    public class UserValidation
    {
        public const string FIRSTNAME_REGEX = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public const string LASTNAME_REGEX = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public static string EMAIL_REGEX = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
        public static string MOBILENUMBER_REGEX = "^[6-9]{1}[0-9]{9}$";
        const string PASSWORD_REGEX = "^[A-Z]{1, }[a-z]{8, }$";
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
        public string LastName(string lastname)
        {
            if (Regex.IsMatch(lastname, LASTNAME_REGEX))
            {
                Console.WriteLine("Last Name Matches");
            }
            else
            {
                Console.WriteLine("Verify Last Name Again");
            }
            return lastname;
        }
        public string EmailValidation(string email)
        {
            if (Regex.IsMatch(email, EMAIL_REGEX))
            {
                Console.WriteLine("Email Name Matches");
            }
            else
            {
                Console.WriteLine("Verify Email Again");
            }
            return email;
        }
        public string ValidateMobileNumber(string mobilenumber)
        {
            if (Regex.IsMatch(mobilenumber, MOBILENUMBER_REGEX))
            {
                Console.WriteLine("Mobile Number Matches");
            }
            else
            {
                Console.WriteLine("Verify Mobile Number Again");
            }
            return mobilenumber;
        }
        public string PasswordValidation(string password)
        {
            if (Regex.IsMatch(password, PASSWORD_REGEX))
            {
                Console.WriteLine("Password Matches");
            }
            else
            {
                Console.WriteLine("Verify Password Again");
            }
            return password;
        }
    }
}