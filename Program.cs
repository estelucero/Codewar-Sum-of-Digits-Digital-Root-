public class Number
{
    public static int DigitalRoot(long n)
    {
        int output = DigitalRootRecursive(n.ToString(), n.ToString().Length - 1);


        if (output.ToString().Length <= 1)
        {
            return output;
        }
        //If the number has more than 2 digits we call recurisve
        return DigitalRoot(output);



    }
    private static int DigitalRootRecursive(string number, int index)
    {
        //Check if the string number end´s
        if (index < 0)
        {
            return 0;
        }
        //Here we sub 48 because the char was the ascii number of 0 and call recursive method
        return (((int)number[index]) - 48) + DigitalRootRecursive(number, index - 1);
    }

    static void Main(string[] args)
    {
        Console.WriteLine(DigitalRoot(16));
    }
}