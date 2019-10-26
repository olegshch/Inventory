using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModels
{
    /// <summary>
    /// класс с полями string Name(и XKey) и int Id(и аналогичные ему)
    /// </summary>
    public class Global
    {
        /// <summary>
        /// уникальный номер объекта
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// имя объекта
        /// </summary>
        public string Name { get; set; }
    }
}
