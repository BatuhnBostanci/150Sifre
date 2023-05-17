using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _150Sifre
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            Random random = new Random();
            char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();

            using (StreamWriter streamWriter = new StreamWriter(@"C:\Users\bbostanci\Desktop\passwords.txt"))//desktop
            {
                for (int i = 0; i < 150; i++)
                {
                    string password = "";
                    for (int j = 0; j < 4; j++)
                    {
                        if (j % 2 == 0)
                        {
                            password += chars[random.Next(52)].ToString();
                        }
                        else
                        {
                            password += random.Next(0, 9).ToString();
                        }
                    }
                    streamWriter.WriteLine(password);
                }
            }
            Console.WriteLine("Masaüstüne 'passwords.txt' dosyasına");
            Console.ReadLine();
            







            /*
            var random = new Random();
            const int passwordLength = 4;
            const int numberOfPasswords = 150;
            const string allowedChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var passwords = new char[numberOfPasswords][];

            for (int i = 0; i < numberOfPasswords; i++)
            {
                passwords[i] = new char[passwordLength];
                for (int j = 0; j < passwordLength; j++)
                {
                    passwords[i][j] = allowedChars[random.Next(0, allowedChars.Length)];
                }
            }

            

            using (StreamWriter writer = new StreamWriter(@"C:\Users\bbostanci\Desktop\passwords.txt"))
            {
                foreach (var password in passwords)
                {   
                   writer.WriteLine(password);
                }
            }

            Console.WriteLine("Şifreler masaüstüne kaydedildi.");
            Console.ReadLine();
            */
        }
    }
}
