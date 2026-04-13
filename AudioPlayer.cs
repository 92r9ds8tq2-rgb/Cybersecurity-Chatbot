using System;

namespace CyberSecurityChatbot
{
public class ResponseHandler
{
public static string GetResponse(string? input, string? name)
{
// Prevent null
input = input ?? "";

// Convert to lowercase safely
input = input.ToLower();

// Basic responses
if (input.Contains("hello") || input.Contains("hi"))
{
return $"Hello {name}! How can I assist you with cybersecurity today?";
}
else if (input.Contains("password"))
{
return "Use strong passwords with a mix of letters, numbers, and symbols.";
}
else if (input.Contains("phishing"))
{
return "Be cautious of suspicious emails and never click unknown links.";
}
else if (input.Contains("malware"))
{
return "Install antivirus software and avoid downloading untrusted files.";
}
else if (input.Contains("bye"))
{
return $"Goodbye {name}! Stay safe online.";
}

return "I'm not sure how to respond to that. Try asking about cybersecurity topics.";
}
}
}
