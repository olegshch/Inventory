using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModels
{
    /// <summary>
    /// общий класс для склада
    /// </summary>
    public class Hold : Global
    {
        /// <summary>
        /// тип склада: для интсрументов или матералов
        /// </summary>
        public TypeOfHold Type { get; set; }
    }
}
