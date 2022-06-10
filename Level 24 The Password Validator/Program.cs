{
    //holds loop open forever as called for in the program guidelines. 
    int holdLoop = 1;


    while (holdLoop == 1)
    {
        //temporary container for user input. Will be used to pass into the constructor.
        string attemptedPassword;

        Console.Write("Passwords must contain 1 uppercase letter, 1 lowercase letter, and 1 number. The use of 'T' and '&' is prohibited." +
            "\n Please enter your new password: ");

        attemptedPassword = Console.ReadLine();

        //calls for the constructor
        PasswordValidator userInput = new PasswordValidator(attemptedPassword);
    }
}
class PasswordValidator
{
    private string _password;

    public PasswordValidator(string password)
    {
        if (password.Length < 14 && password.Length > 5) //checks for length requirements
        {
            int upperCount = 0;
            int lowerCount = 0;
            int numCount = 0;

            foreach (char letter in password)
            {
                if (letter == 'T' || letter == '&') //checks for specificed characaters to be disallowed.
                {
                    Console.Write("Invalid input. Your password must not contain 'T' or '&'.");
                    return;
                }
                else if (char.IsUpper(letter) == true) //upper validation
                {
                    upperCount++;
                }
                else if (char.IsLower(letter) == true) //lower validation
                {
                    lowerCount++;
                }
                else if (char.IsDigit(letter) == true) //number validation
                {
                    numCount++;
                }
                

            }

            if (upperCount >= 1 && lowerCount >= 1 && numCount >= 1) //verifys that the upper, lower, and number conditions have been satisfied.
            {
                _password = password;
                Console.WriteLine($"Your new password ({password}) has been set.\n\n");

            }

        }
        else
        {
            Console.WriteLine("Your input was not valid. "); //rejection for too short or too long entries.
        }

    }
}