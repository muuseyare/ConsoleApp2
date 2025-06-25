using System;

class Program
{
    static void Main()
    {
       
        string name = "Ali Ahmed";
        string motherName = "Fadumo Hassan";
        DateTime dob = new DateTime(2000, 5, 12); 
        string pob = "Mogadishu";
        string email = "ali@example.com";
        char sex = 'M'; 
        string telephone = "+252611234567";
        string status = "Single"; 

        Console.WriteLine("Personal Information:");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Mother's Name: {motherName}");
        Console.WriteLine($"Date of Birth: {dob.ToShortDateString()}");
        Console.WriteLine($"Place of Birth: {pob}");
        Console.WriteLine($"Email: {email}");
        Console.WriteLine($"Sex: {sex}");
        Console.WriteLine($"Telephone: {telephone}");
        Console.WriteLine($"Status: {status}");
    
    }
}