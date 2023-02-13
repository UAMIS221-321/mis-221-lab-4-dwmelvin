int userChoice = GetUserChoice();


do {
    RouteEm(userChoice);
    userChoice = GetUserChoice();
    } while(userChoice !=3);{
        
    }
static int GetUserChoice() {
    DisplayMenu();
    string userChoice = System.Console.ReadLine();
    if(IsValidChoice(userChoice)) {
        return int.Parse(userChoice);
    }
    else return 0;
}

static void DisplayMenu() {
    System.Console.WriteLine("Enter 1 to display full triangle\nEnter 2 to display half triangle\nEnter 3 to exit");
}
   static bool IsValidChoice(string userInput) {
       if(userInput == "1" || userInput== "2" || userInput == "3") {
           return true;
       }
       else return false;
   }

   static void GetFull() {
            Random rnd = new Random();
            int rows = rnd.Next(3, 10);
            
            for (int i = 1; i <= rows; i++)
            {
                for (int column = 1; column <= i; column++)
                {
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
       }
       PauseAction();
   }
   static void GetPartial() {
            Random rnd = new Random();
            int rows = rnd.Next(3, 6);
            
            for (int i = 1; i <= rows; i++)
            {
                for (int column = 1; column <= i; column++)
                {
                    {
                        if (rnd.Next (0, 2) == 0)
                        {
                            System.Console.Write(" ");
                        }
                    }
                    System.Console.Write("*");
                }
                System.Console.WriteLine(); 
       }
       PauseAction();
   }    
   static void SayInvalidChoice() {
       System.Console.WriteLine("Invalid choice");
   PauseAction();
   }

   static void RouteEm(int menuChoice) {
      if (menuChoice == 1) {
          GetFull();
      }
      else if (menuChoice == 2) {
          GetPartial();
      }
      else if (menuChoice == 3) {
          SayInvalidChoice();
      }
   }
      static void PauseAction() {
          System.Console.WriteLine("Press any key to continue");
          Console.ReadKey();
      }