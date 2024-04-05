// Assuming 'profile' is a List or array of strings and you want to extract the token safely
string token = string.Empty; // Initialize the token as an empty string

// Check if the 'profile' has at least two elements to avoid IndexOutOfRangeException
if (profile.Length > 1)
{
    token = profile[1]; // Assign the second element of 'profile' to 'token'
}
else
{
    // Handle the case where 'profile' does not have a second element
    // You can log an error, throw an exception, or handle it as per your application's needs
    Console.WriteLine("Profile does not contain enough elements.");
}

// Further code that uses 'token'
