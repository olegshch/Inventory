using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModels
{
    /// <summary>
    /// номенклатура для материалов (+ единицы измерения)
    /// </summary>
    class MaterialNomenclature : Nomenclature
    {
        /// <summary>
        /// в чем измеряется материал
        /// </summary>
        public string Units { get; set; }
    }
}
