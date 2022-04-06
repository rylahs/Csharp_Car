using MaterialSkin.Controls;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using winform0311.DTO;
using winform0311.Handler;
using winform0311.Utils;

namespace winform0311.UI
{
    partial class CustFixAddUI : MaterialForm
    {
        BaseAdapter baseAd;
        
        public CustFixAddUI()
        {
            InitializeComponent();
        }

        public CustFixAddUI(BaseAdapter baseAd)
        {
            InitializeComponent();
            this.baseAd = baseAd;
        }
        private void CustFixAddUI_Load(object sender, EventArgs e)
        {
            setYear();
            setMonth();
            setDate();
            setCarYear();
        }

        private void setYear()
        {
            for (int i = 2022; i >= 1930; i--)
                custBirthYear.Items.Add(i.ToString());
        }
        private void setMonth()
        {
            for (int i = 1; i <= 12; i++)
                custBirthMonth.Items.Add(i.ToString());
        }

        private void setDate()
        {
            for (int i = 1; i <= 31; i++)
                custBirthDate.Items.Add(i.ToString());
        }

        private void setCarYear()
        {
            for (int i = 2022; i >= 2000; i--)
                carYear.Items.Add(i.ToString());
        }

        private void custClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void carModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string model = carModel.SelectedItem.ToString();
            Console.WriteLine(model);
            switch (model)
            {
                case "아반떼":
                    carPic.Image = Properties.Resources.avantee;
                    break;
                case "벨로스터":
                    carPic.Image = Properties.Resources.veloster;
                    break;
                case "그랜저":
                    carPic.Image = Properties.Resources.granz;
                    break;
                case "제네시스":
                    carPic.Image = Properties.Resources.genesis;
                    break;
                case "K3":
                    carPic.Image = Properties.Resources.k3;
                    break;
                case "K5":
                    carPic.Image = Properties.Resources.k5;
                    break;
                case "K7":
                    carPic.Image = Properties.Resources.k7;
                    break;
                case "K9":
                    carPic.Image = Properties.Resources.k9;
                    break;
                case "아이오닉":
                    carPic.Image = Properties.Resources.aionic;
                    break;
                case "넥쏘":
                    carPic.Image = Properties.Resources.nexso;
                    break;
                case "티볼리":
                    carPic.Image = Properties.Resources.tvoly;
                    break;
                case "투싼":
                    carPic.Image = Properties.Resources.tucson;
                    break;
                case "스팅어":
                    carPic.Image = Properties.Resources.stingo;
                    break;
                case "소나타":
                    carPic.Image = Properties.Resources.sonata;
                    break;
                default:
                    carPic.Image = Properties.Resources.default_car;
                    break;
            }
        }

        private void custSave_Click(object sender, EventArgs e)
        {
            string name = custName.Text;
            string telH = custTelH.Text;
            string telB = custTelBody.Text;
            string year = custBirthYear.Text;
            string month = custBirthMonth.Text;
            string day = custBirthDate.Text;
            string model = carModel.Text;
            string num = carNum.Text;
            string cc = carCC.Text;
            string car_year = carYear.Text;
            string staff = custStaff.Text;

            Control[] arrObj = new Control[]
            {
                custName, custTelH, custTelBody, custBirthYear, custBirthMonth, custBirthDate,
                carModel, carNum, carCC, carYear, custStaff
            };

            string[] arrData = new string[]
            {
                name, telH, telB, year, month, day, model, num, cc, car_year, staff
            };

            string[] arrMsg = new string[]
            {
                Properties.Resources.ERR_NAME,
                Properties.Resources.ERR_TEL_H,
                Properties.Resources.ERR_TEL_B,
                Properties.Resources.ERR_BIRTH_YEAR,
                Properties.Resources.ERR_BIRTH_MONTH,
                Properties.Resources.ERR_BIRTH_DATE,
                Properties.Resources.ERR_CAR_MODEL,
                Properties.Resources.ERR_CAR_NUM,
                Properties.Resources.ERR_CAR_CC,
                Properties.Resources.ERR_CAR_YEAR,
                Properties.Resources.ERR_STAFF_NAME
            };


            Dictionary<Control, string> dic = new Dictionary<Control, string>();
            for (int i = 0; i < arrData.Length; i++)
            {
                dic.Add(arrObj[i], arrData[i]);
            }
            int cnt = 0;
            string telAll = telH + telB;
            foreach (KeyValuePair<Control, string> kvp in dic)
            {
                if (kvp.Value.Equals("") || kvp.Value.Equals("선택"))
                {
                    //MessageBox.Show(arrMsg[cnt]);
                    setFocus(kvp.Key, arrMsg[cnt]);
                    return;
                }
                if (!checkName(name) || !checkTel(telAll))
                    return;
                ++cnt;
                
            }


            UICheckBox[] checkBox =
            {
                chk1, chk2, chk3, chk4, chk5, chk6, chk7, chk8, chk9, chk10
            };
                   
            List<RepairItem> itemList = new List<RepairItem>();
            int totalPrice = 0;

            for (int i = RepairTable.ENGINE_OIL; i <= RepairTable.ETC_COST; i++)
            {
                if (checkBox[i].Checked)
                {
                    Console.WriteLine(checkBox[i].Text);
                    itemList.Add(new RepairItem(checkBox[i].Text, RepairTable.fixMoney[i]));
                    totalPrice += RepairTable.fixMoney[i];
                }
            }

            if (itemList.Count == 0)
            {
                MessageBox.Show("수리 항목을 선택하세요");
                return;
            }

            Customer cust = new Customer(name, telAll, year + month + day);
            Car car = new Car(model, num, cc, car_year);
            Receipt receipt = new Receipt(cust, car, DateTime.Now.ToString("yyyy/MM/dd"), staff, itemList, totalPrice, "NO");
            // baseAd.addReceiptList(receipt);
            baseAd.addReceiptDB(receipt);
            MessageBox.Show("데이터가 정상적으로 저장되었습니다.");
            this.Close();
        }

        private void setFocus(Control obj, string msg)
        {
            MessageBox.Show(msg);
            ActiveControl = obj;
            obj.Focus();
        }

        
        private bool checkName(String name)
        {
            Regex regex = new Regex(@"^[가-힣]{2,4}$");
            Match m = regex.Match(name);
            if (!m.Success)
            {
                setFocus(custName, "잘못된 이름입니다.");
                return false;
            }
            return true;

        }

        private bool checkTel(String tel)
        {
            Regex regex = new Regex(@"^01{1}[01]{1}[0-9]{7,8}$");
            Match m = regex.Match(tel);
            if (!m.Success)
            {
                setFocus(custName, "잘못된 전화번호 입니다.");
                return false;
            }
            return true;

        }

    }
}
