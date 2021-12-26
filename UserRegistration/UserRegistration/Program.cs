using UserRegistration_CustomException;
bool status = true;
UserRegistration user = new UserRegistration();
while (status)
{
    Console.WriteLine("Select:\n1)FirstName\n2)LastName\n3)Email");
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
    }
}
