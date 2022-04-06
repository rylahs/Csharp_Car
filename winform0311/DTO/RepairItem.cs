using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform0311.DTO
{
    internal class RepairItem
    {
        private string repair;
        private int price;

        public RepairItem(string repair, int price)
        {
            this.repair = repair;
            this.price = price;
        }

        public string Repair { get => repair; set => repair = value; }
        public int Price { get => price; set => price = value; }
    }
}
