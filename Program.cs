using System.Linq;
string news = "News";
string onews = news + "news";

int keypass = 3949; // password
Console.WriteLine("Please enter the password.");

string userkey = Console.ReadLine(); // user input command line
int userkeyint = Convert.ToInt32(userkey);

if (userkeyint == keypass)
{
    Console.WriteLine("you've entered the password.");
    System.Threading.Thread.Sleep(2000);
    Console.WriteLine("Press Enter to Continue.");
}
else
{
    Console.WriteLine("The password you entered was incorrect.");

    System.Threading.Thread.Sleep(2000);
    Console.WriteLine("Press Enter to close the Terminal.");
}

var pressenter = Console.ReadLine();
Console.Clear();

Console.WriteLine("What would you like to do?");

string inputprompt1 = Console.ReadLine();

if (inputprompt1.Contains(onews))
{
    Console.WriteLine("Here is the latest news-");
}
else
{
    Console.WriteLine("would you like to read the news?");
}
Console.ReadKey();