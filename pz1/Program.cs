using Dll;

namespace pz1;

class Program
{
    static void Main(string[] args)
    { 
        var result = 1
            .Plus(12)
            .Subtract(3)
            .Multiply(2)
            .Divide(5)
            .Plus(9);

        var isThirteen = result.IsThirteen();
        var str = isThirteen ? "Да" : "Нет";
        
        Console.WriteLine($"Результат: {result}");
        Console.WriteLine($"13? {str}");
    }
}