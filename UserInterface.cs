#pragma warning disable CA1416
using System;

namespace CyberSecurityChatbot
{
    public class UserInterface
    {
        public static void ShowLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("===========================================");
            Console.WriteLine("   🔐 CYBERSECURITY AWARENESS BOT 🔐");
            Console.WriteLine("===========================================");
            Console.ResetColor();
        }

        public static void Divider()
        {
            Console.WriteLine("-------------------------------------------");
        }
    }
}
