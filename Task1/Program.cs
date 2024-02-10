string Charofstring(char[,] arr)
{
    string st = "";
    foreach (var item in arr)
    {
        st += item;
    }
    return st;
}

char[,] chars = new char[,] 
{
    {'a', 'r', 't', 'y'},
    {'e', 'g', 'p', 'f'},
    {'n', 'c', 'q', 'x'}
};
Console.WriteLine(Charofstring(chars));