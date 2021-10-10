using System;
using System.Collections;

namespace FluidConsoleApp
{
    public interface IMyInterface
    { 

    }
    class KeyValuePair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }


   

    //A non-generic class can include generic methods by specifying a type parameter in angle brackets with the method name, as shown below.
    class Printer
    {
        public void Print<T>(T data)
        {
            Console.WriteLine(data);
        }
    }

    class DataStoreWithBaseConst<T> where T : ArrayList 
    {
        /*
         base class name
        The type argument must be or derive from the specified base class.
        The Object, Array, ValueType classes are disallowed as a base class constraint.
        The Enum, Delegate, MulticastDelegate are disallowed as base class constraint before C# 7.3.*/
        public T Data { get; set; }
    }


    class DataStoreWithConst2<T> where T : notnull
    {
        public T Data { get; set; }
    }

    class DataStoreWithConst<T> where T : class
    {
        public T Data { get; set; }
    }


    class DataStore<T>
    {
        public T Data { get; set; }
        private T[] _data = new T[10];

        public void AddOrUpdate(int index, T item)
        {
            if (index >= 0 && index < 10)
                _data[index] = item;
        }

        public T GetData(int index)
        {
            if (index >= 0 && index < 10)
                return _data[index];
            else
                return default(T);
        }

    }

    public class testGenerics 
    { 

        public testGenerics()
        {

            /*
             * Generic Class Characteristics *
                1- A generic class increases the reusability. The more type parameters mean more reusable it becomes. 
                    However, too much generalization makes code difficult to understand and maintain.
                2- A generic class can be a base class to other generic or non-generic classes or abstract classes.
                3- A generic class can be derived from other generic or non-generic interfaces, classes, or abstract classes.
             */
            DataStore<string> store = new DataStore<string>();
            store.Data = "Hello World!";


            KeyValuePair<int, string> kvp1 = new KeyValuePair<int, string>();
            kvp1.Key = 100;
            kvp1.Value = "Hundred";

            KeyValuePair<string, string> kvp2 = new KeyValuePair<string, string>();
            kvp2.Key = "IT";
            kvp2.Value = "Information Technology";

            /*
             * Example: Generic Methods
             */
            DataStore<string> cities = new DataStore<string>();
            cities.AddOrUpdate(0, "Mumbai");
            cities.AddOrUpdate(1, "Chicago");
            cities.AddOrUpdate(2, "London");

            DataStore<int> empIds = new DataStore<int>();
            empIds.AddOrUpdate(0, 50);
            empIds.AddOrUpdate(1, 65);
            empIds.AddOrUpdate(2, 89);

            /*A non-generic class can include generic methods
             * by specifying a type parameter in angle brackets with the method name, as shown below.*/

            Printer printer = new();
            printer.Print<int>(100);
            printer.Print(200); // type infer from the specified value
            printer.Print<string>("Hello");
            printer.Print("World!"); // type infer from the specified value


            /*Advantages of Generics
                1- Generics increase the reusability of the code. You don't need to write code to handle different data types.
                2- Generics are type - safe.You get compile-time errors if you try to use a different data type 
                    than the one specified in the definition.
                3- Generic has a performance advantage because it removes the possibilities of boxing and unboxing.
            */


            /*
             C# Generic Constraints
            - C# allows you to use constraints to restrict client code to specify certain types while
            instantiating generic types. It will give a compile-time error if you try to instantiate a generic 
            type using a type that is not allowed by the specified constraints.
            
            You can specify one or more constraints on the generic type using the where clause after the generic type name.
            Syntax:
            GenericTypeName<T> where T  : contraint1, constraint2

            Example: Declare Generic Constraints
            */

            //we applied the class constraint
            DataStoreWithConst<string> store3 = new DataStoreWithConst<string>(); // valid
            DataStoreWithConst<testGenerics> store4 = new DataStoreWithConst<testGenerics>(); // valid
            DataStoreWithConst<IMyInterface> store5 = new DataStoreWithConst<IMyInterface>(); // valid

            DataStoreWithConst<IEnumerable> store6 = new DataStoreWithConst<IEnumerable>(); // valid

            DataStoreWithConst<ArrayList> store7 = new DataStoreWithConst<ArrayList>(); // valid
            DataStore<int> store8 = new DataStore<int>(); // compile-time error 



        }

    }


}
