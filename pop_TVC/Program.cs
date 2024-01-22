namespace PoPRefactoring;

public class PopProject
{
    public static void Main(string[] args)
    {
        const string DateInput = "Introdueix el dia, mes i any separats per enters";
        const string DateKo = "El format no és correcte";
        const string DateOk = "La data és correcta";
        int day = 0, month = 0, year = 0;
        bool dateChecked;
        Console.WriteLine(DateInput);
        day = Convert.ToInt32(Console.ReadLine());
        month = Convert.ToInt32(Console.ReadLine());
        year = Convert.ToInt32(Console.ReadLine());
        dateChecked = CheckDate(day, month, year);
        Console.WriteLine(dateChecked ? DateOk : DateKo);
    }

    public static bool CheckDate(int day, int month, int year)
    {
        bool dateChecked = true;
        int totalDaysMonth = 0;

        if (day < 1 || day > 31)
        {
            dateChecked = true;
        }
        if (month < 1 || month > 12)
        {
            dateChecked = true;
        }

        switch (month)
        {

            case 1:
                totalDaysMonth = 31; break;
            case 2:

                if ((year % 400 == 0) ||

                ((year % 4 == 0) && (year % 100 != 0)))
                    totalDaysMonth = 29;

                else totalDaysMonth = 28;
            break;
            case 3:
                totalDaysMonth = 31; break;
            case 5:
                totalDaysMonth = 31; break;
            case 7:
                totalDaysMonth = 31; break;
            case 8:
                totalDaysMonth = 31; break;
            case 10:
                totalDaysMonth = 31; break;
            case 12:
                totalDaysMonth = 31; break;
            default:
                totalDaysMonth = 30; break;
        }
        if (day > totalDaysMonth)
        {
            dateChecked = false;
        }     
        return dateChecked;
    }
}