// See https://aka.ms/new-console-template for more information
using HelloWorld;

Console.WriteLine("Hello, World!");
Console.Write("How Many minutes :");
string? minutes = Console.ReadLine(); 
if (minutes is not null)
{
    DateUtils utils = new DateUtils();
    int mins = int.Parse(minutes);
    DateTime timeAtEndOfBreak =utils.TakeABreak(mins);
    Console.WriteLine($"ok be back at {timeAtEndOfBreak:T}");
}
else
{
    Console.WriteLine("Enter number");

}