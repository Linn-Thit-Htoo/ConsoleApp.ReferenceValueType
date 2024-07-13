namespace ConsoleApp.ReferenceValueType;

public class ValueTypeExample
{
    public static void Main(string[] args)
    {
        #region Value Type

        //int value = 19;
        //Console.WriteLine($"Original Value: {value}");
        //SetValue(value);
        //Console.WriteLine($"After modifying: {value}");

        #endregion

        #region Reference Type

        int value = 19;
        Console.WriteLine($"Original Value: {value}");
        SetValueRef(ref value);
        Console.WriteLine($"After modifying: {value}");

        #endregion
    }

    public static void SetValue(int value)
    {
        value += 1;
    }

    public static void SetValueRef(ref int value)
    {
        value += 1;
    }
}
