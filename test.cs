public class TestClass
{
    public int Fibo(int a, int b, int n)
    {
        if (n > 1)
        {
            return Fibo(b, a + b, --n);
        }
        return b;
    }
    // Test

    public int Fibo(int a, int b, int n)
    {
        if (n > 1)
        {
            return Fibo(b, a + b, --n);
        }
        return b;
    }
}
