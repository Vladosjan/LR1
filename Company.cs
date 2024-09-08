using System; 

public class Company
{ 
    public string Names { get; set; } 
    public string Industrys { get; set; } 
    public int CountOfEmployees { get; set; } 
    public string Revenues { get; set; } 

    public Company(string names, string industrys, int countOfEmployees, string revenues) 
    { 
        Names = names; 
        Industrys = industrys;
        CountOfEmployees = countOfEmployees;
        Revenues = revenues;
    } 

    public void InforPrint()
    { 
        Console.WriteLine($"The name of company: {Names}, The industry of company: {Industrys}, The count of employees: {CountOfEmployees}, The revenues of company: {Revenues}");
    }
}

public class CompController 
{  
    public static void Main() 
    { 
        // Створюємо екземпляр компанії
        Company company1 = new Company("Google", "Software", 80000, "10M");

        // Викликаємо метод для виведення інформації
        company1.InforPrint(); 

        // Генеруємо випадкове число
        Random random1 = new Random();
        int randNumber = random1.Next(0, 101); 

        // Виводимо випадкове число
        Console.WriteLine($"Random number: {randNumber}");
    }
}
