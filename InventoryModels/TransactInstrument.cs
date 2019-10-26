using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModels
{
    class TransactInstrument
    {
        public int Id { get; set; }
        public ElementInstrumentToUpload ElementInstrumentToUpload { get; set; }
        public byte[] Image { get; set; }
    }
}
