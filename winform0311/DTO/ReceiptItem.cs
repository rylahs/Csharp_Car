using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winform0311.DTO
{
    internal class ReceiptItem
    {
        private string indate;
        private string total_price;
        private string staffName;
        private string custName;
        private string custTel;
        private string carNum;
        private string repairCheck;

        public ReceiptItem(string indate, string total_price, string staffName, string custName, string custTel, string carNum, string repairCheck)
        {
            this.indate = indate;
            this.total_price = total_price;
            this.staffName = staffName;
            this.custName = custName;
            this.custTel = custTel;
            this.carNum = carNum;
            this.repairCheck = repairCheck;
        }

        public string Indate { get => indate; set => indate = value; }
        public string Total_price { get => total_price; set => total_price = value; }
        public string StaffName { get => staffName; set => staffName = value; }
        public string CustName { get => custName; set => custName = value; }
        public string CustTel { get => custTel; set => custTel = value; }
        public string CarNum { get => carNum; set => carNum = value; }
        public string RepairCheck { get => repairCheck; set => repairCheck = value; }

    }
}
