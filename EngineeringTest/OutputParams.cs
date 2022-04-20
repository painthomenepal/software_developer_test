using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineeringTest
{
    public class OutputParams
    {
        public OutputParams()
        {
            List<Receipt> receiptList = new List<Receipt>();
        }

        public decimal SalesTaxes { get; set; }
        public decimal Total { get; set; }
        public List<Receipt> outputList { get; set; }
    }
}
