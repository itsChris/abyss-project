using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Abyss_Client {
    public class StrongPasswordChecker {
        public enum StrongPassword {
            Weak,
            Ok,
            Good,
            Perfect
        }
        public static StrongPassword CheckEffectiveBitSize(string Password) {
            int charSet = 0;
            StrongPassword passStrength = new StrongPassword();

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

            if (ContainsNumbers(pass)) {
                ret += 10;
            }

            if (ContainsLowerCaseChars(pass)) {
                ret += 26;
            }

            if (ContainsUpperCaseChars(pass)) {
                ret += 26;
            }

            if (ContainsPunctuation(pass)) {
                ret += 31;
            }

            return ret;
        }

        private static bool ContainsNumbers(string str) {
            Regex pattern = new Regex(@"[\d]");
            return pattern.IsMatch(str);
        }

        private static bool ContainsLowerCaseChars(string str) {
            Regex pattern = new Regex("[a-z]");
            return pattern.IsMatch(str);
        }

        private static bool ContainsUpperCaseChars(string str) {
            Regex pattern = new Regex("[A-Z]");
            return pattern.IsMatch(str);
        }

        private static bool ContainsPunctuation(string str) {
            Regex pattern = new Regex(@"[\W|_]");
            return pattern.IsMatch(str);
        }
    }
}
