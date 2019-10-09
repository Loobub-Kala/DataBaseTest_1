namespace DataBaseTest_1
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.oldData = new System.Windows.Forms.Button();
            this.startListener = new System.Windows.Forms.Button();
            this.newData = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnDataNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.queryStudent = new System.Windows.Forms.Button();
            this.queryIllegal = new System.Windows.Forms.Button();
            this.queryTime = new System.Windows.Forms.Button();
            this.inputData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // oldData
            // 
            this.oldData.Location = new System.Drawing.Point(111, 30);
            this.oldData.Name = "oldData";
            this.oldData.Size = new System.Drawing.Size(75, 23);
            this.oldData.TabIndex = 1;
            this.oldData.Text = "历史数据";
            this.oldData.UseVisualStyleBackColor = true;
            this.oldData.Click += new System.EventHandler(this.oldData_Click);
            // 
            // startListener
            // 
            this.startListener.Location = new System.Drawing.Point(630, 30);
            this.startListener.Name = "startListener";
            this.startListener.Size = new System.Drawing.Size(75, 23);
            this.startListener.TabIndex = 0;
            this.startListener.Text = "启动监听";
            this.startListener.Click += new System.EventHandler(this.startListener_Click);
            // 
            // newData
            // 
            this.newData.Location = new System.Drawing.Point(30, 30);
            this.newData.Name = "newData";
            this.newData.Size = new System.Drawing.Size(75, 23);
            this.newData.TabIndex = 0;
            this.newData.Text = "数据刷新";
            this.newData.UseVisualStyleBackColor = true;
            this.newData.Click += new System.EventHandler(this.newData_Click);
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
            this.dataGridView.Location = new System.Drawing.Point(30, 80);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.Size = new System.Drawing.Size(720, 350);
            this.dataGridView.TabIndex = 11;
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
            // queryStudent
            // 
            this.queryStudent.Location = new System.Drawing.Point(350, 30);
            this.queryStudent.Name = "queryStudent";
            this.queryStudent.Size = new System.Drawing.Size(75, 23);
            this.queryStudent.TabIndex = 12;
            this.queryStudent.Text = "查询学生";
            this.queryStudent.UseVisualStyleBackColor = true;
            this.queryStudent.Click += new System.EventHandler(this.queryStudent_Click);
            // 
            // queryIllegal
            // 
            this.queryIllegal.Location = new System.Drawing.Point(433, 30);
            this.queryIllegal.Name = "queryIllegal";
            this.queryIllegal.Size = new System.Drawing.Size(75, 23);
            this.queryIllegal.TabIndex = 13;
            this.queryIllegal.Text = "查询非法";
            this.queryIllegal.UseVisualStyleBackColor = true;
            this.queryIllegal.Click += new System.EventHandler(this.queryIllegal_Click);
            // 
            // queryTime
            // 
            this.queryTime.Location = new System.Drawing.Point(514, 30);
            this.queryTime.Name = "queryTime";
            this.queryTime.Size = new System.Drawing.Size(75, 23);
            this.queryTime.TabIndex = 14;
            this.queryTime.Text = "查询时段";
            this.queryTime.UseVisualStyleBackColor = true;
            this.queryTime.Click += new System.EventHandler(this.queryTime_Click);
            // 
            // inputData
            // 
            this.inputData.Location = new System.Drawing.Point(192, 30);
            this.inputData.Name = "inputData";
            this.inputData.Size = new System.Drawing.Size(75, 23);
            this.inputData.TabIndex = 15;
            this.inputData.Text = "录入数据";
            this.inputData.UseVisualStyleBackColor = true;
            this.inputData.Click += new System.EventHandler(this.inputData_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.inputData);
            this.Controls.Add(this.queryTime);
            this.Controls.Add(this.queryIllegal);
            this.Controls.Add(this.queryStudent);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.startListener);
            this.Controls.Add(this.newData);
            this.Controls.Add(this.oldData);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "基于RFID的寝室门禁管理系统 - 管理端";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button oldData;
        private System.Windows.Forms.Button startListener;
        private System.Windows.Forms.Button newData;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button queryStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDataNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCardID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.Button queryIllegal;
        private System.Windows.Forms.Button queryTime;
        private System.Windows.Forms.Button inputData;
    }
}

