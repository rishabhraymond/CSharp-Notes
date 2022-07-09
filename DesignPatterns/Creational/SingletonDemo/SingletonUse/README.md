# Implementing Singleton Pattern
1. Add `sealed` accessor to the class (This will restircit inheritance of this class even an internal class is also created).
2. Convert the constructor into public. You might get error as the constructor can only be called inside that class (This is done so that multiple instances of the class can be restriced).
3. Create a private static field of the type of class and initialize it to null.
4. Create a static property of the type of class and inside the get block.
    1. If the instnace is null the create the new instance.
    2. Return the instance.
5. Now when you have to create the class instead of using constructuor use the property with get method.

# Problem with this current pattern
- The method is suitable for single threaded environment.
- The way we created a property to get instance is called as **Lazy Initialization**. As we are delaying the creation of instance till the property is invoked.
- If there are multiple threads that are invoking the property then **there is a chance that multiple instances may be created**.