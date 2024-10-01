//დაწერე პროგრამა, რომელიც დაბეჭდავს 1-დან 100-მდე ციფრებს For ციკლის გამოყენებით.


//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//}


//დაწერე პროგრამა, რომელიც For ციკლის გამოყენებით დაბეჭდავს ყველა ლუწ რიცხვს 1-დან 50-მდე.

//for (int i = 0; i < 50; i++)
//{
//    if (i % 2 == 0)
//    {
//        Console.WriteLine(i);
//    }
//}


//დაწერე პროგრამა, რომელიც While ციკლის გამოყენებით დაითვლის და დაბეჭდავს ყველა რიცხვის ჯამს 1-დან 50-მდე.

//int counter = 0;
//int sum = 0;
//while (counter<50)
//{
//    sum+=counter;
//    Console.WriteLine(sum);
//    counter++;
//}
//დაწერე პროგრამა, რომელიც While ციკლის გამოყენებით 5-ჯერ მოსთხოვს მომხმარებელს შეიყვანოს რიცხვი და დაბეჭდავს ამ რიცხვების ჯამს.

//int counter = 0; 
//int sum = 0;    

//while (counter < 5)
//{
//    Console.WriteLine("Please enter a number:");
//    int number = int.Parse(Console.ReadLine()); 
//    sum += number; 
//    counter++; 
//}

//Console.WriteLine(sum);

//დაწერე პროგრამა, რომელიც მომხმარებელს სთხოვს შეიყვანოს 10-ზე ნაკლები რიცხვი და სანამ რიცხვი არ იქნება
//10-ზე ნაკლები, ისევ მოითხოვს მონაცემის შეყვანას (Do-While ციკლის გამოყენებით).

//Console.Write("Please enter a number: ");
//int number = int.Parse(Console.ReadLine());

//do
//{
//    if (number < 10)
//    {
//        Console.WriteLine("End of operation.");
//        break;
//    }
//    else
//    {
//        Console.WriteLine("Number is greater than 10, please try again.");
//        Console.Write("Please enter a number: "); 
//        number = int.Parse(Console.ReadLine());  
//    }

//} while (number >= 10);


//დაწერე პროგრამა, რომელიც 3-ჯერ დაუსვამს მომხმარებელს კითხვას "Do you want to continue?"
//და თუ პასუხი იქნება "yes", პროგრამა გააგრძელებს ციკლს.

//Console.Write("Do you want to continue?: ");
//string answer = Console.ReadLine();

//int attempts = 0;

//do
//{
//    if (answer != "yes")
//    {
//        Console.WriteLine("stop");
//        break;

//    }
//    attempts++;
//    if (attempts <= 2)
//    {
//        Console.WriteLine("Do you want to continue?");
//        answer = Console.ReadLine();
//    }


//} while (attempts <= 2);

//სავარჯიშო 4: ჩადგმული(Nested) ციკლები
//int rows = 5; 

//for (int i = 0; i < rows; i++)
//{
//    for (int k = 0; k < (i + 1); k++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine();
//}

//დაწერე პროგრამა, რომელიც For ციკლის გამოყენებით დაბეჭდავს რიცხვებს 1-დან 100-მდე, მაგრამ:
//თუ რიცხვი იყოფა 3-ზე, დაბეჭდოს "Fizz"
//თუ რიცხვი იყოფა 5-ზე, დაბეჭდოს "Buzz"
//თუ რიცხვი იყოფა 3-სა და 5-ზე ერთდროულად, დაბეჭდოს "FizzBuzz"

//for (int i = 0; i < 100; i++)
//{
//    Console.WriteLine(i);
//    if (i % 3 == 0)
//    {
//        Console.WriteLine( i +"   " + "Fizz");
//    }
//    if (i % 5 == 0)
//    {
//        Console.WriteLine(i + "   " + "Buzz");
//    }
//    if (i % 3 == 0 && i % 5 == 0)
//    {
//        Console.WriteLine(i + "   " + "FizzBuzz");
//    }
//}

class Program
{
    static void Main(string[] args)
    {

        //decimal totalAmount = CartTotal();
        //Console.WriteLine($"Total amount  is: {totalAmount}");

        //decimal aver = CalculateAverage();
        //Console.WriteLine($"avaerage of your grade is: {aver}");


        decimal BAT = BankAccountTransactions();
        Console.WriteLine($"avaerage of your grade is: {BAT}");

    }

    static void ProcessInput(Func<decimal, bool> process)
    {
        string answer;

        do
        {
            Console.Write("Do you want to continue? (yes/y): ");
            answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "y")
            {
                Console.Write("Enter your value: ");
                decimal value;
                if (decimal.TryParse(Console.ReadLine(), out value))
                {
                    if (!process(value))
                        break;
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a valid number.");
                }
            }
            else if (answer == "no" || answer == "n")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid response. Please enter 'yes' or 'no'.");
            }

        } while (true);
    }

    //სავარჯიშო 1: მომხმარებლის კალათის ჯამი
    //დაწერე პროგრამა, რომელიც მომხმარებელს სთხოვს შეიყვანოს პროდუქტების ფასი. ყველა შეყვანის შემდეგ 
    //პროგრამამ მომხმარებელს უნდა ჰკითხოს სურს თუ არა გაგრძელება. თუ მომხმარებელი შეიყვანს “yes” ან “y” 
    //პროგრამა უნდა გაგრძელდეს და მოითხოვოს მომდევნო ფასის შემოყვანა. ბოლოს პროგრამამ უნდა დაბეჭდოს შეყვანილი
    //პროდუქტების საერთო ღირებულება.
    static decimal CartTotal()
    {
        decimal sum = 0;

        ProcessInput(price =>
        {
            sum += price;
            return true;
        });

        return sum;
    }

    //სავარჯიშო 2: საშუალო ქულის გამოთვლა
    //დაწერე პროგრამა, რომელიც მოსწავლის ქულების შეყვანისას გამოთვლის საშუალო ქულას.
    //პროგრამამ უნდა სთხოვოს მომხმარებელს შეიყვანოს მოსწავლის ქულები.ქულის შეყვანის შემდეგ 
    //პროგრამამ უნდა ჰკითხოს სურს თუ არა გაგრძელება.თუ მომხმარებელი შეიყვანს “yes” ან “y” პროგრამ
    //ა უნდა გაგრძელდეს და მოითხოვოს მომდევნო ქულის შეყვანა. ბოლოს პროგრამამ უნდა დაბეჭდოს საშუალო 
    //ქულა (შეყვანილი ქულების საშუალო არითმეტიკული).
    static decimal CalculateAverage()
    {
        decimal sum = 0;
        int amountofgrade = 0;


        ProcessInput(price =>
        {
            sum += price;
            amountofgrade++;
            return true;
        });

        return amountofgrade > 0 ? sum / amountofgrade : 0;
    }

    //სავარჯიშო 3: საბანკო ანგარიშის ტრანზაქციები
    //დაწერე პროგრამა, რომელიც საბანკო ანგარიშის ტრანზაქციებს ამუშავებს.
    //პროგრამა მომხმარებელს სთხოვს შეიყვანოს ტრანზაქციის ტიპი(შემოსავალი ან ხარჯი) და თანხა.
    //ინფორმაციის  შეყვანის შემდეგ პროგრამამ უნდა ჰკითხოს სურს თუ არა გაგრძელება.
    //თუ მომხმარებელი შეიყვანს “yes” ან “y” პროგრამა უნდა გაგრძელდეს და მოითხოვოს მომდევნო 
    //ტრანზაქციის ტიპის და თანხის შეყვანა.საბოლოოდ პროგრამამ უნდა დაბეჭდოს ხარჯების ჯამი, შემოსავლების
    //ჯამი და ანგარიშის ბალანსი.

    static decimal BankAccountTransactions()
    {
        decimal incomeTotal = 0;
        decimal expenseTotal = 0;

        ProcessInput(amount =>
        {
            Console.Write("Do you want to record income or expense? (income/expense): ");
            string transactionType = Console.ReadLine().ToLower();

            if (transactionType == "income")
            {
                Console.Write("Enter income amount: ");
                if (decimal.TryParse(Console.ReadLine(), out amount))
                {
                    incomeTotal += amount;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
            else if (transactionType == "expense")
            {
                Console.Write("Enter expense amount: ");
                if (decimal.TryParse(Console.ReadLine(), out amount))
                {
                    expenseTotal += amount;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
            else
            {
                Console.WriteLine("Invalid transaction type");
            }

            return true;
        });

        Console.WriteLine($"Total Income: {incomeTotal}");
        Console.WriteLine($"Total Expense: {expenseTotal}");
        Console.WriteLine($"Net Balance: {incomeTotal - expenseTotal}");

        return incomeTotal - expenseTotal;
    }

}
