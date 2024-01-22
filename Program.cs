namespace PoPRefactoring;

public class PopProject
{
    public static void Main ()
    {
        int dia, mes, any;
        Console.WriteLine ("Introdueix el dia, mes i any");
        dia = Convert.ToInt32 (Console.ReadLine ());
        mes = Convert.ToInt32 (Console.ReadLine ());
        any = Convert.ToInt32 (Console.ReadLine ());
        Console.WriteLine (Valida (dia, mes, any) ? "El format no és correcte" : "La data és correcta.");
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
}