using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireStrategy.Test.Data
{
   public class Orders
    {
        public int LineNumber { get; set; }
        public string ItemName { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Price { get; set; }
        public int ClientId { get; set; }
        
    }

    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
       
    }
}
