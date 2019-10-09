namespace DataBaseTest_1
{
    partial class FormInput
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
            this.inputMessage = new System.Windows.Forms.Button();
            this.label0 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picShow = new System.Windows.Forms.PictureBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.textCard = new System.Windows.Forms.TextBox();
            this.newMessage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.choosePic = new System.Windows.Forms.Button();
            this.combo1 = new System.Windows.Forms.ComboBox();
            this.combo2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            this.SuspendLayout();
            // 
            // returnMain
            // 
            this.returnMain.Location = new System.Drawing.Point(30, 20);
            this.returnMain.Name = "returnMain";
            this.returnMain.Size = new System.Drawing.Size(75, 23);
            this.returnMain.TabIndex = 0;
            this.returnMain.Text = "返回上页";
            this.returnMain.UseVisualStyleBackColor = true;
            this.returnMain.Click += new System.EventHandler(this.returnMain_Click);
            // 
            // inputMessage
            // 
            this.inputMessage.Location = new System.Drawing.Point(186, 290);
            this.inputMessage.Name = "inputMessage";
            this.inputMessage.Size = new System.Drawing.Size(75, 23);
            this.inputMessage.TabIndex = 10;
            this.inputMessage.Text = "录入";
            this.inputMessage.UseVisualStyleBackColor = true;
            this.inputMessage.Click += new System.EventHandler(this.inputMessage_Click);
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label0.Location = new System.Drawing.Point(50, 65);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(104, 16);
            this.label0.TabIndex = 41;
            this.label0.Text = "录入学生信息";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(305, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "寝室号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(75, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "卡  号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(305, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "学  号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(75, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "姓  名：";
            // 
            // picShow
            // 
            this.picShow.Location = new System.Drawing.Point(316, 178);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(214, 135);
            this.picShow.TabIndex = 32;
            this.picShow.TabStop = false;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(141, 103);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(120, 21);
            this.textName.TabIndex = 2;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(371, 103);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(159, 21);
            this.textID.TabIndex = 3;
            this.textID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCard_KeyPress);
            // 
            // textCard
            // 
            this.textCard.Location = new System.Drawing.Point(141, 143);
            this.textCard.Name = "textCard";
            this.textCard.Size = new System.Drawing.Size(120, 21);
            this.textCard.TabIndex = 4;
            this.textCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textID_KeyPress);
            // 
            // newMessage
            // 
            this.newMessage.Location = new System.Drawing.Point(86, 290);
            this.newMessage.Name = "newMessage";
            this.newMessage.Size = new System.Drawing.Size(75, 23);
            this.newMessage.TabIndex = 9;
            this.newMessage.Text = "重置";
            this.newMessage.UseVisualStyleBackColor = true;
            this.newMessage.Click += new System.EventHandler(this.newMessage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // choosePic
            // 
            this.choosePic.Location = new System.Drawing.Point(186, 215);
            this.choosePic.Name = "choosePic";
            this.choosePic.Size = new System.Drawing.Size(75, 23);
            this.choosePic.TabIndex = 7;
            this.choosePic.Text = "选择图片";
            this.choosePic.UseVisualStyleBackColor = true;
            this.choosePic.Click += new System.EventHandler(this.choosePic_Click);
            // 
            // combo1
            // 
            this.combo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo1.FormattingEnabled = true;
            this.combo1.Location = new System.Drawing.Point(371, 143);
            this.combo1.Name = "combo1";
            this.combo1.Size = new System.Drawing.Size(75, 20);
            this.combo1.TabIndex = 5;
            // 
            // combo2
            // 
            this.combo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo2.FormattingEnabled = true;
            this.combo2.Location = new System.Drawing.Point(455, 143);
            this.combo2.Name = "combo2";
            this.combo2.Size = new System.Drawing.Size(75, 20);
            this.combo2.TabIndex = 6;
            this.combo2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combo2_KeyPress);
            // 
            // FormInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.combo2);
            this.Controls.Add(this.combo1);
            this.Controls.Add(this.choosePic);
            this.Controls.Add(this.newMessage);
            this.Controls.Add(this.textCard);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.inputMessage);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picShow);
            this.Controls.Add(this.returnMain);
            this.Name = "FormInput";
            this.Text = "基于RFID的寝室门禁管理系统 - 学生信息录入";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormInput_FormClosed);
            this.Load += new System.EventHandler(this.FormInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button returnMain;
        private System.Windows.Forms.Button inputMessage;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picShow;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.TextBox textCard;
        private System.Windows.Forms.Button newMessage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button choosePic;
        private System.Windows.Forms.ComboBox combo1;
        private System.Windows.Forms.ComboBox combo2;
    }
}