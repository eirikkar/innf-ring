class Utility
{
    public string ParseText(string? input)
    {
        while (true)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Input is invalid. Please input a valid input!");
                input = Console.ReadLine();
            }
            else
            {
                return input;
            }
        }
    }
}
