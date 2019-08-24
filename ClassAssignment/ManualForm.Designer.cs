namespace ClassAssignment
{
    partial class ManualForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDrbj = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtExchangeStudent = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblXm = new System.Windows.Forms.Label();
            this.lblXb = new System.Windows.Forms.Label();
            this.lblZf = new System.Windows.Forms.Label();
            this.lblBj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "调出学生:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "调出班级:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "总    分:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "性    别:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "调入班级:";
            // 
            // cbDrbj
            // 
            this.cbDrbj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDrbj.FormattingEnabled = true;
            this.cbDrbj.Location = new System.Drawing.Point(91, 224);
            this.cbDrbj.Name = "cbDrbj";
            this.cbDrbj.Size = new System.Drawing.Size(134, 20);
            this.cbDrbj.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "对调学生:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(231, 264);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(47, 23);
            this.btnBrowse.TabIndex = 9;
            this.btnBrowse.Text = "选择";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtExchangeStudent
            // 
            this.txtExchangeStudent.Location = new System.Drawing.Point(91, 265);
            this.txtExchangeStudent.Name = "txtExchangeStudent";
            this.txtExchangeStudent.ReadOnly = true;
            this.txtExchangeStudent.Size = new System.Drawing.Size(134, 21);
            this.txtExchangeStudent.TabIndex = 10;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(103, 313);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 11;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(203, 313);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lblXm
            // 
            this.lblXm.AutoSize = true;
            this.lblXm.Location = new System.Drawing.Point(89, 24);
            this.lblXm.Name = "lblXm";
            this.lblXm.Size = new System.Drawing.Size(47, 12);
            this.lblXm.TabIndex = 13;
            this.lblXm.Text = "[lblXm]";
            // 
            // lblXb
            // 
            this.lblXb.AutoSize = true;
            this.lblXb.Location = new System.Drawing.Point(89, 64);
            this.lblXb.Name = "lblXb";
            this.lblXb.Size = new System.Drawing.Size(47, 12);
            this.lblXb.TabIndex = 14;
            this.lblXb.Text = "[lblXb]";
            // 
            // lblZf
            // 
            this.lblZf.AutoSize = true;
            this.lblZf.Location = new System.Drawing.Point(89, 104);
            this.lblZf.Name = "lblZf";
            this.lblZf.Size = new System.Drawing.Size(47, 12);
            this.lblZf.TabIndex = 15;
            this.lblZf.Text = "[lblZf]";
            // 
            // lblBj
            // 
            this.lblBj.AutoSize = true;
            this.lblBj.Location = new System.Drawing.Point(89, 144);
            this.lblBj.Name = "lblBj";
            this.lblBj.Size = new System.Drawing.Size(47, 12);
            this.lblBj.TabIndex = 16;
            this.lblBj.Text = "[lblBj]";
            // 
            // ManualForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 353);
            this.Controls.Add(this.lblBj);
            this.Controls.Add(this.lblZf);
            this.Controls.Add(this.lblXb);
            this.Controls.Add(this.lblXm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtExchangeStudent);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbDrbj);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ManualForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "手动调整";
            this.Load += new System.EventHandler(this.ManualForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDrbj;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtExchangeStudent;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblXm;
        private System.Windows.Forms.Label lblXb;
        private System.Windows.Forms.Label lblZf;
        private System.Windows.Forms.Label lblBj;
    }
}