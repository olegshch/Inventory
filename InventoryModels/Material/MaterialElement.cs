using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModels
{ 
   public class MaterialElement
    {
  
        public int Id { get; set; }


        public MaterialNomenclature MaterialNomenclature { get; set; }

    
        public double Count { get; set; }
    }
}
