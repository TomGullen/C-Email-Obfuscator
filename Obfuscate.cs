/// <summary>
/// Obfuscate email address into HTML
/// https://github.com/TomGullen/C-Email-Obfuscator
/// </summary>
public static string ObfuscateEmailAddress(string email)
{
    string reversedEmail;
    {
        var charArray = email.ToCharArray();
        Array.Reverse(charArray);
        reversedEmail = new string(charArray);
    }

    // Insert hidden text
    var atIndex = reversedEmail.IndexOf("@", StringComparison.CurrentCulture);
    if (atIndex != -1)
    {
        var leftPart = reversedEmail.Substring(0, atIndex);
        var rightPart = reversedEmail.Substring(atIndex);

        string randomString;
        {
            const string chars = "abcsdefghijklmnopqrstuvwxyz";
            var stringChars = new char[3];
            var random = new Random();
            for (var i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            randomString = new string(stringChars);
        }

        reversedEmail = leftPart + "<span style=\"display:none\">" + randomString + "</span>" + rightPart;
    }

    // Replace some chars with HTML entities
    {
        reversedEmail = reversedEmail.Replace("@", "&commat;");
        reversedEmail = reversedEmail.Replace(".", "&#46;");
        reversedEmail = reversedEmail.Replace("+", "&#x0002B;");
        reversedEmail = reversedEmail.Replace("_", "&#x0005F;");
    }

    return "<span class=\"emailAddress\" style=\"unicode-bidi:bidi-override; direction: rtl;\">" + reversedEmail + "</span>";
}
