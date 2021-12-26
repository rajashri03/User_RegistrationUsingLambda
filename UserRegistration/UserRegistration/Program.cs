using UserRegistration_CustomException;

UserRegistration user = new UserRegistration();
Console.WriteLine("**********User Registration****************");
Console.WriteLine("Enter Firstname");
string Firstname = Console.ReadLine();
string opt=user.FirstnameCheckusingLambda(Firstname);
if(opt== "FirstName is Valid")
{
    Console.ForegroundColor=ConsoleColor.Green;
    Console.WriteLine(opt);
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(opt);
    Console.ResetColor();

}
Console.WriteLine("Enter Last Name");
string LastName = Console.ReadLine();
string opt2 = user.LastnameCheckusingLambda(LastName);
if (opt2 == "LastName is Valid")
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(opt2);
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(opt2);
    Console.ResetColor();

}
Console.WriteLine("Enter Email");
string Email = Console.ReadLine();
string opt3 = user.EmailCheckusingLambda(Email);
if (opt3 == "Email is Valid")
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(opt3);
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(opt3);
    Console.ResetColor();

}
Console.WriteLine("Enter Phone Number");
string Phone = Console.ReadLine();
string opt4 = user.PhoneCheckusingLambda(Phone);
if (opt4 == "Phone is Valid")
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(opt4);
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(opt4);
    Console.ResetColor();

}
Console.WriteLine("Enter Password");
string Password = Console.ReadLine();
string opt5 = user.PasswordCheckusingLambda(Password);
if (opt5 == "Password is Valid")
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(opt5);
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(opt5);
    Console.ResetColor();

}

