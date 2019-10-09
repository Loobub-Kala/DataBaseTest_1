namespace DataBaseTest_1
{
    partial class FormIllegal
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnDataNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newTable = new System.Windows.Forms.Button();
            this.returnMain = new System.Windows.Forms.Button();
            this.queryCard = new System.Windows.Forms.Button();
            this.cardCase = new System.Windows.Forms.TextBox();
            this.label0 = new System.Windows.Forms.Label();
            this.queryTime = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timeCase1 = new System.Windows.Forms.DateTimePicker();
            this.timeCase2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.showTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDataNo,
            this.ColumnCardID,
            this.ColumnTime});
            this.dataGridView.Location = new System.Drawing.Point(30, 160);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(720, 270);
            this.dataGridView.TabIndex = 15;
            // 
            // ColumnDataNo
            // 
            this.ColumnDataNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnDataNo.Frozen = true;
            this.ColumnDataNo.HeaderText = "编号";
            this.ColumnDataNo.Name = "ColumnDataNo";
            this.ColumnDataNo.ReadOnly = true;
            this.ColumnDataNo.Width = 70;
            // 
            // ColumnCardID
            // 
            this.ColumnCardID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnCardID.FillWeight = 4F;
            this.ColumnCardID.Frozen = true;
            this.ColumnCardID.HeaderText = "卡号";
            this.ColumnCardID.Name = "ColumnCardID";
            this.ColumnCardID.ReadOnly = true;
            this.ColumnCardID.Width = 160;
            // 
            // ColumnTime
            // 
            this.ColumnTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ColumnTime.FillWeight = 8F;
            this.ColumnTime.Frozen = true;
            this.ColumnTime.HeaderText = "试图入侵的时间";
            this.ColumnTime.Name = "ColumnTime";
            this.ColumnTime.ReadOnly = true;
            this.ColumnTime.Width = 450;
            // 
            // newTable
            // 
            this.newTable.Location = new System.Drawing.Point(130, 20);
            this.newTable.Name = "newTable";
            this.newTable.Size = new System.Drawing.Size(75, 23);
            this.newTable.TabIndex = 14;
            this.newTable.Text = "数据刷新";
            this.newTable.UseVisualStyleBackColor = true;
            this.newTable.Click += new System.EventHandler(this.newTable_Click);
            // 
            // returnMain
            // 
            this.returnMain.Location = new System.Drawing.Point(30, 20);
            this.returnMain.Name = "returnMain";
            this.returnMain.Size = new System.Drawing.Size(75, 23);
            this.returnMain.TabIndex = 13;
            this.returnMain.Text = "返回上页";
            this.returnMain.UseVisualStyleBackColor = true;
            this.returnMain.Click += new System.EventHandler(this.returnMain_Click);
            // 
            // queryCard
            // 
            this.queryCard.Location = new System.Drawing.Point(326, 61);
            this.queryCard.Name = "queryCard";
            this.queryCard.Size = new System.Drawing.Size(75, 23);
            this.queryCard.TabIndex = 18;
            this.queryCard.Text = "查询";
            this.queryCard.UseVisualStyleBackColor = true;
            this.queryCard.Click += new System.EventHandler(this.queryCard_Click);
            // 
            // cardCase
            // 
            this.cardCase.Location = new System.Drawing.Point(115, 63);
            this.cardCase.Name = "cardCase";
            this.cardCase.Size = new System.Drawing.Size(193, 21);
            this.cardCase.TabIndex = 17;
            this.cardCase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cardCase_KeyPress);
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label0.Location = new System.Drawing.Point(30, 65);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(88, 16);
            this.label0.TabIndex = 16;
            this.label0.Text = "卡号查询：";
            // 
            // queryTime
            // 
            this.queryTime.Location = new System.Drawing.Point(448, 99);
            this.queryTime.Name = "queryTime";
            this.queryTime.Size = new System.Drawing.Size(75, 23);
            this.queryTime.TabIndex = 21;
            this.queryTime.Text = "查询";
            this.queryTime.UseVisualStyleBackColor = true;
            this.queryTime.Click += new System.EventHandler(this.queryTime_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(30, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "时段查询：";
            // 
            // timeCase1
            // 
            this.timeCase1.CustomFormat = "yyyy-MM-dd HH:mm";
            this.timeCase1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeCase1.Location = new System.Drawing.Point(118, 100);
            this.timeCase1.Name = "timeCase1";
            this.timeCase1.Size = new System.Drawing.Size(140, 21);
            this.timeCase1.TabIndex = 22;
            this.timeCase1.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.timeCase1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeCase1_KeyPress);
            // 
            // timeCase2
            // 
            this.timeCase2.CustomFormat = "yyyy-MM-dd HH:mm";
            this.timeCase2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeCase2.Location = new System.Drawing.Point(293, 100);
            this.timeCase2.Name = "timeCase2";
            this.timeCase2.Size = new System.Drawing.Size(140, 21);
            this.timeCase2.TabIndex = 23;
            this.timeCase2.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.timeCase2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeCase2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(265, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "到";
            // 
            // showTime
            // 
            this.showTime.AutoSize = true;
            this.showTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.showTime.Location = new System.Drawing.Point(536, 102);
            this.showTime.Name = "showTime";
            this.showTime.Size = new System.Drawing.Size(96, 16);
            this.showTime.TabIndex = 25;
            this.showTime.Text = "0天0小时0分";
            // 
            // FormIllegal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.showTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeCase2);
            this.Controls.Add(this.timeCase1);
            this.Controls.Add(this.queryTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.queryCard);
            this.Controls.Add(this.cardCase);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.newTable);
            this.Controls.Add(this.returnMain);
            this.Name = "FormIllegal";
            this.Text = "基于RFID的寝室门禁管理系统 - 非法用户名单";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormIllegal_FormClosed);
            this.Load += new System.EventHandler(this.FormIllegal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button newTable;
        private System.Windows.Forms.Button returnMain;
        private System.Windows.Forms.Button queryCard;
        private System.Windows.Forms.TextBox cardCase;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Button queryTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker timeCase1;
        private System.Windows.Forms.DateTimePicker timeCase2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCardID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
        private System.Windows.Forms.Label showTime;
    }
}