using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModels
{
    public   class InventoryObject
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Hold> Holds { get; set; }

    }
}
