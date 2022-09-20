# Eager Initialization
- Here we create the instance at the starting before it asks for any operation to perform.
- This approach is good where the instance does not have a high computation task.

# To create Singleton using Eager Initialization
- Create the constructor as private
- Initialize an object there itself
- Create a property which returns that