//Zuerst das dictionary für die römischen Zahlen erstellen
Dictionary<int, string> romdic = new Dictionary<int, string>()
        {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" }
        };

do
{

    //danach eine Readline für die Eingabe von der jeweligen arabischen Nummer machen
    Console.Write("Enter a number: ");
    int arab = int.Parse(Console.ReadLine()); //z.B. 528

    //Diese wird dann mit dem dictionary verglichen und dann berechnet
    string rom = ""; 
    foreach (KeyValuePair<int, string> pair in romdic)
    {
        while (arab >= pair.Key)
        {
            rom += pair.Value; 
            arab -= pair.Key;
           /* Console.WriteLine (pair.Key + ": " + rom + " : " + arab); */ //Falls unklar einfach Commentar öffnen
        }
    }

    //die Lösung wird eventuell dann hier geprintet
    Console.WriteLine("Roman Numeral: " + rom);


    //zum Wiederholen eine Frage
    Console.WriteLine("Again? (Enter Yes)");
    string ans = Console.ReadLine();


    if (ans != "Yes")
    {
        break;
    }


} while (true);
