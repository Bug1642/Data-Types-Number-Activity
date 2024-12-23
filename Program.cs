namespace DataType
{
public class StudentInput
  {
public double Number()
    {
    double number = 2.15D;
    return number;
    }
  }
  class Program{
    static void Main(string [] args){
        StudentInput dabil = new StudentInput();
        Console.WriteLine($"This Number Double: {dabil.Number()}");
    }
  }
}
