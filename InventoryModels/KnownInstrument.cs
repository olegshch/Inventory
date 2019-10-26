using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModels
{
    /// <summary>
    /// известный элемент
    /// </summary>
    class KnownInstrument : Global
    {
        /// <summary>
        /// номенклатура известного элемента
        /// </summary>
        public Nomenclature Nomenclature { get; set; }
    }
}
