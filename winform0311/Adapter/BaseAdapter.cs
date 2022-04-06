using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using winform0311.DAO;
using winform0311.DTO;

namespace winform0311.Handler
{
    internal class BaseAdapter
    {
        private DaoOracle ora = new DaoOracle();
        private List<Receipt> receiptList = new List<Receipt>();

        public void addReceiptList(Receipt receipt)
        {
            receiptList.Add(receipt);
            addReceiptDB();
        }

        public void addReceiptDB()
        {
            for (int i = 0; i < receiptList.Count; i++)
            {
                ora.insertData(receiptList[i]);
            }
            receiptList.Clear();
        }

        public void addReceiptDB(Receipt receipt)
        {
            ora.insertData(receipt);
        }
        public void viewReceipt()
        {
            for (int i = 0; i < receiptList.Count; i++)
            {
                Customer customer = receiptList[i].Customer;
                Console.WriteLine("고객명 : " + customer.Name);
                Console.WriteLine("전화 : " + customer.Tel);
                Console.WriteLine("생년월일 : " + customer.Birth);

                Car car = receiptList[i].Car;
                Console.WriteLine("모델명 : " + car.Model);
                Console.WriteLine("차량번호 : " + car.Number);
                Console.WriteLine("배기량 : " + car.Cc);

                Console.WriteLine("접수 날짜 : " + receiptList[i].InDate);
                Console.WriteLine("담당자 : " + receiptList[i].StaffName);

                List<RepairItem> itemList = receiptList[i].ItemList;
                for (int j = 0; j < itemList.Count; j++)
                {
                    Console.WriteLine("수리항목 : " + itemList[j].Repair);
                    Console.WriteLine("수리단가 : " + itemList[j].Price);
                }

                Console.WriteLine("총결제 금액 : " + receiptList[i].TotalPrice);
                Console.WriteLine("수리 상태 : " + receiptList[i].RepairCheck);
            }
        }
        
        public void viewReceiptDB()
        {
            ora.SelectData2();
        }

        public List<ReceiptItem> getReceiptDb()
        {
            List<ReceiptItem> list = ora.getReceiptVO();
            return list;
        }

        public List<RepairItem> getRepairDb()
        {
            List<RepairItem> list = ora.getRepairVo();
            return list;
        }

        public List<RepairItem> getRepairDb(string name, string tel)
        {
            List<RepairItem> list = ora.getRepairVo(name, tel);
            return list;
        }
    }
}
