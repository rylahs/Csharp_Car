using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform0311.DTO
{
    internal class Receipt
    {
        private Customer customer;
        private Car car;
        private string inDate;
        private string staffName;
        private List<RepairItem> itemList;
        private int totalPrice;
        private string repairCheck;

        public Receipt(Customer customer, Car car, string inDate,
            string staffName, List<RepairItem> itemList,
            int totalPrice, string repairCheck)
        {
            this.customer = customer;
            this.car = car;
            this.inDate = inDate;
            this.staffName = staffName;
            this.itemList = itemList;
            this.totalPrice = totalPrice;
            this.repairCheck = repairCheck;
        }

        public string InDate { get => inDate; set => inDate = value; }
        public string StaffName { get => staffName; set => staffName = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
        public string RepairCheck { get => repairCheck; set => repairCheck = value; }
        internal Customer Customer { get => customer; set => customer = value; }
        internal Car Car { get => car; set => car = value; }
        internal List<RepairItem> ItemList { get => itemList; set => itemList = value; }
    }
}
