public class ClassDemo
{
    public static void main(String[] arg)
    {
        Calculator calculator = new Calculator();

        System.out.println(calculator.sum(3, 4));

        System.out.println(calculator.sum(3, 4, new NumberManagerDefaultImpl()));

        System.out.println(calculator.sum(3, 4, new NumberManagerCustomImpl()));
    }
} 
