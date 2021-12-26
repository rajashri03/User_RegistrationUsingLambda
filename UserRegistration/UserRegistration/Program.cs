using UserRegistration_CustomException;

/// <summary>
/// Check First Name is valid or not
/// </summary>
UserRegistration user = new UserRegistration();
Console.WriteLine("Enter name");
string fname = Console.ReadLine();
string result = user.FirstNameMatch(fname);
Console.WriteLine(result);