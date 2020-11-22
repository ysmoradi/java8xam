# java8xam
Java 8 &amp; CSharp 8 default interface implementation + Xamarin.Android sample

There's a Calculator class in Java code which accepts two number in its Sum method.

```java
public class Calculator
{
    public int sum(int n1, int n2)
    {
        return n1 + n2;
    }

    public int sum(int n1, int n2, NumberManager numberManager)
    {            
        n1 = numberManager.change(n1);
        n2 = numberManager.change(n2);

        return n1 + n2;
    }
} 
```

Sum method also accepts an implementation of NumberManager interface which has a Change method which works as belwo:

```java
public interface NumberManager
{
    public default int change(int input)
    {
        return input * 2; // java 8 default interface implementation feature!
    }
}
```

There are 2 implementations in java project as followings:

```java
public class NumberManagerDefaultImpl implements NumberManager
{

}

public class NumberManagerCustomImpl implements NumberManager
{
    public int change(int input)
    {
        return input * 3;
    }
}
```

here, you can see results of method invocations in java sample

```java
Calculator calculator = new Calculator();

System.out.println(calculator.sum(3, 4)); // (3 + 4) => 7

System.out.println(calculator.sum(3, 4, new NumberManagerDefaultImpl())); // (3 * 2 + 4 * 2) => 14

System.out.println(calculator.sum(3, 4, new NumberManagerCustomImpl())); // (3 * 3 + 4 * 3) => 21
```

After that, we generated C# wrapper using Xamarin's Android Binding library, and we developed followings in C#

```cs
public class NumberManagerCustomCSharpImp : Java.Lang.Object, INumberManager /*C# code generator genrates Java's NumberManager interface as INumberManager by convention*/
{
    public int Change(int input) /*C# code generator generates Java's change metod (camel case) as Change method (pascal case) by convention*/
    {
        return input * 4;
    }
}
```

At the end, you can see results of method invocations in C# sample

```cs
Calculator calc = new Calculator(); // C# code generator generates wrapper for all types which are provided by jar file, including Calculator class.

int result = calc.Sum(3, 4); // (3 + 4) => 7

int result2 = calc.Sum(3, 4, new NumberManagerDefaultImpl()); // (3 * 2 + 4 * 2) => 14

int result3 = calc.Sum(3, 4, new NumberManagerCustomImpl()); // (3 * 3 + 4 * 3) => 21

int result4 = calc.Sum(3, 4, new NumberManagerCustomCSharpImp()); // (3 * 4 + 4 * 4) => 28
```
