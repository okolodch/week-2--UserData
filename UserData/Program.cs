NewMethod();

void NewMethod()
{
    //programm küsib kasutaja sünniaastat;
    //programm arvutab kasutaja vanust;
    //programm kuvab kasutaja vanust konsoolist;

    Console.WriteLine("Palun sisesta oma sünniaasta:");

    int yearOfBirth = Convert.ToInt32(Console.ReadLine());
   
    int UserAge = 2021 - yearOfBirth;
    //Console.WriteLine("Oled" + UserAge + "aastat vana.");
    //Stringinterpolation

    Console.WriteLine($"Oled {UserAge} aastat vana");
}
