using System;
class Program
{
    static void Main(string[]args)
    {
        string[] namn = { "Walter", "Leon", "Alem", "Suber", "Adam" };
        Array.Sort(namn);
        for(int i = 0; i < namn.Length; i++)
        {
            Console.WriteLine(namn[i]);
        }  
    }
}