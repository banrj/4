namespace _4;
class Program
{
    static void Main(string[] args)
    {
        Note<int>[] notes = new Note<int>[6]
        {
             new Note<int>("Даниил",19646392, new int[] {22, 3, 2004 }),
             new Note<int>("Алеша",1312988, new int[] {21, 3, 2004 }),
             new Note<int>("Алена",311932, new int[] {02, 6, 2000 }),
             new Note<int>("Вова",12341932, new int[] {22, 12, 2007 }),
             new Note<int>("Зоя",541999, new int[] {31, 01, 1999 }),
             new Note<int>("дима",1908977, new int[] {24, 5, 1987 })
        };

        Array.Sort(notes);
        foreach (var item in notes)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
        //Array.Sort(notes, new SortByAmmo());
        //foreach (var item in notes)
        //{
        //    Console.WriteLine(item);
        //}

    }
}

