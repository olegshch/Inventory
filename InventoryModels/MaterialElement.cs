using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModels
{
    /// <summary>
    /// описание материалаа
    /// </summary>
    class MaterialElement
    {
        /// <summary>
        /// id материала
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// соответсвующая номенклатура
        /// </summary>
        public MaterialNomenclature MaterialNomenclature { get; set; }

        /// <summary>
        /// количество материала
        /// </summary>
        public double Count { get; set; }
    }
}
