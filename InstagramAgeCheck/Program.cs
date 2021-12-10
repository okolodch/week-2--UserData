NewMethod();

void NewMethod()
{
    //programm küsib kasutaja vanust
    //programm kontrollib, kas kasutaja on vanem kui 13 aastat või 13 aastat vana
    //kui kasutaja on 13 aastat vana või vanem, siis ta võib Instagrammi kasutada
    //kui kasutaja on noorem, kji 13, siis ta on liiga noor .

    Console.WriteLine("Palun sisesta oma vanus:");

    int UserAge = Convert.ToInt32(Console.ReadLine());

    if (UserAge > 13)
    {
        Console.WriteLine("Oled piisavalt vana, et Instagrammi kontot luua .") ;

    }
    else if (UserAge < 13) 
    {

        Console.WriteLine("Oled liiga noor, et Instagrammi kontot luua.");
    }
    else 
        
    {
        Console.WriteLine("Oledki 13, nüüd saad instagrammi kontot  luua  .");



    }

    Console.WriteLine("Kena päeva!");
}
