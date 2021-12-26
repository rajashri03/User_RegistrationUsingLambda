using UserRegistration_CustomException;
bool status = true;
UserRegistration user = new UserRegistration();
while (status)
{
    Console.WriteLine("Select:\n1)FirstName\n2)LastName");
    int op = Convert.ToInt32(Console.ReadLine());
    switch(op)
    {
        case 1:
            /// <summary>
            /// Check First Name is valid or not
            /// </summary>
            Console.WriteLine("Enter name");
            string fname = Console.ReadLine();
            string result = user.FirstNameMatch(fname);
            Console.WriteLine(result);
            break;
        case 2:
            /// <summary>
            /// Check First Name is valid or not
            /// </summary>
            Console.WriteLine("Enter Last name");
            string lname = Console.ReadLine();
            string lastnameresult = user.LastNameMatch(lname);
            Console.WriteLine($"\n{lastnameresult}");
            break;
    }
}
