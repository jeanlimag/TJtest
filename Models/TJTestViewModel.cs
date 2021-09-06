using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace TJTest.Models
{
    public class TJTestViewModel
    {
        #region constructor
        public TJTestViewModel()
        {
            ClientName = string.Empty;
            IdClient = int.MinValue;
            ProductName = string.Empty;
            Price = double.MinValue;
            ProductAmount = int.MinValue;
            TotalPrice = double.MinValue;

        }
        #endregion

        #region attributes
        public string ClientName { get; set; }
        public int IdClient { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int ProductAmount { get; set; }
        public double TotalPrice { get; set; }
        #endregion
    }
}
