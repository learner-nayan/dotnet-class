using ConsoleApp1.SessionOne.AppBasic;

public static class Bitwise {
  public static void Run()
  {
    int primary = 60;
    int secondary = 13;
    
    Console.WriteLine($"\nprimary={Convert.ToString(primary, 2)}");
    Console.WriteLine($"\nsecondary={Convert.ToString(secondary, 2)}");
    
    int andResult = primary & secondary;
    Console.WriteLine($"\n{primary} & {secondary} = {andResult} : {Convert.ToString(andResult, 2)}");
    
    int orResult = primary | secondary;
    Console.WriteLine($"\n{primary} | {secondary} = {orResult}: {Convert.ToString(orResult, 2)}");
    
    int xorResult = primary ^ secondary;
    Console.WriteLine($"\n{primary} ^ {secondary} = {xorResult} : {Convert.ToString(xorResult, 2)}");
    
    int onesComplementResult = primary & ~secondary;
    Console.WriteLine($"\n{primary} & {secondary} = {onesComplementResult} : {Convert.ToString(onesComplementResult, 2)}");
    
    int leftShiftResult = primary << 2;
    Console.WriteLine($"{primary} >> 2 = {leftShiftResult} : {Convert.ToString(leftShiftResult, 2)}");
    
    int rightShiftResult = primary >> 2;
    Console.WriteLine($"{primary} >> 2 = {rightShiftResult} : {Convert.ToString(rightShiftResult, 2)}");
  }
}