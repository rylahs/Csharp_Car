using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winform0311.Common;
using winform0311.Handler;
using winform0311.UI;

namespace winform0311
{
    public partial class MainForm : MaterialForm
    {
        BaseAdapter baseAd = new BaseAdapter();

        public MainForm()
        {
            InitializeComponent();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Theme.initTheme(this);
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void custFixAdd_Click(object sender, EventArgs e)
        {
            CustFixAddUI addUi = new CustFixAddUI(baseAd);
            addUi.ShowDialog();
        }

        private void btnFixView_Click(object sender, EventArgs e)
        {
            baseAd.viewReceiptDB();
            ReceiptView vi = new ReceiptView(baseAd);
            vi.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btnSetting_Click(object sender, EventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
