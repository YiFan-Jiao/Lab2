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
        }
    }

    for (int j = i - 1; j > 0; j--)
    {
        if (charString2[i] == charString2[j])
        {
            notOnlyMinus = true;
        }
    }

    if (!notOnlyPlus && !notOnlyMinus)
    {
        Console.WriteLine(charString2[i]);
    }
}
Console.WriteLine();

//question 3
xxxx
