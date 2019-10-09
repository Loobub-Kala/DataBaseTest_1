namespace DataBaseTest_1
{
    partial class FormTime
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
            this.showTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timeCase2 = new System.Windows.Forms.DateTimePicker();
            this.timeCase1 = new System.Windows.Forms.DateTimePicker();
            this.queryTime = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.newTable = new System.Windows.Forms.Button();
            this.returnMain = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnDataNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // showTime
            // 
            this.showTime.AutoSize = true;
            this.showTime.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.showTime.Location = new System.Drawing.Point(536, 70);
            this.showTime.Name = "showTime";
            this.showTime.Size = new System.Drawing.Size(96, 16);
            this.showTime.TabIndex = 37;
            this.showTime.Text = "0天0小时0分";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(265, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "到";
            // 
            // timeCase2
            // 
            this.timeCase2.CustomFormat = "yyyy-MM-dd HH:mm";
            this.timeCase2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeCase2.Location = new System.Drawing.Point(293, 68);
            this.timeCase2.Name = "timeCase2";
            this.timeCase2.Size = new System.Drawing.Size(140, 21);
            this.timeCase2.TabIndex = 35;
            this.timeCase2.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.timeCase2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeCase2_KeyPress);
            // 
            // timeCase1
            // 
            this.timeCase1.CustomFormat = "yyyy-MM-dd HH:mm";
            this.timeCase1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeCase1.Location = new System.Drawing.Point(118, 68);
            this.timeCase1.Name = "timeCase1";
            this.timeCase1.Size = new System.Drawing.Size(140, 21);
            this.timeCase1.TabIndex = 34;
            this.timeCase1.Value = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.timeCase1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeCase1_KeyPress);
            // 
            // queryTime
            // 
            this.queryTime.Location = new System.Drawing.Point(448, 67);
            this.queryTime.Name = "queryTime";
            this.queryTime.Size = new System.Drawing.Size(75, 23);
            this.queryTime.TabIndex = 33;
            this.queryTime.Text = "查询";
            this.queryTime.UseVisualStyleBackColor = true;
            this.queryTime.Click += new System.EventHandler(this.queryTime_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(30, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "时段查询：";
            // 
            // newTable
            // 
            this.newTable.Location = new System.Drawing.Point(130, 20);
            this.newTable.Name = "newTable";
            this.newTable.Size = new System.Drawing.Size(75, 23);
            this.newTable.TabIndex = 27;
            this.newTable.Text = "数据刷新";
            this.newTable.UseVisualStyleBackColor = true;
            this.newTable.Click += new System.EventHandler(this.newTable_Click);
            // 
            // returnMain
            // 
            this.returnMain.Location = new System.Drawing.Point(30, 20);
            this.returnMain.Name = "returnMain";
            this.returnMain.Size = new System.Drawing.Size(75, 23);
            this.returnMain.TabIndex = 26;
            this.returnMain.Text = "返回上页";
            this.returnMain.UseVisualStyleBackColor = true;
            this.returnMain.Click += new System.EventHandler(this.returnMain_Click);
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
            this.ColumnTime,
            this.ColumnStudentID,
            this.ColumnName});
            this.dataGridView.Location = new System.Drawing.Point(30, 120);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(720, 310);
            this.dataGridView.TabIndex = 38;
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
            this.ColumnCardID.Width = 143;
            // 
            // ColumnTime
            // 
            this.ColumnTime.FillWeight = 8F;
            this.ColumnTime.HeaderText = "进出时间";
            this.ColumnTime.Name = "ColumnTime";
            this.ColumnTime.ReadOnly = true;
            // 
            // ColumnStudentID
            // 
            this.ColumnStudentID.FillWeight = 4F;
            this.ColumnStudentID.HeaderText = "学号";
            this.ColumnStudentID.Name = "ColumnStudentID";
            this.ColumnStudentID.ReadOnly = true;
            // 
            // ColumnName
            // 
            this.ColumnName.FillWeight = 3F;
            this.ColumnName.HeaderText = "姓名";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            // 
            // FormTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.showTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeCase2);
            this.Controls.Add(this.timeCase1);
            this.Controls.Add(this.queryTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newTable);
            this.Controls.Add(this.returnMain);
            this.Name = "FormTime";
            this.Text = "基于RFID的寝室门禁管理系统 - 时段查询";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTime_FormClosed);
            this.Load += new System.EventHandler(this.FormTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label showTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker timeCase2;
        private System.Windows.Forms.DateTimePicker timeCase1;
        private System.Windows.Forms.Button queryTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newTable;
        private System.Windows.Forms.Button returnMain;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCardID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
    }
}