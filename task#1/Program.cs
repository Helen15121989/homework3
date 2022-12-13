//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

//14212 -> нет
//12821 -> да
//23432 -> да


Console.WriteLine ("Введите пятизначное число");
int number = int.Parse (Console.ReadLine());

void GetPalindromicNumber (int number)
{
    if (number>=10000)
    {
        int firstnumber = number / 10000;
        int remains = number % 10;
        if (firstnumber == remains )

        
        {
            number = number /10;
            int secondnumber = (number/100) % 10;
            int remainsto = number % 10;
            if (secondnumber == remainsto)
            Console.WriteLine ("Число является палиндромом");
        }
        else 
        Console.WriteLine ("Число не является палиндромом");
    }
   
}


GetPalindromicNumber (number);

