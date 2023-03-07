 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_2
{
    public class Book : Printable
    {
        public enum CoverType { Hard, Soft }
        public int ID { get; }
        public DateTime RealiseDate { get; }
        public int NumberOfIllustrations { get; }
        public CoverType Cover { get; }
        public Book()
        {

        }
        public Book(Printable printable, int ID, DateTime RealiseDate, int NumberOfIlustrations, CoverType Cover) : base(printable)
        {
            this.ID = ID;
            this.RealiseDate = RealiseDate;
            this.NumberOfIllustrations = NumberOfIlustrations;
            this.Cover = Cover;
        }
        public Book(Purpose PrintPurpose, string Name, IEnumerable<string> Authors, int PageNumber, decimal Rate, decimal Price, int SoldNumber, int ID, DateTime RealiseDate, int NumberOfIlustrations, CoverType Cover) : base(PrintPurpose, Name, Authors, PageNumber, Rate, Price, SoldNumber)
        {
            this.ID = ID;
            this.RealiseDate = RealiseDate;
            this.NumberOfIllustrations = NumberOfIlustrations;
            this.Cover = Cover;
        }
        public Book(Book other) : base(other)
        {
            this.ID = other.ID;
            this.RealiseDate = other.RealiseDate;
            this.NumberOfIllustrations = other.NumberOfIllustrations;
            this.Cover = other.Cover;
        }
        public override void Print()
        {
            Console.WriteLine("The base class of Book");
            base.Print();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("The Book class");
            Console.ResetColor();
            Console.WriteLine($"The ID: {ID}");
            Console.WriteLine($"The Realise Date: {RealiseDate}");
            Console.WriteLine($"The number of illustrations {NumberOfIllustrations}");
            Console.WriteLine($"The Cover type: {Cover}");
        }
        public override void SetPrice(int NumberOfCopies, int NumberOfPages, decimal OnePageCost, decimal HardSoftFactor, decimal PrintFormatFactor, decimal ColorFactor) => Price = NumberOfCopies * NumberOfPages * OnePageCost * (1 + HardSoftFactor) * (0.8m + PrintFormatFactor) * (0.5m + ColorFactor);
        
    }
}
