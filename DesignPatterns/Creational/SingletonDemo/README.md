# Singleton Pattern
## Introdcution
- Type of **creational design pattern**.
- This is used when we need to ensure that **only a single object of the particular class has to be instantiated**.
- All further refferences to the objects are reffered to the same underlying instance created.
## Advantages of Singleton Pattern
- Well management of control of **concurrent access to the resource**.
- Ensures that only **single class is instantiated accross the application in a controlled state**.
## Implementation Guildliness
- Only object of that class should exists.
- Provide golbal access to the instance by:
    - Declaring all constructor of the class to be private.
    - Providing static method that returns the referrence to the instance.
    - Instance has to be stored as a private static variable