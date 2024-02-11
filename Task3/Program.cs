string palicheck (string sample)
{
    string result = ("");
    for (int i = 0; i < sample.Length/2; i++)
    {
        if(sample[i] == sample[(sample.Length-1)-i])
        {
            result =  ("Образец - палиндром");
        }
        else
        {
            result =  ("Образец - не палиндром");
        }
    }
    return result;
}

Console.Write("Введите образец: ");
string str = Console.ReadLine();
Console.WriteLine(palicheck(str));