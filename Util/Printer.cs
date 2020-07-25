using static System.Console;
namespace CoreEscuela.Util
{

    public static class Printer
    {
        
    
public static void DibujarLinea(int tamc= 10)
{
    var line = "".PadLeft(tamc, '=');
    WriteLine("====");
    WriteLine(line);


}
    }
}