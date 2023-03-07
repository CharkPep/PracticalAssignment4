using Lab5_2;
using System.Security.Cryptography.X509Certificates;

namespace Lab4_2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Printable1 = new Printable(IPrintable.Purpose.Scientific,"Printable1", new List<string>() { "Author1", "Author2", "Author3" }, 100, 10, 100, 1000);
            var Printable2 = new Printable(IPrintable.Purpose.Socio_political, "Printable1", new List<string>() { "Author1", "Author2", "Author3" }, 100, 10, 120, 3000);
            var Printable3 = new Printable(IPrintable.Purpose.Socio_political, "Printable1", new List<string>() { "Author1", "Author2", "Author3" }, 100, 10, 120, 4000);
            var Printable4 = new Printable(IPrintable.Purpose.Socio_political, "Printable1", new List<string>() { "Author1", "Author2", "Author3" }, 100, 10, 120, 5000);

            var ScienceMagazine = new Magazine(Printable1, 1, DateTime.Now, Magazine.CoverType.Soft);
            var SocioPoliticalBook = new Book(Printable2, 1, DateTime.Now, 10, Book.CoverType.Soft);
            var Magazine1 = new Magazine(Printable3, 2, DateTime.Now, Magazine.CoverType.Soft);
            var Magazine2 = new Magazine(Printable4, 2, DateTime.Now, Magazine.CoverType.Soft);


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ScienceMagazine: ");
            Console.ResetColor();
            ScienceMagazine.Print();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("SocioPoliticalBook: ");
            Console.ResetColor();
            Print(SocioPoliticalBook);

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Rating");
            Console.ResetColor();
            var RatingList = new List<Printable> { ScienceMagazine, SocioPoliticalBook, Magazine1, Magazine2 };
            foreach(var item in RatingList)
            {
                Console.WriteLine(item + ":");
                Console.WriteLine(item.Rating(RatingList));
            }
        }
        public static void Print(IPrintable Printable)
        {
            Printable.Print();
        }
    }
}