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
