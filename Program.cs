// GlitchyCoderr's first C# project
List<string>usernames = new List<string>();
        List<string>passwords = new List<string>();
        
        void ListUsers()
        {
            foreach (string name in usernames)
            {
                Console.Write(name + ", ");
            }
            Console.WriteLine("\n(Type 'Exit' to exit to the Operations Menu)");
            string? choice2 = Console.ReadLine();
            while (choice2 != "Exit")
            {
                Console.WriteLine("Invalid input please try again");
                choice2 = Console.ReadLine();
            }
            if (choice2 == "Exit")
            {
                Console.WriteLine("Exit successful");
                ProgramsOperationsMenu();
            }
        }

        void CreateUser()
        {
            Console.WriteLine("Enter a username:");
            string? enteredUsername = Console.ReadLine();
            Console.WriteLine("Enter a Password:");
            string? enteredPassword = Console.ReadLine();
            while (enteredUsername == "" && enteredPassword == "")
            {
                Console.WriteLine("--Invalid input please try again--");
                Console.Write("\n");
                Console.WriteLine("Enter a username:");
                enteredUsername = Console.ReadLine();
                Console.WriteLine("Enter a password:");
                enteredPassword = Console.ReadLine();
            }
            if (enteredUsername != "" && enteredPassword != "")
            {
                usernames.Add(enteredUsername!);
                passwords.Add(enteredPassword!);
                Console.WriteLine("User created successfully");
                Console.Write("\n");
                LogInProcess();
            }
        }

        void ProgramsOperationsMenu()
        {
            Console.WriteLine("-List Users (Type '1')--Create User (Type '2')--Exit (Type Exit)-");
            string? choice = Console.ReadLine();
            
            while (choice == "")
            {
                Console.WriteLine("Invalid input please try again");
                Console.Write("\n");
                Console.WriteLine("-List Users (Type '1')--Create User (Type '2')--Exit (Type Exit)-");
                choice = Console.ReadLine();
            }
            while (choice != "1" && choice != "2" && choice != "Exit")
            {
                Console.WriteLine("-List Users (Type '1')--Create User (Type '2')--Exit (Type Exit)-");
                choice = Console.ReadLine();
            }
            if (choice == "1")
            {
                ListUsers();
            }
            else if (choice == "2")
            {
                CreateUser();
            }
            else if (choice == "Exit")
            {
                Console.WriteLine("Exit successful");
            }
                
        }

        void LogInProcess()
        {
            Console.WriteLine("Enter your credentials");

            Console.WriteLine("Username:");
            string? inputed_username = Console.ReadLine();
            Console.WriteLine("Password:");
            string? inputed_password = Console.ReadLine();

            while (inputed_username == "" && inputed_password == "")
            {
                Console.WriteLine("Invalid input please try again");
                Console.Write("\n");
                Console.WriteLine("Username:");
                inputed_username = Console.ReadLine();
                Console.WriteLine("Password:");
                inputed_password = Console.ReadLine();
            }

            if (usernames.Contains(inputed_username!) && passwords.Contains(inputed_password!))
            {
                Console.WriteLine("Access Granted");
                ProgramsOperationsMenu();
            }
            else
            {
                Console.WriteLine("--Invalid credentials please try again--");
                StartUpChoice();
            }    
        }
        
        Console.WriteLine("---Welcome to MetaAppleZonGleFlix---\n---PRESS ANY KEY TO START---");
        Console.ReadKey();

        void StartUpChoice()
        {
            Console.WriteLine("Sign Up OR Log In");
            string? LogInOrSignUpinput = Console.ReadLine();

            while (LogInOrSignUpinput == "")
            {
                Console.WriteLine("Invalid input please try again");
                Console.Write("\n");
                Console.WriteLine("Sign Up OR Log In");
                LogInOrSignUpinput = Console.ReadLine();
            }
            while (LogInOrSignUpinput != "Log In" && LogInOrSignUpinput != "Sign Up")
            {
                Console.WriteLine("Invalid input please try again");
                Console.Write("\n");
                Console.WriteLine("Sign Up OR Log In");
                LogInOrSignUpinput = Console.ReadLine();
            }
            if (LogInOrSignUpinput == "Log In")
            {
                LogInProcess();
            }
            else if (LogInOrSignUpinput == "Sign Up")
            {
                CreateUser();
            }

        }
        
        StartUpChoice();
