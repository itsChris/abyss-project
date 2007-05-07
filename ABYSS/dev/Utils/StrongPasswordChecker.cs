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
                ret += 15;
            }

            if (ContainsUpperCaseChars(pass)) {
                ret += 25;
            }

            if (ContainsNumbers(pass)) {
                ret += 35;
            }

            if (ContainsSpecialCharacters(pass)) {
                ret += 45;
            }
            return ret;
        }

        private static bool ContainsNumbers(string str) {
            Regex pattern = new Regex(@"^.*(?=.{10,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=]).*$");
            return pattern.IsMatch(str);
        }

        private static bool ContainsLowerCaseChars(string str) {
            Regex pattern = new Regex(@"^.*(?=.{10,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=]).*$");
            return pattern.IsMatch(str);
        }

        private static bool ContainsUpperCaseChars(string str) {
            Regex pattern = new Regex(@"^.*(?=.{10,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=]).*$");
            return pattern.IsMatch(str);
        }

        private static bool ContainsSpecialCharacters(string str) {
            Regex pattern = new Regex(@"^.*(?=.{10,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=]).*$");
            return pattern.IsMatch(str);
        }
        #endregion
    }
}
