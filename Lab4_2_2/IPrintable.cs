using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2_2
{
    public interface IPrintable
    {
        public enum Purpose { Scientific, Educational, Socio_political, Artistic, Fairy_Tail, Fasion };
        public Purpose PrintPurpose { get; }
        public string? Title { get; }
        public IEnumerable<string>? Authors { get; }
        public IEnumerable<string>? PublishLanguages { get; }
        public int PageNumber { get; }
        public decimal Rate { get; }
        public decimal Price { get; }
        public int SoldNumber { get; }
        public void Print();
        public int Rating(IEnumerable<IPrintable> PublishersList);
        public void SetPrice(int NumberOfCopies, int NumberOfPages, decimal OnePageCost, decimal HardSoftFactor, decimal PrintFormatFactor, decimal ColorFactor);
        public void SetPrice(int PaperPrice, int PrintingWorkPrice, decimal TaxesCoef);
        public void SetPrice(int PaperPrice, int PrintingWorkPrice);
    }
}
