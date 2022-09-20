# Double Check Locking
- This method is thread safe way of initializing the object.
- We will create a private static readonly field of type object and initialize it.
- In get method we will use lock(object) and inside its body we will have our object initialization.
- We will wrap this whole code with null check to ensure we do not call lock() always as it is a costly method.
- This method is also called as **Lazy Initialization**.

# What is Lazy initialization
- It is a way of creating an instance of a class.
- By this method the class will be created **if and only if its proprty or method is called.**
- This helps in improving the performance.
- Application loads faster.
- Reduces the memory footprint during the startup.

# Problem with Double Check Locking
This method can make code look quite complicated.