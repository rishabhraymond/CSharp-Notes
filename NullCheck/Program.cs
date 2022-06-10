// See https://aka.ms/new-console-template for more information
using NullCheck;

Console.WriteLine("Null Check!");

var valueObj = new Random().Next(0,10) >= 5 ? new SetValue("Rishabh") : null;

/******************Method 1*********************/
if(valueObj == null) 
{
    Console.WriteLine("Value object is null");
}

if(valueObj != null)
{
    Console.WriteLine($"Value object has value {valueObj.Val}");
}
/************************************************/

/******************Method 2*********************/
if(valueObj is null)
{
    Console.WriteLine("Value object is null");
}

if(valueObj is not null)
{
    Console.WriteLine($"Value object has value {valueObj.Val}");
}
/************************************************/

/******************Method 3*********************/
if (valueObj?.Val is null)
{
    Console.WriteLine("Value object is null");
}

if (valueObj?.Val is not null)
{
    Console.WriteLine($"Value object has value {valueObj.Val}");
}
/************************************************/

valueObj ??= new SetValue("Sinha");

Console.WriteLine($"Final value of Value object is {valueObj.Val}");
valueObj.AppendString("Sinha");
