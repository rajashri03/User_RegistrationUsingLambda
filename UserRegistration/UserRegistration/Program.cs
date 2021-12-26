using UserRegistration_CustomException;
bool status = true;
UserRegistration user = new UserRegistration();
while (status)
{
    Console.WriteLine("Select:\n1)FirstName\n2)LastName\n3)Email\n4)PhoneNumber\n5)PasswordRule1\n6)Password Rule2\n7)Password rule 3");
    int op = Convert.ToInt32(Console.ReadLine());
    switch(op)
    {
        case 1:
            //Check First Name is valid or not
            Console.WriteLine("Enter name");
            string fname = Console.ReadLine();
            string result = user.FirstNameMatch(fname);
            Console.WriteLine(result);
            break;
        case 2:
            //Check Laste name is valid or not
            Console.WriteLine("Enter Last name");
            string lname = Console.ReadLine();
            string lastnameresult = user.LastNameMatch(lname);
            Console.WriteLine($"\n{lastnameresult}");
            break;
        case 3:
            //Check Email is valid or not
            Console.WriteLine("Enter Email(eg.abc.xyz@gmail.com)");
            string email = Console.ReadLine();
            string emailresult = user.EmailMatch(email);
            Console.WriteLine($"\n{emailresult}");
            break;
        case 4:
            //Check PhoneNumber is valid or not
            Console.WriteLine("Enter PhoneNumber(eg.91 8888877655)");
            string phone = Console.ReadLine();
            string phoneresult = user.PhoneMatch(phone);
            Console.WriteLine($"\n{phoneresult}");
            break;
        case 5:
            //Check Password Rule1 -Enter minimum 8 characters
            Console.WriteLine("Enter Password(Minimum 8 characters)");
            string password1 = Console.ReadLine();
            string password1result = user.PasswordRule1Match(password1);
            Console.WriteLine($"\n{password1result}");
            break;
        case 6:
            //Check Password Rule2 -Enter minimum 8 characters and one uppercase letter
            Console.WriteLine("Enter Password(Minimum 8 characters and one uppercase letter)");
            string password2 = Console.ReadLine();
            string password1result2 = user.PasswordRule2Match(password2);
            Console.WriteLine($"\n{password1result2}");
            break;
        case 7:
            //Check Password Rule2 -Enter minimum 8 characters and one uppercase and one special character
            Console.WriteLine("Enter Password(Minimum 8 characters and one uppercase letter)");
            string password3 = Console.ReadLine();
            string password1result3 = user.PasswordRule3Match(password3);
            Console.WriteLine($"\n{password1result3}");
            break;
    }
}
