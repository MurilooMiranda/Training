
class Program
{
    public static void Sum()
    {
        Console.WriteLine("Sum of two numbers.");
        Console.Write("Enter a number: ");
        int inputValue = int.Parse(Console.ReadLine()!);

        Console.Write("Enter another number: ");
        int secondValue = int.Parse(Console.ReadLine()!);

        Console.WriteLine($"The sum is {inputValue + secondValue}.");
        Console.WriteLine();
    }

    public static void Average()
    {
        Console.WriteLine("Average of three numbers.");
        Console.Write("Enter a number: ");
        double inputValue = double.Parse(Console.ReadLine()!);

        Console.Write("Enter another number: ");
        double secondValue = double.Parse(Console.ReadLine()!);

        Console.Write("Enter another number: ");
        double currentValue = double.Parse(Console.ReadLine()!);

        Console.WriteLine($"The average is {(inputValue + secondValue + currentValue) / 3}.");
        Console.WriteLine();
    }

    public static void Temperature()
    {
        Console.WriteLine("Temperature conversion.");
        Console.Write("Enter a temperature in Celsius: ");
        double inputValue = double.Parse(Console.ReadLine()!);

        Console.WriteLine($"Converting to F: {(inputValue * 1.8) + 32} F"); 
        Console.WriteLine();
    }

    public static void CircleArea()
    {
        Console.WriteLine("Calculate the area of a circle.");
        Console.Write("Enter a radius: ");
        double inputValue = double.Parse(Console.ReadLine()!);

        Console.WriteLine($"The area is {inputValue * 3.14159}."); 
        Console.WriteLine();
    }

    public static void Change()
    {
        Console.WriteLine("Calculate change for a product.");
        Console.Write("Enter the product price: ");
        double inputValue = double.Parse(Console.ReadLine()!);

        Console.Write("Enter the payment amount: ");
        double secondValue = double.Parse(Console.ReadLine()!);

        if (inputValue > secondValue)
            Console.WriteLine("Insufficient amount!");

        if (inputValue >= secondValue)
            Console.WriteLine($"Purchase completed! Your change is $ {secondValue - inputValue}.");
        Console.WriteLine();
    }

    public static void NumberSign()
    {
        Console.WriteLine("Identify the sign of a number.");
        Console.Write("Enter a number: ");
        int inputValue = int.Parse(Console.ReadLine()!);

        if (inputValue > 0)
            Console.WriteLine("Positive.");
        else if (inputValue < 0)
            Console.WriteLine("Negative.");
        else
            Console.WriteLine("Zero.");

        Console.WriteLine();
    }

    public static void CompareThree()
    {
        Console.WriteLine("Largest number among three.");
        Console.Write("Enter a number: ");
        double inputValue = double.Parse(Console.ReadLine()!);

        Console.Write("Enter another number: ");
        double secondValue = double.Parse(Console.ReadLine()!);

        Console.Write("Enter another number: ");
        double currentValue = double.Parse(Console.ReadLine()!);

        if (inputValue > secondValue && inputValue > currentValue)
            Console.WriteLine($"The largest number is {inputValue}.");
        else if (secondValue > inputValue && secondValue > currentValue)
            Console.WriteLine($"The largest number is {secondValue}.");
        else if (currentValue > inputValue && currentValue > secondValue)
            Console.WriteLine($"The largest number is {currentValue}.");
        else
            Console.WriteLine("There is no unique largest number.");

        Console.WriteLine();
    }

    public static void Parity()
    {
        Console.WriteLine("Check whether a number is even or odd.");
        Console.Write("Enter a number: ");
        int inputValue = int.Parse(Console.ReadLine()!);

        if (inputValue % 2 == 0)
            Console.WriteLine("Even.");
        else
            Console.WriteLine("Odd.");

        Console.WriteLine();
    }

    public static void Approval()
    {
        Console.WriteLine("Check whether a student passed.");
        Console.Write("Enter a grade: ");
        double inputValue = double.Parse(Console.ReadLine()!);

        Console.Write("Enter another grade: ");
        double secondValue = double.Parse(Console.ReadLine()!);

        if (((inputValue + secondValue) / 2) >= 6)
            Console.WriteLine("Passed.");
        else
            Console.WriteLine("Failed."); 

        Console.WriteLine();
    }

    public static void LeapYear()
    {
        Console.WriteLine("Check whether a year is a leap year.");
        Console.Write("Enter a year: ");
        int inputValue = int.Parse(Console.ReadLine()!);

        if ((inputValue % 4 == 0) && (((inputValue % 100 == 0) && (inputValue % 400 == 0)) || (inputValue % 100 != 0)) && (inputValue != 0))
            Console.WriteLine($"The year {inputValue} is a leap year.");
        else
            Console.WriteLine($"The year {inputValue} is not a leap year.");

        Console.WriteLine();
    }

    public static void CountToN()
    {
        Console.WriteLine("Count numbers from 1 to N.");
        Console.Write("Enter a number: ");
        int inputValue = int.Parse(Console.ReadLine()!);

        for (int index = 1; index <= inputValue; index++)
            Console.WriteLine(index);

        Console.WriteLine();
    }

    public static void SumToN()
    {
        Console.WriteLine("Sum numbers from 1 to N.");
        Console.Write("Enter a number: ");
        int inputValue = int.Parse(Console.ReadLine()!);
        int sum = 0;
        for (int index = 1; index <= inputValue; index++)
            sum += index;

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine();
    }

    public static void MultiplicationTable()
    {
        Console.WriteLine("Print the multiplication table of a number.");
        Console.Write("Enter a number: ");
        int inputValue = int.Parse(Console.ReadLine()!);
        for (int index = 1; index <= 10; index++)
            Console.WriteLine(index * inputValue);

        Console.WriteLine();
    }

    public static void SumEvenNumbers()
    {
        Console.WriteLine("Sum even numbers from 1 to N.");
        Console.Write("Enter a number: ");
        int inputValue = int.Parse(Console.ReadLine()!);
        int sum = 0;
        for (int index = 1; index <= inputValue; index++)
            if (index % 2 == 0)
                sum += index;
        
        Console.WriteLine(sum);
        Console.WriteLine();
    }

    public static void Factorial()
    {
        Console.WriteLine("Calculate the factorial of a number.");
        Console.Write("Enter a number: ");
        int inputValue = int.Parse(Console.ReadLine()!);
        int sum = 1;

        if (inputValue == 0)
        {
            Console.WriteLine("0! = 1");
            Console.WriteLine();
            return;
        }

        for (int index = 1; index <= inputValue; index++)
            sum *= index;

        Console.WriteLine($"Factorial: {sum}");
        Console.WriteLine();
    }

    public static void CharacterCount()
    {
        Console.WriteLine("Count the characters in a string.");
        Console.Write("Enter a string: ");
        string? inputText = Console.ReadLine() ?? string.Empty;
        int count = 0;

        foreach (char currentValue in inputText)
            count++;
        
        if (count > 0)
            Console.WriteLine($"Characters: {count}.");
        else
            Console.WriteLine("Invalid string.");

        Console.WriteLine();
    }

     public static void Vowels()
    {
        Console.WriteLine("Count the vowels in a string.");
        string? inputText = Console.ReadLine() ?? string.Empty;
        int count = 0;

        foreach (char currentValue in inputText.ToLower())
            if (currentValue == 'a' || currentValue == 'e' || currentValue == 'i' || currentValue == 'o' || currentValue == 'u')
                count++;
        
        if (count > 0)
            Console.WriteLine($"There are {count} vowels.");
        else
            Console.WriteLine("Invalid string.");

        Console.WriteLine();
    }

    public static void ReverseString()
    {
        Console.WriteLine("Reverse the characters in a string.");
        Console.Write("Enter a string:");
        string? inputText = Console.ReadLine() ?? string.Empty;
        string auxiliary = string.Empty;

        for (int index = inputText.Length - 1; index >= 0; index--)
        {
            auxiliary += inputText[index];
        }

        Console.WriteLine($"Reversed string: {auxiliary}");
        Console.WriteLine();
    }

    public static void Palindrome()
    {
        Console.WriteLine("Check whether a string is a palindrome.");
        Console.Write("Enter a string: ");
        string? inputText = Console.ReadLine() ?? string.Empty;
        string reversedText = string.Empty;

        for (int index = inputText.Length - 1; index >= 0; index--)
        {
            reversedText += inputText[index];
        }

        if (inputText == reversedText)
            Console.WriteLine("Palindrome.");
        else
            Console.WriteLine("Not a palindrome.");            

        Console.WriteLine();
    }

    public static void RepeatedCharacter()
    {
        Console.WriteLine("Find repeated characters in a string.");
        Console.Write("Enter a string: ");
        string? inputText = Console.ReadLine() ?? string.Empty;
        string auxiliary = string.Empty;

        foreach (char currentValue in inputText)
        {
            if (auxiliary.Contains(currentValue))
            {
                Console.WriteLine($"Repeated character: {currentValue}");
                Console.WriteLine();
                return;
            }

            auxiliary += currentValue;
        }

        Console.WriteLine();
    }

    public static void ArrayMaximum()
    {
        Console.WriteLine("Find the largest number in an array.");
        Console.Write("Enter a number: ");
        int inputValue = int.Parse(Console.ReadLine()!);
        Console.Write($"Enter {inputValue} numbers");
        List<int> numbers = [.. Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse)];
        int largestValue = numbers[0];
        for (int index = 0; index < numbers.Count; index++)
        {
            if (numbers[index] > largestValue)
                largestValue = numbers[index];
        }
        Console.Write($"The largest value is {largestValue}");
        Console.WriteLine();
    }

    public static void ArrayAverage()
    {
        Console.WriteLine("Calculate the average of an array.");
        Console.Write("Enter a number: ");
        int inputValue = int.Parse(Console.ReadLine()!);
        Console.Write($"Enter {inputValue} numbers: ");
        List<int> numbers = [.. Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse)];
        int sum = 0;
        for (int index = 0; index < numbers.Count; index++)
            sum += numbers[index];
        Console.Write($"The average is: {sum / numbers.Count}");
        Console.WriteLine();
    }

    public static void ReverseArray()
    {
        Console.WriteLine("Reverse the numbers in an array.");
        Console.Write("Enter a number: ");
        int inputValue = int.Parse(Console.ReadLine()!);
        Console.Write($"Enter {inputValue} numbers: ");
        List<int> numbers = [.. Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse)];
        int[] auxiliary = new int[numbers.Count];
        for (int index = 0; index < numbers.Count; index++)
            auxiliary[index] = numbers[numbers.Count - 1 - index];
        Console.WriteLine($"Reversed array: {auxiliary}");
        Console.WriteLine();
    }

    public static void RemoveDuplicates()
    {
        Console.WriteLine("Remove duplicate numbers from an array.");
        Console.Write("Enter a number: ");
        int inputValue = int.Parse(Console.ReadLine()!);
        Console.Write($"Enter {inputValue} numbers: ");
        List<int> numbers = [.. Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse)];
        int[] auxiliary = new int[numbers.Count];
        int writeIndex = 0;
        foreach (int currentValue in numbers)
        {
            if (!auxiliary.Contains(currentValue))
                auxiliary[writeIndex++] = currentValue;
        }
        Console.WriteLine($"Array without duplicates: {auxiliary}");
        Console.WriteLine();
    }

    public static void SecondLargest()
    {
        Console.WriteLine("Find the second-largest value in an array.");
        Console.Write("Enter a number: ");
        int inputValue = int.Parse(Console.ReadLine()!);
        Console.Write($"Enter {inputValue} numbers: ");
        List<int> numbers = [.. Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse)];
        int largestValue = numbers[0], secondLargestValue = numbers[1];
        for (int index = 0; index < numbers.Count; index++)
        {
            if (numbers[index] > largestValue)
            {
                secondLargestValue = largestValue;
                largestValue = numbers[index];
            }
            else if (numbers[index] > secondLargestValue && numbers[index] < largestValue)
                secondLargestValue = numbers[index];
        }
        Console.WriteLine($"Second-largest array value: {secondLargestValue}");
        Console.WriteLine();
    }

    public static void Prime()
    {
        Console.WriteLine("Check whether a number is prime.");
        Console.Write("Enter a number: ");
        int inputValue = int.Parse(Console.ReadLine()!);
        int count = 0;
        for (int index = 1; index <= inputValue; index++)
        {
            if (inputValue % index == 0)
                count++;
        }
        if (count >= 2)
            Console.WriteLine("It is prime.");
        else
            Console.WriteLine("It is not prime.");
        Console.WriteLine();
    }

    public static void Maximum()
    {
        Console.WriteLine("Find the larger of two numbers.");
        Console.Write("Enter a number: ");
        int inputValue = int.Parse(Console.ReadLine()!);
        Console.Write("Enter another number: ");
        int secondValue = int.Parse(Console.ReadLine()!);
        if (inputValue > secondValue)
            Console.WriteLine($"{inputValue} is larger than {secondValue}");
        else if (inputValue < secondValue)
            Console.WriteLine($"{secondValue} is larger than {inputValue}");
        else
            Console.WriteLine("They are equal.");
        Console.WriteLine();
    }

    public static void ValidatePassword()
    {
        Console.WriteLine("Check whether a password is valid.");
        Console.Write("Enter a password: ");
        string? inputText = Console.ReadLine() ?? string.Empty;
        bool hasUppercase = false, hasLowercase = false, hasDigit = false;
        foreach (char currentValue in inputText)
        {
            if (char.IsUpper(currentValue)) hasUppercase = true;
            else if (char.IsLower(currentValue)) hasLowercase = true;
            else if (char.IsDigit(currentValue)) hasDigit = true;
        }
        if (inputText.Length >= 8 && hasUppercase && hasLowercase && hasDigit)
            Console.WriteLine("Valid password.");
        else
            Console.WriteLine("Invalid password.");
        Console.WriteLine();
    }

    public static void Statistics()
    {
        Console.WriteLine("Show statistics for an array.");
        Console.Write("Enter a number: ");
        int inputValue = int.Parse(Console.ReadLine()!);
        Console.Write($"Enter {inputValue} numbers: ");
        List<int> numbers = [.. Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse)];
        int largestValue = numbers[0], smallestValue = numbers[0], sum = 0;
        for (int index = 0; index < inputValue; index++)
        {
            if (numbers[index] > largestValue) largestValue = numbers[index];
            if (numbers[index] < smallestValue) smallestValue = numbers[index];
            sum += numbers[index];
        }
        Console.WriteLine($"Largest: {largestValue}");
        Console.WriteLine($"Smallest: {smallestValue}");
        Console.WriteLine($"Average: {sum / numbers.Count}");
        Console.WriteLine();
    }

    public static void Frequency()
    {
        Console.WriteLine("Show the frequency of each number in an array.");
        Console.Write("Enter a number: ");
        int inputValue = int.Parse(Console.ReadLine()!);
        Console.Write($"Enter {inputValue} numbers: ");
        List<int> numbers = [.. Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse)];
        Dictionary<int, int> frequencies = [];
        foreach (int currentValue in numbers)
        {
            if (frequencies.ContainsKey(currentValue)) frequencies[currentValue]++;
            else frequencies[currentValue] = 1;
        }
        foreach (KeyValuePair<int, int> entry in frequencies)
            Console.WriteLine($"Number: {entry.Key}, Frequency: {entry.Value}");
        Console.WriteLine();
    }

    public static void FirstUniqueCharacter()
    {
        Console.WriteLine("Find the first character that appears once.");
        Console.Write("Enter a string: ");
        string? inputText = Console.ReadLine() ?? string.Empty;
        Dictionary<char, int> frequencies = [];
        foreach (char currentValue in inputText)
        {
            if (frequencies.ContainsKey(currentValue)) frequencies[currentValue]++;
            else frequencies[currentValue] = 1;
        }
        foreach (char currentValue in inputText)
        {
            if (frequencies[currentValue] == 1)
            {
                Console.WriteLine($"First unique character: {currentValue}");
                break;
            }
        }
        Console.WriteLine();
    }

    public static void CommonElements()
    {
        Console.WriteLine("Find common elements between two arrays.");
        Console.Write("Enter a number: ");
        int inputValue = int.Parse(Console.ReadLine()!);
        Console.Write($"Enter {inputValue} numbers for the array: ");
        List<int> numbers = [.. Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse)];
        Console.Write($"Enter {inputValue} numbers for the other array: ");
        List<int> secondNumbers = [.. Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse)];
        HashSet<int> commonElements = [];
        for (int index = 0; index < numbers.Count; index++)
        {
            if (numbers[index] == secondNumbers[index]) commonElements.Add(numbers[index]);
        }
        foreach (int currentValue in commonElements)
            Console.WriteLine($"Common element: {currentValue}");
        Console.WriteLine();
    }

    public static void TwoSum()
    {
        Console.Write("Find which pair of elements adds up to the target.");
        Console.Write("Enter a number: ");
        int inputValue = int.Parse(Console.ReadLine()!);
        Console.Write($"Enter {inputValue} elements for the array: ");
        List<int> numbers = [.. Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse)];
        Console.Write("Enter the target number: ");
        int target = int.Parse(Console.ReadLine()!);
        Dictionary<int, int> seenValues = [];
        for (int index = 0; index < inputValue; index++)
        {
            int currentNumber = numbers[index];
            int complement = Math.Abs(target - currentNumber);
            if (seenValues.ContainsKey(complement))
                Console.WriteLine($"Result: {seenValues[complement]}, {index}");
            if (!seenValues.ContainsKey(currentNumber)) seenValues.Add(currentNumber, index);
        }
        Console.WriteLine();
    }

    public static void GroupAnagrams()
    {
        Console.WriteLine("Group words that are anagrams.");
        Console.Write("Enter your string: ");
        string[] inputText = (Console.ReadLine() ?? string.Empty).Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Dictionary<string, List<string>> anagrams = [];
        foreach (string word in inputText)
        {
            char[] letters = word.ToCharArray();
            Array.Sort(letters);
            string sortedKey = new string(letters);
            if (!anagrams.ContainsKey(sortedKey)) anagrams[sortedKey] = [];
            anagrams[sortedKey].Add(word);
        }
        Console.WriteLine($"Anagrams:{anagrams.Values.Select(group => group.ToList()).ToList()}");
        Console.WriteLine();
    }

    static void Main()
    {
        int option;
        do
        {
            Console.WriteLine("===== FUNCTION MENU =====");
            Console.WriteLine("1 - Sum"); Console.WriteLine("2 - Average"); Console.WriteLine("3 - Temperature");
            Console.WriteLine("4 - Circle area"); Console.WriteLine("5 - Change"); Console.WriteLine("6 - Number sign");
            Console.WriteLine("7 - Compare three numbers"); Console.WriteLine("8 - Parity"); Console.WriteLine("9 - Approval");
            Console.WriteLine("10 - Leap year"); Console.WriteLine("11 - Count to N"); Console.WriteLine("12 - Sum to N");
            Console.WriteLine("13 - Multiplication table"); Console.WriteLine("14 - Sum even numbers"); Console.WriteLine("15 - Factorial");
            Console.WriteLine("16 - Character count"); Console.WriteLine("17 - Vowels"); Console.WriteLine("18 - Reverse string");
            Console.WriteLine("19 - Palindrome"); Console.WriteLine("20 - Repeated character"); Console.WriteLine("21 - Array maximum");
            Console.WriteLine("22 - Array average"); Console.WriteLine("23 - Reverse array"); Console.WriteLine("24 - Remove duplicates");
            Console.WriteLine("25 - Second largest"); Console.WriteLine("26 - Prime"); Console.WriteLine("27 - Maximum");
            Console.WriteLine("28 - Validate password"); Console.WriteLine("29 - Statistics"); Console.WriteLine("30 - Frequency");
            Console.WriteLine("31 - First unique character"); Console.WriteLine("32 - Common elements"); Console.WriteLine("33 - Two sum");
            Console.WriteLine("34 - Group anagrams"); Console.WriteLine("0 - Exit"); Console.Write("Choose an option: ");
            option = int.Parse(Console.ReadLine()!); Console.WriteLine();
            switch (option)
            {
                case 1: Sum(); break; case 2: Average(); break; case 3: Temperature(); break; case 4: CircleArea(); break;
                case 5: Change(); break; case 6: NumberSign(); break; case 7: CompareThree(); break; case 8: Parity(); break;
                case 9: Approval(); break; case 10: LeapYear(); break; case 11: CountToN(); break; case 12: SumToN(); break;
                case 13: MultiplicationTable(); break; case 14: SumEvenNumbers(); break; case 15: Factorial(); break;
                case 16: CharacterCount(); break; case 17: Vowels(); break; case 18: ReverseString(); break; case 19: Palindrome(); break;
                case 20: RepeatedCharacter(); break; case 21: ArrayMaximum(); break; case 22: ArrayAverage(); break; case 23: ReverseArray(); break;
                case 24: RemoveDuplicates(); break; case 25: SecondLargest(); break; case 26: Prime(); break; case 27: Maximum(); break;
                case 28: ValidatePassword(); break; case 29: Statistics(); break; case 30: Frequency(); break; case 31: FirstUniqueCharacter(); break;
                case 32: CommonElements(); break; case 33: TwoSum(); break; case 34: GroupAnagrams(); break;
                case 0: Console.WriteLine("Exiting..."); break; default: Console.WriteLine("Invalid option."); break;
            }
            Console.WriteLine();
        } while (option != 0);
    }
}