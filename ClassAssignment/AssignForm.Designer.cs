namespace ClassAssignment
{
    partial class AssignForm
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
            this.lnkInfo = new System.Windows.Forms.LinkLabel();
            this.rbtnRandom = new System.Windows.Forms.RadioButton();
            this.rbtnSnake = new System.Windows.Forms.RadioButton();
            this.rbtnEqual = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBjlb = new System.Windows.Forms.Label();
            this.lblBjsl = new System.Windows.Forms.Label();
            this.lblXszs = new System.Windows.Forms.Label();
            this.lblQsxs = new System.Windows.Forms.Label();
            this.lblJsxs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lnkInfo
            // 
            this.lnkInfo.AutoSize = true;
            this.lnkInfo.Location = new System.Drawing.Point(266, 234);
            this.lnkInfo.Name = "lnkInfo";
            this.lnkInfo.Size = new System.Drawing.Size(29, 12);
            this.lnkInfo.TabIndex = 24;
            this.lnkInfo.TabStop = true;
            this.lnkInfo.Text = "说明";
            this.lnkInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkInfo_LinkClicked);
            // 
            // rbtnRandom
            // 
            this.rbtnRandom.AutoSize = true;
            this.rbtnRandom.Location = new System.Drawing.Point(214, 232);
            this.rbtnRandom.Name = "rbtnRandom";
            this.rbtnRandom.Size = new System.Drawing.Size(47, 16);
            this.rbtnRandom.TabIndex = 23;
            this.rbtnRandom.Text = "随机";
            this.rbtnRandom.UseVisualStyleBackColor = true;
            this.rbtnRandom.CheckedChanged += new System.EventHandler(this.RbtnRandom_CheckedChanged);
            // 
            // rbtnSnake
            // 
            this.rbtnSnake.AutoSize = true;
            this.rbtnSnake.Checked = true;
            this.rbtnSnake.Location = new System.Drawing.Point(156, 232);
            this.rbtnSnake.Name = "rbtnSnake";
            this.rbtnSnake.Size = new System.Drawing.Size(47, 16);
            this.rbtnSnake.TabIndex = 22;
            this.rbtnSnake.TabStop = true;
            this.rbtnSnake.Text = "蛇形";
            this.rbtnSnake.UseVisualStyleBackColor = true;
            this.rbtnSnake.CheckedChanged += new System.EventHandler(this.RbtnSnake_CheckedChanged);
            // 
            // rbtnEqual
            // 
            this.rbtnEqual.AutoSize = true;
            this.rbtnEqual.Location = new System.Drawing.Point(98, 232);
            this.rbtnEqual.Name = "rbtnEqual";
            this.rbtnEqual.Size = new System.Drawing.Size(47, 16);
            this.rbtnEqual.TabIndex = 21;
            this.rbtnEqual.Text = "平行";
            this.rbtnEqual.UseVisualStyleBackColor = true;
            this.rbtnEqual.CheckedChanged += new System.EventHandler(this.RbtnEqual_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 26;
            this.label1.Text = "班级类别:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 27;
            this.label2.Text = "班级数量:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 28;
            this.label3.Text = "学生总数:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 29;
            this.label4.Text = "起始学生:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 30;
            this.label5.Text = "结束学生:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(282, 314);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 31;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(365, 314);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 33;
            this.label6.Text = "分班方式:";
            // 
            // lblBjlb
            // 
            this.lblBjlb.AutoSize = true;
            this.lblBjlb.Location = new System.Drawing.Point(94, 25);
            this.lblBjlb.Name = "lblBjlb";
            this.lblBjlb.Size = new System.Drawing.Size(59, 12);
            this.lblBjlb.TabIndex = 34;
            this.lblBjlb.Text = "[lblBjlb]";
            // 
            // lblBjsl
            // 
            this.lblBjsl.AutoSize = true;
            this.lblBjsl.Location = new System.Drawing.Point(94, 61);
            this.lblBjsl.Name = "lblBjsl";
            this.lblBjsl.Size = new System.Drawing.Size(59, 12);
            this.lblBjsl.TabIndex = 35;
            this.lblBjsl.Text = "[lblBjsl]";
            // 
            // lblXszs
            // 
            this.lblXszs.AutoSize = true;
            this.lblXszs.Location = new System.Drawing.Point(94, 97);
            this.lblXszs.Name = "lblXszs";
            this.lblXszs.Size = new System.Drawing.Size(59, 12);
            this.lblXszs.TabIndex = 36;
            this.lblXszs.Text = "[lblXszs]";
            // 
            // lblQsxs
            // 
            this.lblQsxs.AutoSize = true;
            this.lblQsxs.Location = new System.Drawing.Point(94, 133);
            this.lblQsxs.Name = "lblQsxs";
            this.lblQsxs.Size = new System.Drawing.Size(59, 12);
            this.lblQsxs.TabIndex = 37;
            this.lblQsxs.Text = "[lblQsxs]";
            // 
            // lblJsxs
            // 
            this.lblJsxs.AutoSize = true;
            this.lblJsxs.Location = new System.Drawing.Point(94, 169);
            this.lblJsxs.Name = "lblJsxs";
            this.lblJsxs.Size = new System.Drawing.Size(59, 12);
            this.lblJsxs.TabIndex = 38;
            this.lblJsxs.Text = "[lblJsxs]";
            // 
            // AssignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 350);
            this.Controls.Add(this.lblJsxs);
            this.Controls.Add(this.lblQsxs);
            this.Controls.Add(this.lblXszs);
            this.Controls.Add(this.lblBjsl);
            this.Controls.Add(this.lblBjlb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lnkInfo);
            this.Controls.Add(this.rbtnRandom);
            this.Controls.Add(this.rbtnSnake);
            this.Controls.Add(this.rbtnEqual);
            this.Name = "AssignForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "希望高中内高班分班";
            this.Load += new System.EventHandler(this.AssignForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel lnkInfo;
        private System.Windows.Forms.RadioButton rbtnRandom;
        private System.Windows.Forms.RadioButton rbtnSnake;
        private System.Windows.Forms.RadioButton rbtnEqual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBjlb;
        private System.Windows.Forms.Label lblBjsl;
        private System.Windows.Forms.Label lblXszs;
        private System.Windows.Forms.Label lblQsxs;
        private System.Windows.Forms.Label lblJsxs;
    }
}