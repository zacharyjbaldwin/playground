// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");


var elements = new List<MyClass>();

var timer = new Stopwatch();
timer.Start();
for (int i = 0; i <= 5000000; i++)
{
    elements.Add(new MyClass()
    {
        Id = i,
        IsActive = new Random().Next(0, 2) == 0
    });
}
timer.Stop();
Console.WriteLine($"It took {timer.Elapsed} to create the array.");

int currentLength = 0;
int maxLength = 0;
timer.Restart();
foreach (var element in elements)
{
    currentLength = element.IsActive ? ++currentLength : 0;
    maxLength = Math.Max(maxLength, currentLength);
}
timer.Stop();

Console.WriteLine(maxLength);
Console.WriteLine($"It took {timer.Elapsed} to scan the array.");

class MyClass
{
    public int Id { get; set; }
    public bool IsActive { get; set; }
}