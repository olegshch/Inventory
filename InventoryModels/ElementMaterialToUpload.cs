using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModels
{
    class ElementMaterialToUpload : MaterialNomenclature
    {       
        public Hold HoldMaterial { get; set; }
        public MaterialNomenclature MaterialNomenclature { get; set; }               
        public double Count { get; set; }
        public bool IsLoaded { get; set; }
        public string UserName { get; set; }
    }
}
