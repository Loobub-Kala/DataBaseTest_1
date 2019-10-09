namespace DataBaseTest_1
{
    partial class FormOld
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
            this.returnMain = new System.Windows.Forms.Button();
            this.newTable = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnDataNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // returnMain
            // 
            this.returnMain.Location = new System.Drawing.Point(30, 20);
            this.returnMain.Name = "returnMain";
            this.returnMain.Size = new System.Drawing.Size(75, 23);
            this.returnMain.TabIndex = 1;
            this.returnMain.Text = "返回上页";
            this.returnMain.UseVisualStyleBackColor = true;
            this.returnMain.Click += new System.EventHandler(this.returnMain_Click);
            // 
            // newTable
            // 
            this.newTable.Location = new System.Drawing.Point(130, 20);
            this.newTable.Name = "newTable";
            this.newTable.Size = new System.Drawing.Size(75, 23);
            this.newTable.TabIndex = 2;
            this.newTable.Text = "数据刷新";
            this.newTable.UseVisualStyleBackColor = true;
            this.newTable.Click += new System.EventHandler(this.newTable_Click);
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
            this.dataGridView.Location = new System.Drawing.Point(30, 65);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(720, 380);
            this.dataGridView.TabIndex = 12;
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
            // FormOld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.newTable);
            this.Controls.Add(this.returnMain);
            this.Name = "FormOld";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "基于RFID的寝室门禁管理系统 - 历史数据";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormOld_FormClosed);
            this.Load += new System.EventHandler(this.FormOld_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button returnMain;
        private System.Windows.Forms.Button newTable;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCardID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
    }
}