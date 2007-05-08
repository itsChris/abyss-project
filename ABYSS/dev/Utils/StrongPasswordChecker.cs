using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Utils {
    public class StrongPasswordChecker {
        #region Enumeration
        public enum StrongPassword {
            Weak,
            Ok,
            Good,
            Perfect
        }
        #endregion

        #region Static Methods
        public static StrongPassword CheckEffectiveBitSize(string Password) {
            StrongPassword passStrength = new StrongPassword();
            int charSet = 0;
            charSet = GetCharSetUsed(Password);
            double result = Math.Log(Math.Pow(charSet, Password.Length)) / Math.Log(2);
            if (result <= 32) {
                passStrength = StrongPassword.Weak;
            }
            else if (result <= 64) {
                passStrength = StrongPassword.Ok;
            }
            else if (result <= 128) {
                passStrength = StrongPassword.Good;
            }
            else if (result > 128) {
                passStrength = StrongPassword.Perfect;
            }
            return passStrength;
        }

        private static int GetCharSetUsed(string pass) {
            int ret = 0;
            if (ContainsLowerCaseChars(pass)) {
                ret += 10;
            }

            if (ContainsUpperCaseChars(pass)) {
                ret += 10;
            }

            if (ContainsNumbers(pass)) {
                ret += 50;
            }

            if (ContainsSpecialCharacters(pass)) {
                ret += 50;
            }
            return ret;
        }
        
        private static bool ContainsNumbers(string str) {
            Regex pattern = new Regex(@"^.*(?=.{8,})(?=.*\d)");
            return pattern.IsMatch(str);
        }

        private static bool ContainsLowerCaseChars(string str) {
            Regex pattern = new Regex(@"^.*(?=.{8,})(?=.*[a-z])");
            return pattern.IsMatch(str);
        }

        private static bool ContainsUpperCaseChars(string str) {
            Regex pattern = new Regex(@"^.*(?=.{8,})(?=.*[A-Z])");
            return pattern.IsMatch(str);
        }

        private static bool ContainsSpecialCharacters(string str) {
            Regex pattern = new Regex(@"^.*(?=.{8,})(?=.*[@#$%^&+=])");
            return pattern.IsMatch(str);
        }
        #endregion
    }
}
