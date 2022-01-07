using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal interface IInventoryItem
    {
        public int GetWeight();

        public int GetPotionSpace();

        public void DisplayName();

        void Load(List<IInventoryItem> itemsList);

    }

}
