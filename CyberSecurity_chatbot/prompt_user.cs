using System;

namespace CyberSecurity_chatbot
{ //start of namespace
    public class prompt_user


    {//global variable declaration, string datatype
        //and variable name called name
        //must be private
        private string name = string.Empty;



        //welcome the user
        public void DisplayWelcomeMessage()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("======================--------------------------------========================");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                      Welcome to AI Cybersecurity chatbot          ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("======================--------------------------------========================");
            Console.ResetColor();
        }


        //void method to prompt the user for name
        //start with access modifier public
        //then type of method void, then name of the
        //method called asking_name()
        public void asking_name()
        { //start of asking name method

            //ask for name

            //AI and colors

            //AI name
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("chatBot : ");

            //AI message
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Please enter your name...");


            //reset color
            Console.ResetColor();

            //do while to check and re-prompt the user
            do
            { //start of do while

                //user entering name
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("user : ");

                //input color
                Console.ForegroundColor = ConsoleColor.Gray;

                name = Console.ReadLine();

                //reset color
                Console.ResetColor();


            } while (!check_name());//end of do while
            AskSecurityQuestions();



        }//end of the asking name method

        //boolean method to check if the user entered name
        //start by the access modifier must be private
        //then the type of method boolean then name of it
        //check_name()
        private Boolean check_name()
        { //start of check_name


            //check if the name is entered using if statement
            if (name == "")
            { //start if statement

                //show error message
                //AI name
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("chatBot : ");

                //AI message
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Please try to enter your name...");

                //reset color
                Console.ResetColor();

                //return false
                return false;
            }//end of if statement
            else
            {//start of else

                //return the success message
                //AI name
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("chatBot : ");

                //AI message
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Hey ");
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(" " + name);
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(" how can i help you");

                //reset color
                Console.ResetColor();
                //return
                return true;

            }//end of else




        }//end of check_name method

        //method to return the username

        public string return_name()
        {//start of return of return name method
            return name;//returning the name of the user

        }
        public void AskSecurityQuestions()
        {
            string[] questions = {
        "Have you noticed any suspicious login attempts? (yes/no)",
        "Do you need help resetting your password? (yes/no)",
        "Would you like to enable multi-factor authentication? (yes/no)",
        "Are you reporting a phishing attempt or malicious email? (yes/no)",
        "Do you want guidance on safe browsing practices? (yes/no)",
        "Have you recently updated your antivirus software? (yes/no)",
        "Do you want to review your account’s recent activity logs? (yes/no)",
        "Would you like tips on creating stronger passwords? (yes/no)",
        "Do you want to learn how to recognize common online scams? (yes/no)",
        "Have you shared your login credentials with anyone? (yes/no)",
        "Do you want to know how to secure your Wi-Fi network? (yes/no)",
        "Would you like to set up alerts for unusual account activity? (yes/no)",
        "Do you need assistance reporting identity theft? (yes/no)",
        "Would you like ongoing cybersecurity tips and updates? (yes/no)"
    };

            foreach (string q in questions)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("chatBot : ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(q);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("user : ");
                Console.ForegroundColor = ConsoleColor.Gray;
                string answer = Console.ReadLine();
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("chatBot : ");
                Console.ForegroundColor = ConsoleColor.Green;
                if (answer.ToLower() == "yes")
                    Console.WriteLine("Thanks, we’ll provide guidance on that.");
                else if (answer.ToLower() == "no")
                    Console.WriteLine("Okay, let’s move on.");
                else
                    Console.WriteLine("Got your response.");
                Console.ResetColor();
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("chatBot : Thank you " + name + ", your cybersecurity checkup is complete!");
            Console.ResetColor();
        }
    }
}
