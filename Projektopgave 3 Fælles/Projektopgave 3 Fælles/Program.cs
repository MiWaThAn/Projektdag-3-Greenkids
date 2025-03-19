
//Vores prædefinerede tøjstykker
    int toejId1 = 1;
    string toejtype1 = "Bukser";
    string toejstørrelse1 = "M";
    string toejmærke1 = "Adidas";
    int toejStand1 = 0;
    string toejMateriale1 = " ";
    double toejCO2Besparelse1 = 72.5;
    bool toejErSolgt1 = true;
DateTime toejIndleveringsDato1 = new DateTime(2017, 1, 23, 10, 45, 30); 



    int toejId2 = 2;
    string toejtype2 = "Trøje";
    string toejstørrelse2 = "XL";
    string toejmærke2 = "Adidas";
    int toejStand2 = 1;
    string toejMateriale2 = " ";
    double toejCO2Besparelse2 = 33.7;
    bool toejErSolgt2 = false;
DateTime toejIndleveringsDato2 = new DateTime(2023, 7, 12, 9, 45, 47);


int toejId3 = 3;
    string toejtype3 = "Underbukser";
    string toejstørrelse3 = "XXL";
    string toejmærke3 = "CR7";
    int toejStand3 = 2;
    string toejMateriale3 = " ";
    double toejCO2Besparelse3 = 10;
    bool toejErSolgt3 = true;
DateTime toejIndleveringsDato3 = new DateTime(2020, 2, 28, 10, 45, 30);


// Lister oprettes
    List<int> idListe = new List<int>() { toejId1, toejId2, toejId3 };
    List<string> toejtypeListe = new List<string>() { toejtype1, toejtype2, toejtype3 };
    List<string> toejstørrelseListe = new List<string>() { toejstørrelse1, toejstørrelse2, toejstørrelse3 };
    List<string> toejmærkeListe = new List<string>() { toejmærke1, toejmærke2, toejmærke3 };
    List<int> toejStandListe = new List<int>() { toejStand1, toejStand2, toejStand3 };
    List<string> toejMaterialeListe = new List<string>() { toejMateriale1, toejMateriale2, toejMateriale3 };
    List<double> toejCO2BesparelseListe = new List<double>() { toejCO2Besparelse1, toejCO2Besparelse2, toejCO2Besparelse3 };
    List<bool> toejErSolgtListe = new List<bool>() { toejErSolgt1, toejErSolgt2, toejErSolgt3 };
    List<DateTime> toejIndleveringsDatoListe = new List<DateTime>() { toejIndleveringsDato1, toejIndleveringsDato2, toejIndleveringsDato3 };
while (1 == 1)

{

    


    
    //ID Menu

        

    Console.WriteLine("Tast a for tøjinformation, tast b for at tilføje tøjstykke");
    string valgmuligheder = Console.ReadLine();

    if (valgmuligheder == "a")
    {
    idListe.ForEach(Console.WriteLine);
    Console.WriteLine("Indtast ID, du ønsker yderligere informationer om [1-3]");
        int valgtID = 0;
    while (true)
    {
        bool inputgood = int.TryParse(Console.ReadLine(), out valgtID);
            if (inputgood && valgtID >= 1 && valgtID <= idListe.Count())
            {
                break;

            }
                Console.WriteLine("Ugyldig indtasting");
    }

        
        Console.WriteLine("ID: " + idListe[valgtID - 1] + " toejtype: " + toejtypeListe[valgtID - 1] + " toejstørrelse: " + toejstørrelseListe[valgtID - 1] + " toejmærke: " + toejmærkeListe[valgtID - 1] + " toejStand: " + toejStandListe[valgtID-1] + " CO2-Besparelse " + toejCO2BesparelseListe[valgtID - 1] + " toejErSolgt: " + toejErSolgtListe[valgtID - 1] + " Indleveringsdato " + toejIndleveringsDatoListe[valgtID -1]);
    }
    else if (valgmuligheder == "b")
    {
        
        TilfoejToej(idListe, toejtypeListe, toejstørrelseListe, toejmærkeListe, toejStandListe, toejMaterialeListe, toejCO2BesparelseListe, toejErSolgtListe, toejIndleveringsDatoListe);
       }

}
static void TilfoejToej(List<int> idListe, List<string> toejtypeListe, List<string> toejstørrelseListe, List<string> toejmærkeListe, List<int> toejStandListe, List<string> toejMaterialeListe, List<double> toejCO2BesparelseListe, List<bool> toejErSolgtListe, List<DateTime> toejIndleveringsDatoListe)
{
    
    int placeholdID = idListe.Count + 1;
    idListe.Add(placeholdID);
    Console.WriteLine("ID " + placeholdID);
    Console.WriteLine("Indtast tøjtype");
    toejtypeListe.Add(Console.ReadLine());
    //Tilføj Tøjstørrrlse
    Console.WriteLine("Indtast Tøjstørrelse, f.eks.S, M, L, XL");
    toejstørrelseListe.Add(Console.ReadLine());
    //Tilføj Tøjmærke
    Console.WriteLine("Indtast Tøjmærke");
    toejmærkeListe.Add(Console.ReadLine());
    //Tøjstand
    Console.WriteLine("Indtast tøjstand, 0 = god, 1 = middel, 2 = slidt");
    string placeholdSTR = Console.ReadLine();
    int placeholdINT = Convert.ToInt32(placeholdSTR);
    toejStandListe.Add( placeholdINT );
    // Tilføj Tøjmateriale
    Console.WriteLine("Indtast Tøjmateriale");
    toejMaterialeListe.Add(Console.ReadLine());
    //Tilføj CO2BESPARELSE                    
    Console.WriteLine("Indtast CO2-Besparelse");
     placeholdSTR = Console.ReadLine();
    double placeholdDOU = Convert.ToDouble(placeholdSTR);
    toejCO2BesparelseListe.Add(placeholdDOU);
    //Er tøj solgt?
    Console.WriteLine("Er tøj solgt? Tryk a for ja, b for nej");
     placeholdSTR = Console.ReadLine();
    bool placeholdBOOL = true;
    if (placeholdSTR == "a")
    { placeholdBOOL = true; }
    else if (placeholdSTR == "b")
        {placeholdBOOL = false; }
    toejErSolgtListe.Add(placeholdBOOL);
    //Tilføj Datetime
    Console.WriteLine("Tøj indleveret dag");
    toejIndleveringsDatoListe.Add(DateTime.Now);
    Console.WriteLine(toejIndleveringsDatoListe[placeholdID-1]);
    Console.ReadKey();
    return;
}



