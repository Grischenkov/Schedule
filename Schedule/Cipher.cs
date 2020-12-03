namespace Schedule
{
    public static class Cipher
    {
        private const string DefaultAlphabet = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz123456789";
        public static string Encrypt(string plainMessage, string password) => Vigenere(plainMessage, password);

        public static string Decrypt(string encryptedMessage, string password) => Vigenere(encryptedMessage, password, false);
        
        private static string GetRepeatKey(string s, int n)
        {
            var p = s;
            while (p.Length < n)
            {
                p += p;
            }
            return p.Substring(0, n);
        }

        private static string Vigenere(string text, string password, bool encrypting = true)
        {
            var gamma = GetRepeatKey(password, text.Length);
            var retValue = "";
            var q = DefaultAlphabet.Length;

            for (int i = 0; i < text.Length; i++)
            {
                var letterIndex = DefaultAlphabet.IndexOf(text[i]);
                var codeIndex = DefaultAlphabet.IndexOf(gamma[i]);
                if (letterIndex < 0)
                {
                    retValue += text[i].ToString();
                }
                else
                {
                    retValue += DefaultAlphabet[(q + letterIndex + ((encrypting ? 1 : -1) * codeIndex)) % q].ToString();
                }
            }

            return retValue;
        }
    }
}