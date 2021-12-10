NewMethod();

void NewMethod()
{
    Console.WriteLine("Palun sisesta oma vanus:");

    int UserAge = Convert.ToInt32(Console.ReadLine());

    int DateOfBirth = 2021 - UserAge;
    //Console.WriteLine("Oled" + UserAge + "aastat vana.");
    //Stringinterpolation

    Console.WriteLine($"Oled sündinud {DateOfBirth} aastal ");

    //Programm küsib kasutaja vanust;
    //Programm arvutab kasutaja sünniaastat;
    //Programm kuvab sünniaastat konsoolis
}