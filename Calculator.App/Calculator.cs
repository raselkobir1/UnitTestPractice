namespace Calculator.App
{
    public class Calculator 
    {
        public int AddNumbers(int a , int b)
        {
            return a + b;
        }
        public bool IsOddNumber(int x) 
        {
            return x % 2 != 0;  // != return true other wise return false.
        }
    }
}