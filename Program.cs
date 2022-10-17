//Jeremy Lapham
// 10-17-22
//Hello World but with GitHub
//This project will ask the user 

Console.WriteLine("Hello, What is your name? Or type in end to stop playing");
string yourName = Console.ReadLine();
while(yourName != "end" )
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
Console.WriteLine("Type in your name or type end to stop.");
yourName = Console.ReadLine();
}
Console.WriteLine("Thank you for playing!");