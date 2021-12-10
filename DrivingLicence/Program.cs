NewMethod();

void NewMethod()
{
    // See https://aka.ms/new-console-template for more information
    //programm küsib kasutaja sünniaastat
    //programm arvutab kasutaja vanust 
    //kui kasutaja on noorem , kui 18, siis programm kuvab konsoolis
    //"Oled liiga noor, et juhilube saada"
    //kui kasutaja on vanem kui 18, siis programm kuvab konsoolis 
    //"oled piisavalt vana,et juhilube saada"
    //kui kasutaja on 18, siis programm kuvab konsoolis 
    //"palju õnne! Nüüd sa saad ka juhiluba taotleda"


    
    Console.WriteLine("Mis aastal Te olete sündinud:");

    int yearOfBirth = Convert.ToInt32(Console.ReadLine());

    int UserAge = 2021 - yearOfBirth;
    //Console.WriteLine("Oled" + UserAge + "aastat vana.");
    //Stringinterpolation

    //Console.WriteLine($"Oled {UserAge} aastat vana");

    //int DateOfBirth = Convert.ToInt32(Console.ReadLine());

    if (UserAge > 18)
    {
        Console.WriteLine("Oled piisavalt vana,et juhilube saada .");

    }
    else if (UserAge < 18)
    {

        Console.WriteLine("Oled liiga noor, et juhilube saada.");
    }
    else

    {
        Console.WriteLine("palju õnne! Nüüd sa saad ka juhiluba taotleda .");



    }

    Console.WriteLine("Kõike ilusat Teile!");


}
