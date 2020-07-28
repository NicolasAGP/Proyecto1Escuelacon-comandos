using static System.Console;
namespace CoreEscuela.Util
{

    public static class Printer
    {
        
    
public static void DrawLine(int tamc= 10)
{
  WriteLine("".PadLeft(tamc, '='));
}

public static void WriteTitele(string Titulo)
{
    var tamaño = Titulo.Length + 4 ;
    DrawLine(tamaño);
    WriteLine($" | {Titulo} |");
    DrawLine(tamaño);
}

 public static void Beep(int hz = 2000, int tiempo =500 , int cantidad = 1)
{
    while (cantidad-- > 0 )
 {
     System.Console.Beep(hz , tiempo);
 }   

}

    }
}