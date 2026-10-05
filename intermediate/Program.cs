class Program
{
    public static void BalancedParentheses()
    {
        Console.WriteLine("Check whether the parentheses are balanced.");
        Console.Write("Enter a string: ");
        string inputText = Console.ReadLine() ?? string.Empty;

        if (string.IsNullOrWhiteSpace(inputText))
        {
            Console.WriteLine("Enter a valid string.");
            return;
        }
        if (inputText.Any(character =>
            character != '(' && character != '{' && character != '[' &&
            character != ')' && character != '}' && character != ']'))
        {
            Console.WriteLine("Enter a valid character.");
            return; 
        }

        Stack<char> stack = [];

        foreach (char currentCharacter in inputText)
        {
            if (currentCharacter == '(' || currentCharacter == '[' || currentCharacter == '{')
                stack.Push(currentCharacter);
            else if (currentCharacter == ')' || currentCharacter == ']' || currentCharacter == '}')
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine("There is no valid closing bracket.");
                    return;
                }

                char openingBracket = stack.Pop();

                if (
                    (currentCharacter == ')' && openingBracket != '(') ||
                    (currentCharacter == ']' && openingBracket != '[') ||
                    (currentCharacter == '}' && openingBracket != '{')
                )
                {
                    Console.WriteLine("There is no valid closing bracket.");
                    return;
                }
            }
        }

        if (stack.Count > 0)
        {
            Console.WriteLine("There is no valid closing bracket.");
            return;
        }

        Console.WriteLine("The brackets are balanced!");
        Console.WriteLine();
    }

    public static void ReverseString()
    {
        Console.WriteLine("Reverse the characters in a string.");
        Console.Write("Enter a string: ");
        string inputText = Console.ReadLine() ?? string.Empty;

        if (string.IsNullOrWhiteSpace(inputText))
        {
            Console.WriteLine("Enter a valid string.");
            return;
        }

        Stack<char> stack = [];

        foreach (char currentCharacter in inputText)
            stack.Push(currentCharacter);

        Console.Write("Reverse: ");
        foreach (char currentCharacter in inputText)
        {
            var reversedCharacter = stack.Pop();
            Console.Write($"{reversedCharacter} ");
        }

        Console.WriteLine();
    }

    public static void FirstNonRepeatingCharacter()
    {
        Console.WriteLine("Find the first non-repeating character.");
        Console.Write("Enter a string: ");
        string inputText = Console.ReadLine() ?? string.Empty;

        if (string.IsNullOrWhiteSpace(inputText))
        {
            Console.WriteLine("Enter a valid string.");
            return;
        }

        Dictionary<char, int> characterFrequency = [];

        foreach (char currentCharacter in inputText)
        {
            if (characterFrequency.TryGetValue(currentCharacter, out int frequency))
                characterFrequency[currentCharacter] = ++frequency;
            else
                characterFrequency.Add(currentCharacter, 1);
        }

        bool foundUniqueCharacter = false;

        foreach (char currentCharacter in inputText)
        {
            if (characterFrequency[currentCharacter] == 1)
            {
                Console.WriteLine($"{currentCharacter} is the first character that appears only once.");
                foundUniqueCharacter = true;
                break;
            }
        }

        if (!foundUniqueCharacter)
            Console.WriteLine("There is no character that appears only once.");

        Console.WriteLine();
    }

    public static void QueueSimulator()
    {
        Console.WriteLine("Simulate a queue of people entering and leaving.");
        Queue<string> queue = [];
        int option;

        do
        {
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - Add a person");
            Console.WriteLine("2 - Remove a person");
            Console.WriteLine("3 - View the queue");
            Console.Write("Choose an option: ");
            option = int.Parse(Console.ReadLine() ?? string.Empty);

            switch (option)
            {
                case 1:
                    Console.Write("Enter the person's name: ");
                    string personName = Console.ReadLine() ?? string.Empty;
                    queue.Enqueue(personName);
                    Console.WriteLine("Person added.");
                    Console.WriteLine();
                    break;
                case 2:
                    queue.Dequeue();
                    Console.WriteLine("The first person in the queue was removed.");
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine($"Queue: {string.Join(", ", queue)}");
                    Console.WriteLine();
                    break;
                default:
                    break;
            }
        } while (option != 0);

        Console.WriteLine("Thank you!");
        Console.WriteLine();
    }

    public static void NumberFrequencyCounter()
    {
        Console.WriteLine("Count how many times each number appears in a sequence.");
        Console.Write("Enter the array: ");
        List<int> numbers = [.. Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse)];

        Dictionary<int, int> numberFrequency = [];

        foreach (int number in numbers)
        {
            if (numberFrequency.TryGetValue(number, out int frequency))
                numberFrequency[number] = ++frequency;
            else
                numberFrequency.Add(number, 1);
        }

        foreach (int number in numberFrequency.Keys)
            Console.WriteLine($"Number: {number}, Frequency: {numberFrequency[number]}");

        Console.WriteLine();
    }

    public static void RemoveDuplicatesWhilePreservingOrder()
    {
        Console.WriteLine("Remove duplicates from an array while preserving order.");
        Console.Write("Enter the array: ");
        List<int> numbers = [.. Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse)];

        Dictionary<int, int> numberDictionary = [];
        Queue<int> orderedNumbers = [];

        foreach (int number in numbers)
            if (numberDictionary.TryAdd(number, 1))
                orderedNumbers.Enqueue(number);

        while (orderedNumbers.Count > 0)
            Console.Write($"{orderedNumbers.Dequeue()} ");
    }

    public static void TwoSum()
    {
        Console.WriteLine("Find two numbers whose sum equals a target value.");
        Console.Write("Enter the array: ");
        List<int> numbers = [.. Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse)];
        Console.Write("Enter the target number: ");
        int target = int.Parse(Console.ReadLine() ?? string.Empty);

        HashSet<int> numbersSeen = [];
        foreach (int number in numbers)
        {
            int complement = target - number;

            if (numbersSeen.Contains(complement))
            {
                Console.WriteLine($"Target {target} found by adding {number} and {complement}.");
                return;
            }
            else
                numbersSeen.Add(number);
        }

        Console.WriteLine("Target not found.");
        Console.WriteLine();
    }

    public static void PalindromeChecker()
    {
        Console.WriteLine("Check whether a string is a palindrome.");
        Console.Write("Enter a string: ");
        string inputText = Console.ReadLine() ?? string.Empty;

        Stack<char> stack = [];

        foreach (char currentCharacter in inputText)
            stack.Push(currentCharacter);

        char[] reversedText = new char[inputText.Length];
        int index = 0;

        foreach (char currentCharacter in inputText)
            reversedText[index++] = stack.Pop();

        if (new string(reversedText) == inputText)
            Console.WriteLine("It is a palindrome.");
        else
            Console.WriteLine("It is not a palindrome.");
    }

    public static void BrowserHistory()
    {
        Console.WriteLine("Simulate browsing history operations.");
        Stack<string> history = [];
        int option;

        do
        {
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - Visit a website");
            Console.WriteLine("2 - Go back to the previous website");
            Console.WriteLine("3 - View browsing history");
            Console.Write("Choose an option: ");
            option = int.Parse(Console.ReadLine() ?? string.Empty);

            switch (option)
            {
                case 1:
                    Console.Write("Enter the website name: ");
                    string websiteName = Console.ReadLine() ?? string.Empty;
                    history.Push(websiteName);
                    Console.WriteLine($"You are on {websiteName}.");
                    Console.WriteLine();
                    break;
                case 2:
                    history.Pop();
                    Console.WriteLine("You went back to the previous website.");
                    Console.WriteLine();
                    break;
                case 3:
                    Console.WriteLine($"You are on {history.Peek()}.");
                    Console.WriteLine($"History: {string.Join(", ", history)}");
                    Console.WriteLine();
                    break;
                default:
                    break;
            }
        } while (option != 0);

        Console.WriteLine("Thank you!");
        Console.WriteLine();
    }

    public static void GroupAnagrams()
    {
        Console.WriteLine("Group words that are anagrams of each other.");
        Console.Write("Enter the words: ");
        List<string> words = [.. (Console.ReadLine() ?? string.Empty)
            .Split([' ', ','], StringSplitOptions.RemoveEmptyEntries)];

        Dictionary<string, List<string>> anagrams = [];

        foreach (string word in words)
        {
            char[] letters = word.ToCharArray();
            Array.Sort(letters);

            string sortedKey = new(letters);

            if (anagrams.TryGetValue(sortedKey, out List<string>? group))
                group.Add(word);
            else
                anagrams[sortedKey] = [word];
        }

        string formattedGroups = string.Join(", ",
            anagrams.Values.Select(group => $"[{string.Join(", ", group)}]"));
        Console.WriteLine($"Anagrams: [{formattedGroups}]");
        Console.WriteLine();
    }

    static void Main()
    {
        int option;
        do
        {
            Console.WriteLine("===== FUNCTION MENU =====");
            Console.WriteLine("1 - Balanced parentheses");
            Console.WriteLine("2 - Reverse string");
            Console.WriteLine("3 - First non-repeating character");
            Console.WriteLine("4 - Queue simulator");
            Console.WriteLine("5 - Number frequency counter");
            Console.WriteLine("6 - Remove duplicates preserving order");
            Console.WriteLine("7 - Two sum");
            Console.WriteLine("8 - Palindrome checker");
            Console.WriteLine("9 - Browser history");
            Console.WriteLine("10 - Group anagrams");
            Console.WriteLine("0 - Exit");
            Console.Write("Choose an option: ");
            option = int.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine();

            switch (option)
            {
                case 1: BalancedParentheses(); break;
                case 2: ReverseString(); break;
                case 3: FirstNonRepeatingCharacter(); break;
                case 4: QueueSimulator(); break;
                case 5: NumberFrequencyCounter(); break;
                case 6: RemoveDuplicatesWhilePreservingOrder(); break;
                case 7: TwoSum(); break;
                case 8: PalindromeChecker(); break;
                case 9: BrowserHistory(); break;
                case 10: GroupAnagrams(); break;
                case 0: Console.WriteLine("Exiting..."); break;
                default: Console.WriteLine("Invalid option."); break;
            }

            Console.WriteLine();
        } while (option != 0);
    }
}
