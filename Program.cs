namespace PoPRefactoring;

public class PopProject
{
    public static void Main ()
    {
        const string Menu = "\n\nA. Saltar\nB. Córrer\nC. Ajupir-se\nD. Amagar-se\n\n";
        const string MenuError = "Opció incorrecta. Torna a provar:\n";
        char opcio;
        int dia, mes, any;
        Console.WriteLine ("Introdueix el dia, mes i any");
        dia = Convert.ToInt32 (Console.ReadLine ());
        mes = Convert.ToInt32 (Console.ReadLine ());
        any = Convert.ToInt32 (Console.ReadLine ());
        Console.WriteLine(Valida(dia, mes, any) ? "La data és correcta." : "El format no és correcte");
    
        Console.WriteLine(Menu);
        do
        {
            opcio = Convert.ToChar(Console.ReadLine ());
            if (!Valida(opcio)) Console.WriteLine (MenuError);
        } while (!Valida (opcio));

        switch (opcio)
        {
            case 'A':
            case 'a': Console.WriteLine ("Salta"); 
                break;
            case 'B':
            case 'b': Console.WriteLine ("Corre"); 
                break;
            case 'C':
            case 'c': Console.WriteLine ("S'ajup"); 
                break;
            case 'D':
            case 'd': Console.WriteLine ("S'amaga"); 
                break;
        }   
    }

    public static bool Valida (int day, int month, int year)
    {
        int totalDaysMonth;
        switch (month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                totalDaysMonth = 31;
                break;
            case 4:
            case 6:
            case 9:
            case 11: totalDaysMonth = 30; break;
            case 2: // verifica l'any de traspàs
                if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)) totalDaysMonth = 29;
                else totalDaysMonth = 28;
                break;
            default: return false;
        }
        if (day > totalDaysMonth) return false;
        else return true;
    }

    public static bool Valida (char opcio)
    {
        const int AsciiA = 65, AsciiD = 68, Asciia = 97, Asciid = 100;
        return (opcio >= AsciiA && opcio <= AsciiD) || (opcio >= Asciia && opcio <= Asciid);
    }
}