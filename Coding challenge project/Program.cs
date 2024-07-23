//Increment and Decrement

using System.Collections.Generic;

int counter = 5;
counter += 2;
Console.WriteLine("First Increment:" + counter);
counter++;
Console.WriteLine("Second Increment:" + counter);
counter = counter + 1;
Console.WriteLine("Third Increment:" + counter);
counter -= 2;
Console.WriteLine("First Decrement:" + counter);
counter--;
Console.WriteLine("Second Decrement:" + counter);
counter = counter - 1;
Console.WriteLine("Third Decrement:" + counter);



//Increment and Decrement order

int value = 1;
Console.WriteLine("First: " + value++); // value is used before incrementing
Console.WriteLine("Second: " + value);
Console.WriteLine("Third: " + value++); // value is used after incrementing
Console.WriteLine("Fourth: " + value);

int value = 1;
Console.WriteLine("First: " + ++value); // value is incremented before using
Console.WriteLine("Second: " + value);
value++;
Console.WriteLine("Third: " + value);


// Converting to Celsius

int fahrenheit = 212;
double temperature = (fahrenheit - 32) * 5.0 / 9.0;
Console.WriteLine($"The temperature is {temperature:F2} degrees Celsius");

int fahrenheit = 212;
double temperature = (fahrenheit - 32.0) * 5.0 / 9.0;
Console.WriteLine($"The temperature is {Math.Round(temperature, 2)} degrees Celsius");



// Generating Random Numbers

Random randomGenerator = new Random();
int randomNumber = randomGenerator.Next(1, 100); // generates a random number between 1 and 100
int randomDigit = randomGenerator.Next(0, 10); // generates a random digit between 0 and 9
int randomScore = randomGenerator.Next(50, 101); // generates a random score between 50 and 100

Console.WriteLine($"Random Number: {randomNumber}");
Console.WriteLine($"Random Digit: {randomDigit}");
Console.WriteLine($"Random Score: {randomScore}");



// Dice Game

Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3}");

if (roll1 == roll2 && roll2 == roll3)
{
    Console.WriteLine("You rolled triples! +9 bonus to total!");
    total += 9;
}
else if (roll1 == roll2 || roll2 == roll3 || roll1 == roll3)
{
    Console.WriteLine("You rolled doubles! +3 bonus to total!");
    total += 3;
}

if (total >= 18)
{
    Console.WriteLine("You win big!");
}
else if (total >= 12)
{
    Console.WriteLine("You win!");
}
else
{
    Console.WriteLine("Sorry, you lose.");
}


// Exercise: If else

Random random = new Random();
int daysUntilBirthday = random.Next(30);
int giftDiscount = 0;

if (daysUntilBirthday == 0)
{
    Console.WriteLine("Happy Birthday!");
}
else if (daysUntilBirthday == 1)
{
    giftDiscount = 20;
    Console.WriteLine("Your birthday is tomorrow!");
    Console.WriteLine("Get " + giftDiscount + "% off on all gifts!");
}
else if (daysUntilBirthday <= 7)
{
    giftDiscount = 15;
    Console.WriteLine("Your birthday is in " + daysUntilBirthday + " days.");
    Console.WriteLine("Get " + giftDiscount + "% off on all gifts!");
}
else if (daysUntilBirthday <= 14)
{
    giftDiscount = 10;
    Console.WriteLine("Your birthday is in " + daysUntilBirthday + " days.");
    Console.WriteLine("Get " + giftDiscount + "% off on all gifts!");
}
else
{
    Console.WriteLine("Your birthday is in " + daysUntilBirthday + " days.");
    Console.WriteLine("Start planning your birthday celebration!");
}


// Array Challenge

string[] emailAddresses = { "john@example.com", "jane@example.org", "bob@example.net", "alice@example.edu", "john@example.io", "charlie@example.com" };

foreach (string emailAddress in emailAddresses)
{
    if (emailAddress.EndsWith("example.com"))
    {
        Console.WriteLine(emailAddress);
    }
}

// Another array challenge

/*
  The following code creates five random StudentIDs
  to test the student database.  StudentIDs 
  consist of a letter from K to O, and a four
  digit number. Ex. K1234.
*/
Random random = new Random();
string[] studentIDs = new string[5];

for (int i = 0; i < studentIDs.Length; i++)
{
    int prefixValue = random.Next(75, 80);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 10000).ToString("0000");

    studentIDs[i] = prefix + suffix;
}

foreach (var studentID in studentIDs)
{
    Console.WriteLine(studentID);
}

// Data types

Console.WriteLine("Unsigned integral type:");
Console.WriteLine($"byte : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong : {ulong.MinValue} to {ulong.MaxValue}");


// Array reverse and Sort

int[] numbers = { 5, 2, 8, 1, 9 };
Console.WriteLine("Sorted....");
Array.Sort(numbers);
foreach (int number in numbers)
{
    Console.WriteLine($"--{number}");
}

Console.WriteLine("Reverse....");
Array.Reverse(numbers);
foreach (int number in numbers)
{
    Console.WriteLine($"--{number}");
}


// Array.Clear

int[] scores = { 90, 70, 80, 95, 60 };
Console.WriteLine("Before:");
foreach (var score in scores)
{
    Console.WriteLine($"-- {score}");
}

Array.Clear(scores, 1, 2);
Console.WriteLine("After:");
foreach (var score in scores)
{
    Console.WriteLine($"-- {score}");
}


HashSet Challenge

HashSet<string> uniqueWords = new HashSet<string>();

string[] words = { "apple", "banana", "apple", "orange", "banana", "grape" };

foreach (string word in words)
{
    uniqueWords.Add(word.ToLower());
}

Console.WriteLine("Unique words: " + uniqueWords.Count);
