using System;

public class Person
{
    // Özellikler (properties)
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }

    // Bilgileri ekrana yazdıran metod
    public void DisplayInfo()
    {
        Console.WriteLine($"Ad: {FirstName}, Soyad: {LastName}, Doğum Tarihi: {BirthDate.ToShortDateString()}");
    }
}

class ConsoleApp23
{
    static void Main(string[] args)
    {
        // Öğrencilerden nesneler oluşturma ve özelliklerini atama
        Person student1 = new Person();
        student1.FirstName = "Ahmet";
        student1.LastName = "Yılmaz";
        student1.BirthDate = new DateTime(2005, 5, 20);

        Person student2 = new Person();
        student2.FirstName = "Ayşe";
        student2.LastName = "Kara";
        student2.BirthDate = new DateTime(2006, 8, 15);

        // Öğretmenlerden nesneler oluşturma ve özelliklerini atama
        Person teacher1 = new Person();
        teacher1.FirstName = "Mehmet";
        teacher1.LastName = "Demir";
        teacher1.BirthDate = new DateTime(1980, 11, 5);

        Person teacher2 = new Person();
        teacher2.FirstName = "Fatma";
        teacher2.LastName = "Çelik";
        teacher2.BirthDate = new DateTime(1975, 2, 28);

        // Bilgileri konsola yazdırma
        Console.WriteLine("Öğrenciler:");
        student1.DisplayInfo();
        student2.DisplayInfo();

        Console.WriteLine("\nÖğretmenler:");
        teacher1.DisplayInfo();
        teacher2.DisplayInfo();
    }
}
