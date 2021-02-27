using UnityEngine;


public class Hacker : MonoBehaviour
{
    
    //Game configuration data
    //string[] level1Password = { "dick", "vibrator", "anal", "dianacumelancia", "facial", "deepthroat"};
    string[] level1Password = { "hacker", "computer", "coding", "password", "browser", "virus"};
    string[] level2Password = { "luisfilipevieira", "pedroguerra", "jesus", "aguia", "eusebio", "corruptos"};


    //Game State
     int level;
    // Start is called before the first frame update
    enum Screen
    {
        MainMenu,
        Password,
        Win
    };
     Screen currentScreen;
    string password;

    

   
    void Start()
    {
        //print(level1Password[0]);
        ShowMainMenu();
        //OnUserInput();
        //print("Hello World");
        
        
    }

    void ShowMainMenu()
    {
         currentScreen = Screen.MainMenu;
        Terminal.ClearScreen();
        //var greeting = "Hello Ben";
        //Terminal.WriteLine(greeting);
        Terminal.WriteLine("What would you like to hack into?");
        //Terminal.WriteLine("Press 1 for the PornHub");
        Terminal.WriteLine("Press 1 for the IT Enterprise");
        Terminal.WriteLine("Press 2 for  Benfica");
        Terminal.WriteLine("Enter your selection: ");
    }

    void OnUserInput(string input)
    {
        if (input == "menu")
        {
            ShowMainMenu();
        }
         else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
            



        } else if(currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }
        




    }

    void CheckPassword(string input)
    {
        if (input == password)
        {
            DisplayWinScreen();
            Terminal.WriteLine("Correct !!! You may write menu to play again");

        } /*else 
        {
            Terminal.WriteLine("Incorrect! Please try again");
        }*/

        else if (input == password)
        {
            DisplayWinScreen();
            Terminal.WriteLine("Correct !!! You may write menu to play again");

        }
        else 
        {
            Terminal.WriteLine("Incorrect! Please try again");
        }
       
    }

     void DisplayWinScreen()
    {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        ShowLevelReward();
    }

     void ShowLevelReward()
    {
        switch(level){

           /* case 1:
Terminal.WriteLine(@" |||||               
 ||. .||
|||\=/|||
|.-- --.|
/(.) (.)\
\ ) . ( /
'(  v  )`
  \ | /
  ( | )
  '- -`
");
                break;*/
            case 1:
                Terminal.WriteLine("Have a ball..");
                Terminal.WriteLine(@"
       ____
    ,dP9CGG88@b,
  ,IP  _   Y888@@b,
 dIi  (_)   G8888@b
dCII  (_)   G8888@@b
GCCIi     ,GG8888@@@
GGCCCCCCCGGG88888@@@
GGGGCCCGGGG88888@@@@...
Y8GGGGGG8888888@@@@P.....
 Y88888888888@@@@@P......
 `Y8888888@@@@@@@P'......
    `@@@@@@@@@P'.......
        """"........");
                break;
            case 2:
                Terminal.WriteLine("Have a ball..");
                Terminal.WriteLine(@"
     ________
   /        //
  /        // 
 /        //
(________(/");
                break;
            default:
                Terminal.WriteLine("");
                break;
            

        }
       
    }

    void RunMainMenu(string input)
        {



         if (input == "1")
            {
                level = 1;
            password = level1Password[UnityEngine.Random.Range(0, level1Password.Length)];
            StartGame();
                

            //Screen password = Screen.Password;

        }
       
        else if (input == "2")
            {
                level = 2;
                password = level2Password[UnityEngine.Random.Range(0, level2Password.Length)]; 
                StartGame();

            //Screen password = Screen.Password;
        }
       /* else if (input == "3")
        {
            level = 3;
            password = level3Password[UnityEngine.Random.Range(0, level2Password.Length)];
            StartGame();

            //Screen password = Screen.Password;
        }*/
        else if (input == "007")
            {
                Terminal.WriteLine("Wow... You suck");
            }
            else
            {
                Terminal.WriteLine("Please select a level");
            }
        }

   






    private void StartGame()
    {
       currentScreen = Screen.Password;
        Terminal.ClearScreen();
       //currentScreen = Screen.MainMenu;

        Terminal.WriteLine($"You have chosen level {level}");
       Terminal.WriteLine("Please enter your password");
        Terminal.WriteLine("Enter your password, hint " + password.Anagram());


    }

   

    // Update is called once per frame
    void Update()
    {
        
    }
}
