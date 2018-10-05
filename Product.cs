using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSEntities
{

    
 /// <summary>
  /// To create the methods for performing operations on Product Entity
  /// Author: Arpeet Gokhale
  /// DOC: 4th Oct 2018  
  /// </summary>

    [Serializable]
    public class Product
    {

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public DateTime DateOfManufacture { get; set; }
    }


}
