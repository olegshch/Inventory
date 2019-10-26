using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModels
{
    /// <summary>
    /// объект инвентаризации "стройка"
    /// </summary>
    class CommonInventoryObject : Global
    {
        public List<Hold> HoldInstruments { get; set; }

        public List<Hold> HoldMaterials { get; set; }
    }
}
