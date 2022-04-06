namespace winform0311
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.custFixAdd = new Sunny.UI.UISymbolButton();
            this.btnFixView = new Sunny.UI.UISymbolButton();
            this.btnAdmin = new Sunny.UI.UISymbolButton();
            this.btnSetting = new Sunny.UI.UISymbolButton();
            this.btnInfo = new Sunny.UI.UISymbolButton();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.btnExit = new Sunny.UI.UISymbolButton();
            this.btnMin = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::winform0311.Properties.Resources.bg;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(595, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // custFixAdd
            // 
            this.custFixAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custFixAdd.FillColor = System.Drawing.Color.Silver;
            this.custFixAdd.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custFixAdd.Location = new System.Drawing.Point(613, 105);
            this.custFixAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.custFixAdd.Name = "custFixAdd";
            this.custFixAdd.Size = new System.Drawing.Size(168, 50);
            this.custFixAdd.Style = Sunny.UI.UIStyle.Custom;
            this.custFixAdd.Symbol = 62004;
            this.custFixAdd.SymbolSize = 32;
            this.custFixAdd.TabIndex = 1;
            this.custFixAdd.Text = "접 수";
            this.custFixAdd.Click += new System.EventHandler(this.custFixAdd_Click);
            // 
            // btnFixView
            // 
            this.btnFixView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFixView.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnFixView.Location = new System.Drawing.Point(655, 184);
            this.btnFixView.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnFixView.Name = "btnFixView";
            this.btnFixView.Size = new System.Drawing.Size(168, 50);
            this.btnFixView.Symbol = 61508;
            this.btnFixView.SymbolSize = 32;
            this.btnFixView.TabIndex = 2;
            this.btnFixView.Text = "접수 내역";
            this.btnFixView.Click += new System.EventHandler(this.btnFixView_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnAdmin.Location = new System.Drawing.Point(732, 259);
            this.btnAdmin.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(168, 50);
            this.btnAdmin.Symbol = 61568;
            this.btnAdmin.SymbolSize = 32;
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "관리자 모드";
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnSetting.Location = new System.Drawing.Point(655, 337);
            this.btnSetting.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(168, 50);
            this.btnSetting.Symbol = 61573;
            this.btnSetting.SymbolSize = 32;
            this.btnSetting.TabIndex = 4;
            this.btnSetting.Text = "환경 설정";
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInfo.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnInfo.Location = new System.Drawing.Point(613, 414);
            this.btnInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(168, 50);
            this.btnInfo.Symbol = 61736;
            this.btnInfo.SymbolSize = 32;
            this.btnInfo.TabIndex = 5;
            this.btnInfo.Text = "프로그램 정보";
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.White;
            this.uiSymbolLabel1.Location = new System.Drawing.Point(-3, 23);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(302, 35);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 362942;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.uiSymbolLabel1.TabIndex = 6;
            this.uiSymbolLabel1.Text = "SpeedMate 관리 프로그램 v1.0";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnExit.Location = new System.Drawing.Point(852, 23);
            this.btnExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.RectColor = System.Drawing.Color.Transparent;
            this.btnExit.Size = new System.Drawing.Size(58, 35);
            this.btnExit.Style = Sunny.UI.UIStyle.Custom;
            this.btnExit.Symbol = 61453;
            this.btnExit.SymbolSize = 28;
            this.btnExit.TabIndex = 7;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.FillColor = System.Drawing.Color.Transparent;
            this.btnMin.FillDisableColor = System.Drawing.Color.Transparent;
            this.btnMin.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.btnMin.Location = new System.Drawing.Point(793, 23);
            this.btnMin.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnMin.Name = "btnMin";
            this.btnMin.RectColor = System.Drawing.Color.Transparent;
            this.btnMin.Size = new System.Drawing.Size(53, 35);
            this.btnMin.Style = Sunny.UI.UIStyle.Custom;
            this.btnMin.Symbol = 62161;
            this.btnMin.SymbolSize = 28;
            this.btnMin.TabIndex = 8;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 511);
            this.ControlBox = false;
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnFixView);
            this.Controls.Add(this.custFixAdd);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UISymbolButton custFixAdd;
        private Sunny.UI.UISymbolButton btnFixView;
        private Sunny.UI.UISymbolButton btnAdmin;
        private Sunny.UI.UISymbolButton btnSetting;
        private Sunny.UI.UISymbolButton btnInfo;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UISymbolButton btnExit;
        private Sunny.UI.UISymbolButton btnMin;
    }
}

