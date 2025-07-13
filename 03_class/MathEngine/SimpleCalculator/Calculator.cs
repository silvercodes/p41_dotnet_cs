namespace MathEngine.SimpleCalculator;

public class Calculator
{
    public int Execute(Operation op, int a, int b) => op switch
    { 
        Operation.Add => a + b,
        Operation.Sub => a - b,
        Operation.Mult => a * b,
        Operation.Div => a / b,

        _ => a + b,
    };
}
