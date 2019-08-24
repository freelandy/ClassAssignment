namespace ClassAssignment
{
    partial class SelectNewStudentForm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblNewClass = new System.Windows.Forms.Label();
            this.dgRecommendedStudent = new System.Windows.Forms.DataGridView();
            this.r_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r_xm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r_xb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.r_zf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgStudent = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecommendedStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "调入班级:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "建议对调学生";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "所有学生";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(503, 362);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(611, 362);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblNewClass
            // 
            this.lblNewClass.AutoSize = true;
            this.lblNewClass.Location = new System.Drawing.Point(79, 18);
            this.lblNewClass.Name = "lblNewClass";
            this.lblNewClass.Size = new System.Drawing.Size(83, 12);
            this.lblNewClass.TabIndex = 7;
            this.lblNewClass.Text = "[lblNewClass]";
            // 
            // dgRecommendedStudent
            // 
            this.dgRecommendedStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgRecommendedStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRecommendedStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.r_id,
            this.r_xm,
            this.r_xb,
            this.r_zf});
            this.dgRecommendedStudent.Location = new System.Drawing.Point(16, 110);
            this.dgRecommendedStudent.MultiSelect = false;
            this.dgRecommendedStudent.Name = "dgRecommendedStudent";
            this.dgRecommendedStudent.ReadOnly = true;
            this.dgRecommendedStudent.RowHeadersVisible = false;
            this.dgRecommendedStudent.RowTemplate.Height = 23;
            this.dgRecommendedStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgRecommendedStudent.Size = new System.Drawing.Size(323, 226);
            this.dgRecommendedStudent.TabIndex = 8;
            // 
            // r_id
            // 
            this.r_id.DataPropertyName = "ID";
            this.r_id.HeaderText = "id";
            this.r_id.Name = "r_id";
            this.r_id.ReadOnly = true;
            this.r_id.Visible = false;
            // 
            // r_xm
            // 
            this.r_xm.DataPropertyName = "xm";
            this.r_xm.HeaderText = "姓名";
            this.r_xm.Name = "r_xm";
            this.r_xm.ReadOnly = true;
            this.r_xm.Width = 54;
            // 
            // r_xb
            // 
            this.r_xb.DataPropertyName = "xb";
            this.r_xb.HeaderText = "性别";
            this.r_xb.Name = "r_xb";
            this.r_xb.ReadOnly = true;
            this.r_xb.Width = 54;
            // 
            // r_zf
            // 
            this.r_zf.DataPropertyName = "zf";
            this.r_zf.HeaderText = "总分";
            this.r_zf.Name = "r_zf";
            this.r_zf.ReadOnly = true;
            this.r_zf.Width = 54;
            // 
            // dgStudent
            // 
            this.dgStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.xm,
            this.xb,
            this.zf});
            this.dgStudent.Location = new System.Drawing.Point(359, 110);
            this.dgStudent.MultiSelect = false;
            this.dgStudent.Name = "dgStudent";
            this.dgStudent.ReadOnly = true;
            this.dgStudent.RowHeadersVisible = false;
            this.dgStudent.RowTemplate.Height = 23;
            this.dgStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgStudent.Size = new System.Drawing.Size(323, 226);
            this.dgStudent.TabIndex = 9;
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 23;
            // 
            // xm
            // 
            this.xm.DataPropertyName = "xm";
            this.xm.HeaderText = "姓名";
            this.xm.Name = "xm";
            this.xm.ReadOnly = true;
            this.xm.Width = 54;
            // 
            // xb
            // 
            this.xb.DataPropertyName = "xb";
            this.xb.HeaderText = "性别";
            this.xb.Name = "xb";
            this.xb.ReadOnly = true;
            this.xb.Width = 54;
            // 
            // zf
            // 
            this.zf.DataPropertyName = "zf";
            this.zf.HeaderText = "总分";
            this.zf.Name = "zf";
            this.zf.ReadOnly = true;
            this.zf.Width = 54;
            // 
            // SelectNewStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 397);
            this.Controls.Add(this.dgStudent);
            this.Controls.Add(this.dgRecommendedStudent);
            this.Controls.Add(this.lblNewClass);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SelectNewStudentForm";
            this.Text = "选择对调学生";
            this.Load += new System.EventHandler(this.SelectNewStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgRecommendedStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblNewClass;
        private System.Windows.Forms.DataGridView dgRecommendedStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn r_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn r_xm;
        private System.Windows.Forms.DataGridViewTextBoxColumn r_xb;
        private System.Windows.Forms.DataGridViewTextBoxColumn r_zf;
        private System.Windows.Forms.DataGridView dgStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn xm;
        private System.Windows.Forms.DataGridViewTextBoxColumn xb;
        private System.Windows.Forms.DataGridViewTextBoxColumn zf;
    }
}