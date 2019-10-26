using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModels
{
    /// <summary>
    /// класс пользователя с именем, id, паролем
    /// </summary>
    class User : Global
    {
        public string Password { private get; set; }
    }
}
