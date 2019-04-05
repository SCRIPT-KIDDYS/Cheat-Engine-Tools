using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

internal class FreeHacksDecrypt
{
    public static string Decrypt(string cipherText)
    {
        MemoryStream ms = new MemoryStream();
        string EncryptionKey = "ICamYEloBquEntR";
        cipherText = cipherText.Replace(" ", "+");
        byte[] cipherBytes = Convert.FromBase64String(cipherText);
        using (Aes encryptor = Aes.Create())
        {
            Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
                0x48, 0x39, 0x01, 0x19, 0x28, 0x4D, 0xE2, 0x94, 0xD2, 0x33, 0x84, 0x69, 0x0A
            });

            encryptor.Key = pdb.GetBytes(32);
            encryptor.IV = pdb.GetBytes(16);
            using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
            {
                try
                {
                    cs.Write(cipherBytes, 0, cipherBytes.Length);
                    cs.Close();
                }
                catch { }
            }
            cipherText = Encoding.Unicode.GetString(ms.ToArray());
        }
        return cipherText;
    }


    public static string Stringthing(string game, string date, string gamename)
    {
        string final = "";
        string[] strArrayOne = new string[] { "" };
        strArrayOne = CharKey(game).Split(',');
        strArrayOne = strArrayOne.Skip(1).ToArray();
        string[] strResult = strArrayOne.Select(y => string.Concat(y.Reverse())).ToArray();
        string dateandstuff = gamename + " - " + date + Environment.NewLine + Environment.NewLine;

        foreach (var items in strResult)
            final += Encoding.UTF8.GetString(Convert.FromBase64String(items)) + Environment.NewLine;

        return dateandstuff + final;
    }

    public static string DecryptStuff(string fluffy, string gamename)
    {
        string DecryptString = Decrypt(fluffy);
        if (DecryptString.StartsWith("Y"))
        {
            string letsrockandroll = "N" + DecryptString.Substring(DecryptString.IndexOf('@') + 2);
            string Date = letsrockandroll.Split('N', '@')[1];
            string Decoded = letsrockandroll.Replace("@@", ",");
            return Stringthing(Decoded, Date, gamename);
        }
        else
        {
            string letsrockandroll = DecryptString.Substring(1);
            string Date = letsrockandroll.Split('N', '@')[0];
            string Decoded = DecryptString.Replace("@@", ",");
            return Stringthing(Decoded, Date, gamename);
        }
    }

    public static string CharKey(string line)
    {
        string result = "";
        string s = line;
        foreach (char c in s)
            result += (LettersandStuff(18, c));

        return result;
    }

    static char LettersandStuff(int int_0, char stringey)
    {
        char result;
        if (!char.IsLetter(stringey))
            result = stringey;

        else
        {
            char c = char.IsUpper(stringey) ? 'A' : 'a';
            result = (char)(((int)stringey + int_0 - (int)c) % 26 + (int)c);
        }
        return result;
    }
}