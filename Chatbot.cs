using System;

namespace CyberSecurityChatbot
{
public class ChatbotResponseHandler
{
public static string GetResponse(string? input, string? name)
{
input = input ?? "";
input = input.ToLower();

if (input.Contains("hello") || input.Contains("hi"))
{
return $"Hello {name}! How can I help you today?";
}
else if (input.Contains("password"))
{
return "Use strong passwords with a mix of letters, numbers, and symbols.";
}
else if (input.Contains("phishing"))
{
return "Be careful of suspicious emails and never click unknown links.";
}
else if (input.Contains("malware"))
{
return "Install antivirus software and avoid downloading untrusted files.";
}
else if (input.Contains("bye"))
{
return $"Goodbye {name}! Stay safe online.";
}

return "I'm not sure how to respond. Try asking about cybersecurity topics.";
}
}
}