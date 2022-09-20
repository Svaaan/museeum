internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Välkommen till TOBACCO AND SALT MUSEUM");

        System.Console.WriteLine("Tryck valfri knapp för att börjar");
        Console.ReadKey();

        Entrance();

        ExibitionOne();

        Kafet();

        ExibitionTwo();

        GiftShop();

        System.Console.WriteLine("Tack för ditt besök välkommen åter!");
        System.Console.WriteLine("Tryck på valfri knapp för att börja gå hem");
        Console.ReadKey();

        Console.Clear();
        Console.WriteLine("- Går hem -");
        System.Console.WriteLine("Bus, tåg eller bil?");
        System.Console.WriteLine("Svar: ");
        Console.ReadLine();

    }

    private static void Entrance()
    {
        while(true)
        {
            Console.Clear();
            

            Console.WriteLine("Välkommen till entren");
            
            System.Console.WriteLine("1. cigars");
            System.Console.WriteLine("2. salt skulptur");
            System.Console.WriteLine("3. Nästa rum");
            
            Console.WriteLine("Välj");

            string choices = Console.ReadLine();

            Console.Clear();
            
            switch(choices)
            {
                case "1":

                Console.WriteLine("- Info om Cigarrer -");
                System.Console.WriteLine("Tryck på valfri knapp när du är klar");
                Console.ReadKey();

                break;

                case "2":
                
                Console.WriteLine("- Info om Salt skulptur");
                System.Console.WriteLine("Tryck på valfri knapp när du är klar");
                Console.ReadKey();

                break;
                 
                case "3":

                System.Console.WriteLine("Går till nästa rum....");
                System.Console.WriteLine("10% rabbat på pipor i gift shopen! Välkommen in!");
                System.Console.WriteLine("Tryck på valfri knapp när du är klar");
                Console.ReadKey();

                return;

              
                default:

                break;
                
 

            }
            Console.Clear();
            
            

        }
    }

    private static void ExibitionOne()
    {
        while(true)
        {
            Console.Clear();
            

            Console.WriteLine("Välkommen till Exibition One");
            
            System.Console.WriteLine("1. Salt vatten evoporation");
            System.Console.WriteLine("2. Annat");
            System.Console.WriteLine("3. Nästa rum");

            
            Console.WriteLine("Välj");

            string choices = Console.ReadLine();

            Console.Clear();
            
            switch(choices)
            {
                case "1":

                Console.WriteLine("- Display av Salt vatten evoporation -");
                System.Console.WriteLine("Tryck på valfri knapp när du är klar");
                Console.ReadKey();
                break;

                case "2":
                
                Console.WriteLine("Annat");
                System.Console.WriteLine("Tryck på valfri knapp när du är klar");
                Console.ReadKey();
                break;
                 
                case "3":

                System.Console.WriteLine("Går till nästa rum....");
                System.Console.WriteLine("5% rabbat på Himalaya salt i gift shopen! Välkommen in!");
                System.Console.WriteLine("Tryck på valfri knapp när du är klar");
                Console.ReadKey();
                return;

              
                default:

                break;
                
 

            }
            Console.Clear();
        }
    }

    private static void Kafet()
    {
        while(true)
        {
            // Rum 1: cigars, salt sculpture, nästa rum.
            Console.Clear();
            

            Console.WriteLine("Välkommen till Kafet!");
            
            System.Console.WriteLine("1. Fika");
            System.Console.WriteLine("2. Mingla");

            System.Console.WriteLine("3. Nästa rum");
            
            Console.WriteLine("Välj");

            string choices = Console.ReadLine();

            Console.Clear();
            
            switch(choices)
            {
                case "1":

                Console.WriteLine("Fika");
                System.Console.WriteLine("Tryck på valfri knapp när du är klar");
                Console.ReadKey();
                break;

                case "2":
                
                Console.WriteLine("Mingla");

                Console.WriteLine("Hejsan hur är det?");
                ForceMingel();
                
                Console.WriteLine("Kul att höra! Jo tack det är bra!");
                ForceMingel();
                
                Console.WriteLine("Kul att du fråga, jag åt en kaka och kaffe.");
                ForceMingel();
                
                 Console.WriteLine("Visste du att en krokodil kan stoppa ut tungan?");
                ForceMingel();
                
                 Console.WriteLine("Vad kul vi har! Vill du hör en till fun fact?");
                ForceMingel();
                
                 Console.WriteLine("Dåså! Här kommer en till fun fact: Visste du att en räka har hjärtat i huvudet?");
                ForceMingel();
                
                Console.WriteLine("Vad kul vi hade! Nu tänker jag gå och titta på himalaya bilderna. Häng på");
                ForceMingel();
               
                Console.WriteLine("Jag kan säga lite fun fact om salt om du vill på vägen.");
                ForceMingel();
                
                Console.WriteLine("Allt bra med familjen?");
                ForceMingel();
                
                


                System.Console.WriteLine("Tryck på valfri knapp när du är klar");
                Console.ReadKey();
                break;
                 
                case "3":

                System.Console.WriteLine("Går till nästa rum....");
                System.Console.WriteLine("15% rabbat på Evoporations maskin i gift shopen! Välkommen in!");
                System.Console.WriteLine("Tryck på valfri knapp när du är klar");
                Console.ReadKey();
                return;

              
                default:

                break;
                
 

            }
            Console.Clear();
        }
    }

    private static void ExibitionTwo()
    {
        while(true)
        {
            Console.Clear();
            

            Console.WriteLine("Välkommen till Exibition Two!");
            
            System.Console.WriteLine("1. Pipes");
            System.Console.WriteLine("2. pictures of Himalaya");
            System.Console.WriteLine("3. Nästa rum");
            
            Console.WriteLine("Välj");

            string choices = Console.ReadLine();

            Console.Clear();
            
            switch(choices)
            {
                case "1":

                Console.WriteLine("-Pipes-");
                System.Console.WriteLine("Tryck på valfri knapp när du är klar");
                Console.ReadKey();
                break;

                case "2":
                
                Console.WriteLine("-pictures of Himalaya-");
                Console.WriteLine("   ^   ");
                Console.WriteLine("~~/ 7 ~~~ ");
                Console.WriteLine(" / /|^  ");
                Console.WriteLine("/ / |/7   ");
                Console.WriteLine("_______");

                Thread.Sleep(10000);

                System.Console.WriteLine("Tryck på valfri knapp när du är klar");
                Console.ReadKey();
                break;
                 
                case "3":

                System.Console.WriteLine("Går till nästa rum....");
                System.Console.WriteLine("Refer a friend och få 10% på de hen handlar för i gift shopen!");
                System.Console.WriteLine("Välkommen in!");
                System.Console.WriteLine("Tryck på valfri knapp när du är klar");
                Console.ReadKey();
                return;

              
                default:

                break;
                
 

            }
            Console.Clear();
        }
    }

    private static void GiftShop()

    {
        while(true)
        {
            Console.Clear();
            

            Console.WriteLine("Välkommen till Gift shop!");
            
            System.Console.WriteLine("1. Handla");
            
            Console.WriteLine("Välj");

            string choices = Console.ReadLine();

            Console.Clear();
            
            switch(choices)
            {
                case "1":

                Console.WriteLine("- Handlar.. -");
                System.Console.WriteLine("OBS! Glöm inte dina rabatter!");

                Thread.Sleep(10000);

                System.Console.WriteLine("Behöver du hjälp?");
                System.Console.Write("Svar: ");
                Console.ReadLine();


                System.Console.WriteLine("Tryck på valfri knapp när du är klar");
                Console.ReadKey();
                Console.Clear();
                return;
              
                default:

                break;
                
            }
            Console.Clear();

            
            

        }

    }
    public static void ForceMingel()
    {
        while(true)
        {
            Console.Write("Svar: ");
            if(Console.ReadLine().Length >= 1)
            {
                return;
            }
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
    }
    
}