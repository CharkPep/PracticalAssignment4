using Lab5_2;

namespace Lab4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var Printable1 = new Printable(Printable.Purpose.Scientific, "Printable1", new List<string>() { "Author1", "Author2", "Author3" }, 100, 10, 100, 1000);
            var Printable3 = new Printable(Printable.Purpose.Socio_political, "Printable1", new List<string>() { "Author1", "Author2", "Author3" }, 100, 10, 120, 4000);
            var Printable4 = new Printable(Printable.Purpose.Socio_political, "Printable1", new List<string>() { "Author1", "Author2", "Author3" }, 100, 10, 120, 5000);
            var Printable5 = new Printable(Printable.Purpose.Socio_political, "Printable1", new List<string>() { "Author1", "Author2", "Author3" }, 100, 10, 120, 7201);

            var ScienceMagazine = new Magazine(Printable1, 1, DateTime.Now, Magazine.CoverType.Soft);
            var Magazine1 = new Magazine(Printable3, 2, DateTime.Now, Magazine.CoverType.Soft);
            var Magazine2 = new Magazine(Printable4, 2, DateTime.Now, Magazine.CoverType.Soft);
            var Magazine3 = new Magazine(Printable5, 2, DateTime.Now, Magazine.CoverType.Soft);


            var tmpList = new List<Magazine> { ScienceMagazine, Magazine1, Magazine2 };
            var list1= new MagazineArray(tmpList);
            var list2 = new MagazineArray(tmpList);

            Console.WriteLine(list1.CompareTo(list2));
            var tmpList1 = new List<Magazine> { Magazine3, Magazine1, Magazine2 };
            list1 = new MagazineArray(tmpList);
            list2 = new MagazineArray(tmpList1);
            Console.WriteLine(list1.CompareTo(list2));

            Console.WriteLine("The array is: ");
            foreach(var item in list1)
            {
                Console.Write($"{item.Title} ");
            }
        }
    }
}