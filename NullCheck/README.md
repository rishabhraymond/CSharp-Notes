# Null Check
Null check is a way to check the validity of the data.
## Why to check for Null?
Lets consider a following code:
```
public class SetValue
{
	public string Val {get; set;};
	
	public SetValue(string val)
	{
		Val = val;
	}
		
	public void AppendVal(string appendString)
	{
		Console.WriteLine(Val + appendString);
	}
}
```
We have a class called Test which has:
1.  Property called Val as `string` type.
2. Method called **AppendVal** which appends a string.

Suppose in our main is something like this:
```
SetValue valueObj = null;
valueObj.AppendVal("Bye!");
```
Now this will throw an error saying **testObj is null**.
This will also break our code and it will not work the way we want.

## How to check for null?
There are different ways to check for null:
### 1. Using == operator
```
f(valueObj == null) 
{
    Console.WriteLine("Value object is null");
}

if(valueObj != null)
{
    Console.WriteLine($"Value object has value {valueObj.Val}");
}
```
**NOTE:**
If **==** is overridden then avoid using this as it may not work the way it should.
###2. Using "is"
```
if(valueObj is null)
{
    Console.WriteLine("Value object is null");
}

if(valueObj is not null)
{
    Console.WriteLine($"Value object has value {valueObj.Val}");
}
```
Try using this as the **is** is a keyword so it cannot be changed.
###3. Using "?"
```
if (valueObj?.Val is null)
{
    Console.WriteLine("Value object is null");
}

if (valueObj?.Val is not null)
{
    Console.WriteLine($"Value object has value {valueObj.Val}");
}
```
Use this if you are unsure whether the object you will receive **may or may not be null** and you need to work on a **specific property** of that object.

###Checking null and asigning if it is
```
valueObj ??= new SetValue("Demo");
```
You can use this if you want shorthand to assign a value it the variable is null.
