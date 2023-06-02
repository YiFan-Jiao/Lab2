using System;
using System.Text;

//question 1
string string1 = "Programmatic Python";
char[] charString1 = string1.ToCharArray();
StringBuilder stringBuilder1 = new StringBuilder();

for(int i = 0; i < charString1.Length; i++)
{
    if( charString1[i] != ' ' )
    {
        for(int j = i+1; j < charString1.Length; j++)
        {
            if( charString1[i] == charString1[j] )
            {
                stringBuilder1.Append(charString1[i]);
            }
        }
    }
}
char[] result = stringBuilder1.ToString().ToCharArray();
Console.WriteLine("question 1");
Console.WriteLine(result);
Console.WriteLine();

//question 2
string string2 = "To be or not to be";
string[] charString2 = string2.Split(' ');
Console.WriteLine("question 2");
for (int i = 0;i < charString2.Length; i++)
{
    bool notOnlyPlus = false;
    bool notOnlyMinus = false;
    for (int j = i + 1; j < charString2.Length; j++)
    {
        if (charString2[i] == charString2[j])
        {
            notOnlyPlus = true;
            break;
        }
    }

    for (int j = i - 1; j > 0; j--)
    {
        if (charString2[i] == charString2[j])
        {
            notOnlyMinus = true;
            break;
        }
    }

    if (!notOnlyPlus && !notOnlyMinus)
    {
        Console.WriteLine(charString2[i]);
    }
}
Console.WriteLine();

//question 3
Console.WriteLine("question 3");
StringBuilder stringBuilder3 = new StringBuilder();
Console.WriteLine("Enter a string:");
string inputString = Console.ReadLine();
char[] charArray = inputString.ToCharArray();

for (int i = charArray.Length - 1; i >= 0; i--)
{
    //Console.WriteLine(charArray[i]);
    stringBuilder3.Append(charArray[i]);
}
Console.WriteLine(stringBuilder3);
Console.WriteLine();

//question 4
Console.WriteLine("question 4");
string string4 = "Tiptoe through the tulips";
string[] charString4 = string4.Split(' ');
for (int i = 0; i < charString4.Length; i++)
{
    for (int j = 0; j < charString4.Length - 1; j++)
    {
        if (charString4[j].Length < charString4[j + 1].Length)
        {
            string stored = charString4[j];
            charString4[j] = charString4[j + 1];
            charString4[j + 1] = stored;
        }
    }
}

for (int i = 0;i < charString4.Length; i++)
{
    if (charString4[i].Length == charString4[0].Length && charString4[i + 1].Length != charString4[0].Length)
    {
        Console.WriteLine(charString4[i]);
    }
}
Console.WriteLine();

//StringBuilder and string
Console.WriteLine("Advantages and disadvantages of StringBuilder and string:");
Console.WriteLine("\nStringBuilder can change the value during use. But you can't " +
    "directly assign a string of strings when you create it. You need to use the " +
    "stringBuilder.Append() method to add content, and there are some string methods " +
    "that stringBuilder cannot use, such as Contains, Join, etc.");
Console.WriteLine("\nThe string can be directly assigned when it is created, but the content " +
    "cannot be changed, and methods such as Contains and Join can be used.");