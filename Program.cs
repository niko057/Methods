using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Reqem daxil edin:");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Daxil etdiyiniz reqem: " + number);

        bool isPrime = IsPrime(number);
        Console.WriteLine($"{number} Sade ededdir? {isPrime}");

        Console.WriteLine("İmtahan qiymetlerini aralarında bosluq qoyaraq daxil edin:");
        string input = Console.ReadLine(); 
        string[] gradesString = input.Split(' '); 

        int[] grades = new int[gradesString.Length];
        for (int i = 0; i < gradesString.Length; i++)
        {
            grades[i] = int.Parse(gradesString[i]); 
        }

        double average = CalcAvg(grades); 
        Console.WriteLine("Ortalama: " + average);

        
        if (average > 60)
        {
            Console.WriteLine("Mezun oldunuz");
        }
        else
        {
            Console.WriteLine("Mezun ola bilmediniz");
        }
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }
        else if (number <= 3)
        {
            return true;
        }
        else if (number % 2 == 0 || number % 3 == 0)
        {
            return false;
        }
        int i = 5;
        while (i * i <= number)
        {
            if (number % i == 0 || number % (i + 2) == 0)
            {
                return false;
            }
            i += 6;
        }
        return true;
    }


    static double CalcAvg(int[] grades)
    {
        if (grades.Length == 0)
        {
            return 0;
        }

        int sum = 0;
        foreach (int grade in grades)
        {
            sum += grade;
        }

        return (double)sum / grades.Length; 


    }
}
