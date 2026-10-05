namespace AssignOOP_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions

            #region Q1: Overloading, Overriding, and Binding
            //a)  What is the difference between Method Overloading and Method Overriding?
            //Method Overloading: Allows a class to have multiple methods with the same name but different Parameters.
            //Method Overriding: Allows a derived class to provide a specific implementation of a method that is already defined in its base class

            //b)  What is the difference between Static Binding and Dynamic Binding?
            //Static Binding: The binding of a method call to its implementation is determined at compile time. This is used for methods that are not overridden.
            //Dynamic Binding: The binding of a method call to its implementation is determined at runtime. This is used for overridden methods.


            #endregion

            #region Q2  Sealed Classes and Methods
            //a)  What is the purpose of the sealed keyword when applied to a class?
            //The sealed keyword is used to prevent a class from being inherited.
            //When a class is marked as sealed, it cannot be used as a base class for any other class.
            //This is useful when you want to restrict the inheritance hierarchy and ensure that the class's behavior remains unchanged.

            //b)  What is the difference between a sealed class and a sealed method?
            //A sealed class is a class that cannot be inherited, while a sealed method is a method that cannot be overridden in derived classes.

            //c)  Can a sealed method be overridden? Why?
            //No, a sealed method cannot be overridden.
            //When a method is marked as sealed, it prevents any derived class from overriding that method.

            #endregion

            #endregion


        }
    }
}
