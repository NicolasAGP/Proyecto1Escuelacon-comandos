using static System.Console;
namespace CoreEscuela.Util
{

    public static class Printer
    {
        
    
public static void DibujarLinea(int tamc= 10)
{
  WriteLine("".PadLeft(tamc, '='));
}

public static void WriteTitele(string Titulo)
{
    var tamaño = Titulo.Length + 4 ;
    DibujarLinea(tamaño);
    WriteLine($" | {Titulo} |");
    DibujarLinea(tamaño);
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