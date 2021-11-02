# Calling .Net library methods

## How to call library methods

1. To call methods of a class in the .NET Class Library, you use the format `ClassName.MethodName()`, where the `.` symbol is the member access operator to access a method defined on the class, and the `()` symbols are the method invocation operators.
2. When calling a _stateless_ method, you don't need to create a new instance of its class first.
3. When calling a stateful method, you need to create an instance of the class, and access the method on the object.
4. Use the `new` operator to create a new instance of a class.
5. An instance of a class is called an _object_.
6. Methods may accept no parameters or multiple parameters, depending on how they were designed and implemented. When passing in multiple input parameters, separate them with a `,` symbol.
7. Methods may return a value when they complete their task, or they may return nothing (`void`).
8. Overloaded methods support several implementations of the method, each with a unique method signature (the number of input parameters and the data type of each input parameter).
9. Intellisense can help write code more quickly. It provides a quick reference to methods, their return values, their overloaded versions, and the types of their input parameters.
10. docs.microsoft.com is the "source of truth" when you want to learn how methods in the .NET Class Library work.
