//Jeremy Lapham
// 10-17-22
//Hello World but with GitHub
//This project will ask the user their name and ask them their mood 
//Peer Reviwed By:


bool trueName = true;
bool correctName = true;
int justForNumber = 0;

while (trueName == true)
{
Console.WriteLine("Hello, What is your name?");
string yourName = Console.ReadLine();
correctName = Int32.TryParse(yourName, out justForNumber);
if(correctName == true)
{
    Console.WriteLine("Man put in a name not a number.");
}
else 
{
Console.WriteLine("Hello, " + yourName + " How are you doing? Good, Bad, or Meh?");
string feeling = Console.ReadLine().ToLower();
    if (feeling == "good")
    { 
        Console.WriteLine("That's great to hear!");
    }
    else if(feeling == "bad")
    {
        Console.WriteLine("Thats unfortante");
    }
    else if (feeling == "meh")
    {
        Console.WriteLine("same, it happens though");
    }
    else
    {
        Console.WriteLine("Man that wasn't one of the options I gave you");
    }
}

Console.WriteLine("Do you want to play again? Type End to stop or type in anything to play again.");
yourName = Console.ReadLine().ToLower();
if (yourName == "end")
{
    trueName = false;
}

}

Console.WriteLine("Thank you for playing!");