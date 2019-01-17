public class TestClass
{
    public void Fibo(int a, int b, int n)
    {
        if (n > 1)
        {
            Fibo(b, a + b, --n);
        }
    }

    public void Fibo(int a, int b, int n)
    {
        if (n > 1)
        {
            Fibo(b, a + b, --n);
        }
    }
}
