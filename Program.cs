#pragma warning disable CA1416
using System;

namespace CyberSecurityChatbot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UserInterface.ShowLogo();
            AudioPlayer.PlayGreeting();

            Console.Write("\nEnter your name: ");
            string name = Console.ReadLine() ?? "User";

            UserInterface.Divider();
            Chatbot.StartChat(name);
        }
    }

    public static class AudioPlayer
    {
        public static void PlayGreeting()
        {
            // TODO: Implement audio playback logic here
            Console.WriteLine("Playing greeting audio...");
        }
    }

    public static class Chatbot
    {
        public static void StartChat(string name)
        {
            // TODO: Implement chatbot logic here
            Console.WriteLine("===========================================");
            Console.WriteLine("   🔐 CYBERSECURITY AWARENESS BOT 🔐");
            Console.WriteLine("===========================================");

            Console.WriteLine("-------------------------------------------");
            Console.WriteLine($"Hello, {name}! How can I assist you with cybersecurity today?");

            while (true)
            {
                Console.Write("You: ");
                string input = Console.ReadLine() ?? string.Empty;

                if (string.IsNullOrWhiteSpace(input))
                    continue;

                if (input.ToLower() == "exit")
                {
                    Console.WriteLine("Bot: Stay safe online! Goodbye 👋");
                    break;
                }

                Console.WriteLine("Bot: That's a great question about cybersecurity.");
            }
        }
    }
}