using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.FXRates.Common.Models
{
    public class FxRate
    {
        int pairId { get; set; }
         DateTime dateTime { get; set; }
        double byeingValue { get; set; }
        double sellingValue { get; set; }
       
    }
}
