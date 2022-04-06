namespace winform0311.UI
{
    partial class ReceiptView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rcGridView = new Sunny.UI.UIDataGridView();
            this.ri_count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ri_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ri_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.rcSearchAll = new Sunny.UI.UISymbolButton();
            this.rcSearch = new Sunny.UI.UISymbolButton();
            this.rcSearchItem = new Sunny.UI.UITextBox();
            this.rcSelect = new Sunny.UI.UIComboBox();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.rcFix = new Sunny.UI.UISymbolButton();
            this.rcClose = new Sunny.UI.UISymbolButton();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.rcListView = new System.Windows.Forms.ListView();
            this.rcCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rcInDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rcTotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rcStaffName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rcCustName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rcCustTel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cCarNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rcRepairCheck = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.rcGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // rcGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.rcGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.rcGridView.BackgroundColor = System.Drawing.Color.White;
            this.rcGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rcGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.rcGridView.ColumnHeadersHeight = 32;
            this.rcGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.rcGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ri_count,
            this.ri_item,
            this.ri_price});
            this.rcGridView.EnableHeadersVisualStyles = false;
            this.rcGridView.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.rcGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.rcGridView.Location = new System.Drawing.Point(28, 499);
            this.rcGridView.Name = "rcGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.rcGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.rcGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.rcGridView.RowTemplate.Height = 23;
            this.rcGridView.SelectedIndex = -1;
            this.rcGridView.ShowGridLine = true;
            this.rcGridView.Size = new System.Drawing.Size(712, 317);
            this.rcGridView.TabIndex = 1;
            // 
            // ri_count
            // 
            this.ri_count.HeaderText = "번 호";
            this.ri_count.Name = "ri_count";
            // 
            // ri_item
            // 
            this.ri_item.HeaderText = "수리항목";
            this.ri_item.Name = "ri_item";
            // 
            // ri_price
            // 
            this.ri_price.HeaderText = "수리가격";
            this.ri_price.Name = "ri_price";
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(28, 131);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(119, 35);
            this.uiSymbolLabel1.Symbol = 61508;
            this.uiSymbolLabel1.TabIndex = 3;
            this.uiSymbolLabel1.Text = "접수 현황";
            // 
            // rcSearchAll
            // 
            this.rcSearchAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rcSearchAll.FillColor = System.Drawing.Color.Transparent;
            this.rcSearchAll.FillColor2 = System.Drawing.Color.Transparent;
            this.rcSearchAll.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.rcSearchAll.ForeColor = System.Drawing.Color.Black;
            this.rcSearchAll.Location = new System.Drawing.Point(630, 79);
            this.rcSearchAll.MinimumSize = new System.Drawing.Size(1, 1);
            this.rcSearchAll.Name = "rcSearchAll";
            this.rcSearchAll.Size = new System.Drawing.Size(111, 35);
            this.rcSearchAll.Style = Sunny.UI.UIStyle.Custom;
            this.rcSearchAll.Symbol = 61454;
            this.rcSearchAll.SymbolColor = System.Drawing.Color.Black;
            this.rcSearchAll.TabIndex = 15;
            this.rcSearchAll.Text = "전체검색";
            // 
            // rcSearch
            // 
            this.rcSearch.BackColor = System.Drawing.Color.Transparent;
            this.rcSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rcSearch.FillColor = System.Drawing.Color.Transparent;
            this.rcSearch.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.rcSearch.ForeColor = System.Drawing.Color.Black;
            this.rcSearch.Location = new System.Drawing.Point(511, 79);
            this.rcSearch.MinimumSize = new System.Drawing.Size(1, 1);
            this.rcSearch.Name = "rcSearch";
            this.rcSearch.Size = new System.Drawing.Size(111, 35);
            this.rcSearch.Style = Sunny.UI.UIStyle.Custom;
            this.rcSearch.Symbol = 61442;
            this.rcSearch.SymbolColor = System.Drawing.Color.Black;
            this.rcSearch.TabIndex = 14;
            this.rcSearch.Text = "검색";
            // 
            // rcSearchItem
            // 
            this.rcSearchItem.ButtonSymbol = 61761;
            this.rcSearchItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rcSearchItem.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.rcSearchItem.Location = new System.Drawing.Point(270, 79);
            this.rcSearchItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rcSearchItem.Maximum = 2147483647D;
            this.rcSearchItem.Minimum = -2147483648D;
            this.rcSearchItem.MinimumSize = new System.Drawing.Size(1, 16);
            this.rcSearchItem.Name = "rcSearchItem";
            this.rcSearchItem.Size = new System.Drawing.Size(234, 35);
            this.rcSearchItem.TabIndex = 13;
            this.rcSearchItem.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rcSelect
            // 
            this.rcSelect.DataSource = null;
            this.rcSelect.FillColor = System.Drawing.Color.White;
            this.rcSelect.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.rcSelect.ItemHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.rcSelect.Items.AddRange(new object[] {
            "접수고객명",
            "접수차량번호",
            "담당자"});
            this.rcSelect.Location = new System.Drawing.Point(112, 79);
            this.rcSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rcSelect.MinimumSize = new System.Drawing.Size(63, 0);
            this.rcSelect.Name = "rcSelect";
            this.rcSelect.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.rcSelect.Size = new System.Drawing.Size(150, 35);
            this.rcSelect.TabIndex = 12;
            this.rcSelect.Text = "검색항목 선택";
            this.rcSelect.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel3.Location = new System.Drawing.Point(29, 79);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(76, 35);
            this.uiSymbolLabel3.Symbol = 61483;
            this.uiSymbolLabel3.TabIndex = 11;
            this.uiSymbolLabel3.Text = "검색";
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(29, 458);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(170, 35);
            this.uiSymbolLabel2.Symbol = 361613;
            this.uiSymbolLabel2.TabIndex = 10;
            this.uiSymbolLabel2.Text = "상세 수리 내역";
            // 
            // rcFix
            // 
            this.rcFix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rcFix.FillColor = System.Drawing.Color.DarkGreen;
            this.rcFix.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.rcFix.Location = new System.Drawing.Point(613, 417);
            this.rcFix.MinimumSize = new System.Drawing.Size(1, 1);
            this.rcFix.Name = "rcFix";
            this.rcFix.Size = new System.Drawing.Size(127, 46);
            this.rcFix.Style = Sunny.UI.UIStyle.Custom;
            this.rcFix.TabIndex = 16;
            this.rcFix.Text = "수리 완료";
            // 
            // rcClose
            // 
            this.rcClose.BackColor = System.Drawing.Color.Transparent;
            this.rcClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rcClose.FillColor = System.Drawing.Color.Transparent;
            this.rcClose.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.rcClose.Location = new System.Drawing.Point(652, 25);
            this.rcClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.rcClose.Name = "rcClose";
            this.rcClose.Size = new System.Drawing.Size(78, 35);
            this.rcClose.Style = Sunny.UI.UIStyle.Custom;
            this.rcClose.Symbol = 361457;
            this.rcClose.SymbolColor = System.Drawing.Color.DarkRed;
            this.rcClose.TabIndex = 17;
            this.rcClose.Click += new System.EventHandler(this.rcClose_Click);
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel4.ForeColor = System.Drawing.Color.White;
            this.uiSymbolLabel4.Location = new System.Drawing.Point(270, 25);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(170, 35);
            this.uiSymbolLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel4.Symbol = 62142;
            this.uiSymbolLabel4.SymbolColor = System.Drawing.Color.White;
            this.uiSymbolLabel4.TabIndex = 18;
            this.uiSymbolLabel4.Text = "고객 정보 보기";
            // 
            // rcListView
            // 
            this.rcListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.rcCount,
            this.rcInDate,
            this.rcTotalPrice,
            this.rcStaffName,
            this.rcCustName,
            this.rcCustTel,
            this.cCarNum,
            this.rcRepairCheck});
            this.rcListView.FullRowSelect = true;
            this.rcListView.HideSelection = false;
            this.rcListView.Location = new System.Drawing.Point(29, 173);
            this.rcListView.Name = "rcListView";
            this.rcListView.Size = new System.Drawing.Size(711, 238);
            this.rcListView.TabIndex = 19;
            this.rcListView.UseCompatibleStateImageBehavior = false;
            this.rcListView.View = System.Windows.Forms.View.Details;
            this.rcListView.SelectedIndexChanged += new System.EventHandler(this.rcListView_SelectedIndexChanged);
            // 
            // rcCount
            // 
            this.rcCount.Text = "번호";
            // 
            // rcInDate
            // 
            this.rcInDate.Text = "접수 날짜";
            this.rcInDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rcInDate.Width = 100;
            // 
            // rcTotalPrice
            // 
            this.rcTotalPrice.Text = "총결제금액";
            this.rcTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rcTotalPrice.Width = 100;
            // 
            // rcStaffName
            // 
            this.rcStaffName.Text = "담당자";
            this.rcStaffName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rcStaffName.Width = 80;
            // 
            // rcCustName
            // 
            this.rcCustName.Text = "고객명";
            this.rcCustName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rcCustName.Width = 80;
            // 
            // rcCustTel
            // 
            this.rcCustTel.Text = "고객전화";
            this.rcCustTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rcCustTel.Width = 100;
            // 
            // cCarNum
            // 
            this.cCarNum.Text = "차량번호";
            this.cCarNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cCarNum.Width = 100;
            // 
            // rcRepairCheck
            // 
            this.rcRepairCheck.Text = "수리상태";
            this.rcRepairCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ReceiptView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(752, 889);
            this.ControlBox = false;
            this.Controls.Add(this.rcListView);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.rcClose);
            this.Controls.Add(this.rcFix);
            this.Controls.Add(this.rcSearchAll);
            this.Controls.Add(this.rcSearch);
            this.Controls.Add(this.rcSearchItem);
            this.Controls.Add(this.rcSelect);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.rcGridView);
            this.Name = "ReceiptView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ReceiptView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rcGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIDataGridView rcGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ri_count;
        private System.Windows.Forms.DataGridViewTextBoxColumn ri_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn ri_price;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolButton rcSearchAll;
        private Sunny.UI.UISymbolButton rcSearch;
        private Sunny.UI.UITextBox rcSearchItem;
        private Sunny.UI.UIComboBox rcSelect;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolButton rcFix;
        private Sunny.UI.UISymbolButton rcClose;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private System.Windows.Forms.ListView rcListView;
        private System.Windows.Forms.ColumnHeader rcCount;
        private System.Windows.Forms.ColumnHeader rcInDate;
        private System.Windows.Forms.ColumnHeader rcTotalPrice;
        private System.Windows.Forms.ColumnHeader rcStaffName;
        private System.Windows.Forms.ColumnHeader rcCustName;
        private System.Windows.Forms.ColumnHeader rcCustTel;
        private System.Windows.Forms.ColumnHeader cCarNum;
        private System.Windows.Forms.ColumnHeader rcRepairCheck;
    }
}