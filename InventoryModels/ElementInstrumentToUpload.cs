using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModels
{
    class ElementInstrumentToUpload : Global
    {
        
        public Hold HoldInstrument { get; set; }
        public Nomenclature Nomenclature { get; set; }
        public KnownInstrument InstrumentHeader { get; set; }
        
        public string ImagePhoneSource { get; set; }
        public bool IsLoaded { get; set; }
        public string UserName { get; set; }
    }
}
