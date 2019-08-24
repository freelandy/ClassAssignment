namespace ClassAssignment
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabStudent = new System.Windows.Forms.TabPage();
            this.chkLiberalArts = new System.Windows.Forms.CheckBox();
            this.btnSetScience = new System.Windows.Forms.Button();
            this.btnSetLiberalArts = new System.Windows.Forms.Button();
            this.lblTotalStudents = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chkNoClass = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchXm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearchBkksh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgStudent = new System.Windows.Forms.DataGridView();
            this.uid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zkksh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sfwk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sfbd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabClass = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cbXZBjlb = new System.Windows.Forms.ComboBox();
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.lblAverage = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblGirls = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBoys = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgClassStudent = new System.Windows.Forms.DataGridView();
            this.s_uid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_zkksh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_xm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_xb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_mz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_zf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDeleteClass = new System.Windows.Forms.Button();
            this.btnEditClass = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.txtBzrxm = new System.Windows.Forms.TextBox();
            this.cbBjlb = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBjmc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dgClass = new System.Windows.Forms.DataGridView();
            this.class_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bjmc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bjlb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bzrxm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabStudent.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudent)).BeginInit();
            this.tabClass.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClassStudent)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClass)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabStudent);
            this.tabControl1.Controls.Add(this.tabClass);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(957, 626);
            this.tabControl1.TabIndex = 0;
            // 
            // tabStudent
            // 
            this.tabStudent.Controls.Add(this.chkLiberalArts);
            this.tabStudent.Controls.Add(this.btnSetScience);
            this.tabStudent.Controls.Add(this.btnSetLiberalArts);
            this.tabStudent.Controls.Add(this.lblTotalStudents);
            this.tabStudent.Controls.Add(this.label9);
            this.tabStudent.Controls.Add(this.chkNoClass);
            this.tabStudent.Controls.Add(this.groupBox2);
            this.tabStudent.Controls.Add(this.groupBox1);
            this.tabStudent.Controls.Add(this.dgStudent);
            this.tabStudent.Location = new System.Drawing.Point(4, 22);
            this.tabStudent.Name = "tabStudent";
            this.tabStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudent.Size = new System.Drawing.Size(949, 600);
            this.tabStudent.TabIndex = 0;
            this.tabStudent.Text = "学生数据";
            this.tabStudent.UseVisualStyleBackColor = true;
            // 
            // chkLiberalArts
            // 
            this.chkLiberalArts.AutoSize = true;
            this.chkLiberalArts.Location = new System.Drawing.Point(360, 204);
            this.chkLiberalArts.Name = "chkLiberalArts";
            this.chkLiberalArts.Size = new System.Drawing.Size(96, 16);
            this.chkLiberalArts.TabIndex = 8;
            this.chkLiberalArts.Text = "仅显示文科生";
            this.chkLiberalArts.UseVisualStyleBackColor = true;
            this.chkLiberalArts.CheckedChanged += new System.EventHandler(this.ChkLiberalArts_CheckedChanged);
            // 
            // btnSetScience
            // 
            this.btnSetScience.Location = new System.Drawing.Point(826, 201);
            this.btnSetScience.Name = "btnSetScience";
            this.btnSetScience.Size = new System.Drawing.Size(97, 23);
            this.btnSetScience.TabIndex = 7;
            this.btnSetScience.Text = "取消文科生";
            this.btnSetScience.UseVisualStyleBackColor = true;
            this.btnSetScience.Click += new System.EventHandler(this.BtnSetScience_Click);
            // 
            // btnSetLiberalArts
            // 
            this.btnSetLiberalArts.Location = new System.Drawing.Point(705, 201);
            this.btnSetLiberalArts.Name = "btnSetLiberalArts";
            this.btnSetLiberalArts.Size = new System.Drawing.Size(97, 23);
            this.btnSetLiberalArts.TabIndex = 6;
            this.btnSetLiberalArts.Text = "设为文科生";
            this.btnSetLiberalArts.UseVisualStyleBackColor = true;
            this.btnSetLiberalArts.Click += new System.EventHandler(this.BtnSetLiberalArts_Click);
            // 
            // lblTotalStudents
            // 
            this.lblTotalStudents.AutoSize = true;
            this.lblTotalStudents.Location = new System.Drawing.Point(73, 206);
            this.lblTotalStudents.Name = "lblTotalStudents";
            this.lblTotalStudents.Size = new System.Drawing.Size(0, 12);
            this.lblTotalStudents.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 4;
            this.label9.Text = "记录总数:";
            // 
            // chkNoClass
            // 
            this.chkNoClass.AutoSize = true;
            this.chkNoClass.Location = new System.Drawing.Point(192, 204);
            this.chkNoClass.Name = "chkNoClass";
            this.chkNoClass.Size = new System.Drawing.Size(120, 16);
            this.chkNoClass.TabIndex = 3;
            this.chkNoClass.Text = "仅显示未分班学生";
            this.chkNoClass.UseVisualStyleBackColor = true;
            this.chkNoClass.CheckedChanged += new System.EventHandler(this.ChkNoClass_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.txtSearchXm);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSearchBkksh);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(8, 102);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(933, 76);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查找";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(818, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(97, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "查找";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchXm
            // 
            this.txtSearchXm.Location = new System.Drawing.Point(465, 30);
            this.txtSearchXm.Name = "txtSearchXm";
            this.txtSearchXm.Size = new System.Drawing.Size(279, 21);
            this.txtSearchXm.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "姓名:";
            // 
            // txtSearchBkksh
            // 
            this.txtSearchBkksh.Location = new System.Drawing.Point(89, 30);
            this.txtSearchBkksh.Name = "txtSearchBkksh";
            this.txtSearchBkksh.Size = new System.Drawing.Size(279, 21);
            this.txtSearchBkksh.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "考生号:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnImport);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.txtFileName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(933, 76);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "导入";
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.Location = new System.Drawing.Point(818, 30);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(97, 23);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "导入";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(758, 30);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(36, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(89, 31);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.ReadOnly = true;
            this.txtFileName.Size = new System.Drawing.Size(655, 21);
            this.txtFileName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Excel文件:";
            // 
            // dgStudent
            // 
            this.dgStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uid,
            this.id,
            this.zkksh,
            this.xm,
            this.xb,
            this.mz,
            this.zf,
            this.sfwk,
            this.sfbd});
            this.dgStudent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgStudent.Location = new System.Drawing.Point(3, 237);
            this.dgStudent.MultiSelect = false;
            this.dgStudent.Name = "dgStudent";
            this.dgStudent.RowHeadersVisible = false;
            this.dgStudent.RowTemplate.Height = 23;
            this.dgStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgStudent.ShowEditingIcon = false;
            this.dgStudent.Size = new System.Drawing.Size(943, 360);
            this.dgStudent.TabIndex = 0;
            this.dgStudent.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DgStudent_CellPainting);
            this.dgStudent.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgStudent_RowPostPaint);
            // 
            // uid
            // 
            this.uid.HeaderText = "序号";
            this.uid.Name = "uid";
            this.uid.ReadOnly = true;
            this.uid.Width = 54;
            // 
            // id
            // 
            this.id.DataPropertyName = "ID";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 42;
            // 
            // zkksh
            // 
            this.zkksh.DataPropertyName = "zkksh";
            this.zkksh.HeaderText = "考生号";
            this.zkksh.Name = "zkksh";
            this.zkksh.ReadOnly = true;
            this.zkksh.Width = 66;
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
            // mz
            // 
            this.mz.DataPropertyName = "mz";
            this.mz.HeaderText = "民族";
            this.mz.Name = "mz";
            this.mz.ReadOnly = true;
            this.mz.Width = 54;
            // 
            // zf
            // 
            this.zf.DataPropertyName = "zf";
            this.zf.HeaderText = "总分";
            this.zf.Name = "zf";
            this.zf.ReadOnly = true;
            this.zf.Width = 54;
            // 
            // sfwk
            // 
            this.sfwk.DataPropertyName = "sfwk";
            this.sfwk.HeaderText = "文科/理科";
            this.sfwk.Name = "sfwk";
            this.sfwk.ReadOnly = true;
            this.sfwk.Width = 84;
            // 
            // sfbd
            // 
            this.sfbd.DataPropertyName = "sfbd";
            this.sfbd.HeaderText = "是否报道";
            this.sfbd.Name = "sfbd";
            this.sfbd.ReadOnly = true;
            this.sfbd.Width = 78;
            // 
            // tabClass
            // 
            this.tabClass.Controls.Add(this.groupBox4);
            this.tabClass.Controls.Add(this.groupBox3);
            this.tabClass.Location = new System.Drawing.Point(4, 22);
            this.tabClass.Name = "tabClass";
            this.tabClass.Padding = new System.Windows.Forms.Padding(3);
            this.tabClass.Size = new System.Drawing.Size(949, 600);
            this.tabClass.TabIndex = 1;
            this.tabClass.Text = "分班信息";
            this.tabClass.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnClear);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.cbXZBjlb);
            this.groupBox4.Controls.Add(this.btnAuto);
            this.groupBox4.Controls.Add(this.btnExport);
            this.groupBox4.Controls.Add(this.btnManual);
            this.groupBox4.Controls.Add(this.lblAverage);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.lblGirls);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.lblBoys);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.lblTotal);
            this.groupBox4.Controls.Add(this.dgClassStudent);
            this.groupBox4.Location = new System.Drawing.Point(258, 15);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(683, 577);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "班级学生";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(480, 485);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "清空分班信息";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 491);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 12);
            this.label10.TabIndex = 17;
            this.label10.Text = "选择自动分班类别:";
            // 
            // cbXZBjlb
            // 
            this.cbXZBjlb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbXZBjlb.FormattingEnabled = true;
            this.cbXZBjlb.Items.AddRange(new object[] {
            "民族创新班",
            "新疆实验班",
            "新疆普通班",
            "文科班"});
            this.cbXZBjlb.Location = new System.Drawing.Point(124, 488);
            this.cbXZBjlb.Name = "cbXZBjlb";
            this.cbXZBjlb.Size = new System.Drawing.Size(178, 20);
            this.cbXZBjlb.TabIndex = 16;
            // 
            // btnAuto
            // 
            this.btnAuto.Location = new System.Drawing.Point(320, 486);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(97, 23);
            this.btnAuto.TabIndex = 15;
            this.btnAuto.Text = "自动分班";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.BtnAuto_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(124, 533);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(97, 23);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "导出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnManual
            // 
            this.btnManual.Location = new System.Drawing.Point(6, 533);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(97, 23);
            this.btnManual.TabIndex = 13;
            this.btnManual.Text = "手动调整";
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Visible = false;
            this.btnManual.Click += new System.EventHandler(this.BtnManual_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(528, 426);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(0, 12);
            this.lblAverage.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(478, 426);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "平均分:";
            // 
            // lblGirls
            // 
            this.lblGirls.AutoSize = true;
            this.lblGirls.Location = new System.Drawing.Point(371, 427);
            this.lblGirls.Name = "lblGirls";
            this.lblGirls.Size = new System.Drawing.Size(0, 12);
            this.lblGirls.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 427);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "女  生:";
            // 
            // lblBoys
            // 
            this.lblBoys.AutoSize = true;
            this.lblBoys.Location = new System.Drawing.Point(218, 427);
            this.lblBoys.Name = "lblBoys";
            this.lblBoys.Size = new System.Drawing.Size(0, 12);
            this.lblBoys.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "男  生:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "总人数:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(61, 427);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 12);
            this.lblTotal.TabIndex = 1;
            // 
            // dgClassStudent
            // 
            this.dgClassStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgClassStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClassStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.s_uid,
            this.s_id,
            this.s_zkksh,
            this.s_xm,
            this.s_xb,
            this.s_mz,
            this.s_zf});
            this.dgClassStudent.Location = new System.Drawing.Point(6, 20);
            this.dgClassStudent.Name = "dgClassStudent";
            this.dgClassStudent.RowHeadersVisible = false;
            this.dgClassStudent.RowTemplate.Height = 23;
            this.dgClassStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClassStudent.Size = new System.Drawing.Size(671, 385);
            this.dgClassStudent.TabIndex = 0;
            this.dgClassStudent.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DgClassStudent_RowPostPaint);
            // 
            // s_uid
            // 
            this.s_uid.HeaderText = "序号";
            this.s_uid.Name = "s_uid";
            this.s_uid.ReadOnly = true;
            this.s_uid.Width = 54;
            // 
            // s_id
            // 
            this.s_id.DataPropertyName = "ID";
            this.s_id.HeaderText = "id";
            this.s_id.Name = "s_id";
            this.s_id.ReadOnly = true;
            this.s_id.Visible = false;
            // 
            // s_zkksh
            // 
            this.s_zkksh.DataPropertyName = "zkksh";
            this.s_zkksh.HeaderText = "考生号";
            this.s_zkksh.Name = "s_zkksh";
            this.s_zkksh.ReadOnly = true;
            this.s_zkksh.Width = 66;
            // 
            // s_xm
            // 
            this.s_xm.DataPropertyName = "xm";
            this.s_xm.HeaderText = "姓名";
            this.s_xm.Name = "s_xm";
            this.s_xm.ReadOnly = true;
            this.s_xm.Width = 54;
            // 
            // s_xb
            // 
            this.s_xb.DataPropertyName = "xb";
            this.s_xb.HeaderText = "性别";
            this.s_xb.Name = "s_xb";
            this.s_xb.ReadOnly = true;
            this.s_xb.Width = 54;
            // 
            // s_mz
            // 
            this.s_mz.DataPropertyName = "mz";
            this.s_mz.HeaderText = "民族";
            this.s_mz.Name = "s_mz";
            this.s_mz.ReadOnly = true;
            this.s_mz.Width = 54;
            // 
            // s_zf
            // 
            this.s_zf.DataPropertyName = "zf";
            this.s_zf.HeaderText = "总分";
            this.s_zf.Name = "s_zf";
            this.s_zf.ReadOnly = true;
            this.s_zf.Width = 54;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDeleteClass);
            this.groupBox3.Controls.Add(this.btnEditClass);
            this.groupBox3.Controls.Add(this.btnAddClass);
            this.groupBox3.Controls.Add(this.txtBzrxm);
            this.groupBox3.Controls.Add(this.cbBjlb);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtBjmc);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.dgClass);
            this.groupBox3.Location = new System.Drawing.Point(8, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(244, 577);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "班级";
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.Location = new System.Drawing.Point(181, 533);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.Size = new System.Drawing.Size(57, 23);
            this.btnDeleteClass.TabIndex = 10;
            this.btnDeleteClass.Text = "删除";
            this.btnDeleteClass.UseVisualStyleBackColor = true;
            this.btnDeleteClass.Click += new System.EventHandler(this.BtnDeleteClass_Click);
            // 
            // btnEditClass
            // 
            this.btnEditClass.Location = new System.Drawing.Point(95, 533);
            this.btnEditClass.Name = "btnEditClass";
            this.btnEditClass.Size = new System.Drawing.Size(57, 23);
            this.btnEditClass.TabIndex = 9;
            this.btnEditClass.Text = "修改";
            this.btnEditClass.UseVisualStyleBackColor = true;
            this.btnEditClass.Click += new System.EventHandler(this.BtnEditClass_Click);
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(6, 533);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(57, 23);
            this.btnAddClass.TabIndex = 8;
            this.btnAddClass.Text = "添加";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.BtnAddClass_Click);
            // 
            // txtBzrxm
            // 
            this.txtBzrxm.Location = new System.Drawing.Point(60, 491);
            this.txtBzrxm.Name = "txtBzrxm";
            this.txtBzrxm.Size = new System.Drawing.Size(178, 21);
            this.txtBzrxm.TabIndex = 7;
            // 
            // cbBjlb
            // 
            this.cbBjlb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBjlb.FormattingEnabled = true;
            this.cbBjlb.Items.AddRange(new object[] {
            "民族创新班",
            "新疆实验班",
            "新疆普通班",
            "文科班"});
            this.cbBjlb.Location = new System.Drawing.Point(60, 457);
            this.cbBjlb.Name = "cbBjlb";
            this.cbBjlb.Size = new System.Drawing.Size(178, 20);
            this.cbBjlb.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 494);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 12);
            this.label13.TabIndex = 5;
            this.label13.Text = "班主任:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 461);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 12);
            this.label12.TabIndex = 3;
            this.label12.Text = "类  型:";
            // 
            // txtBjmc
            // 
            this.txtBjmc.Location = new System.Drawing.Point(60, 423);
            this.txtBjmc.Name = "txtBjmc";
            this.txtBjmc.Size = new System.Drawing.Size(178, 21);
            this.txtBjmc.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 427);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = "名  称:";
            // 
            // dgClass
            // 
            this.dgClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.class_id,
            this.bjmc,
            this.bjlb,
            this.bzrxm});
            this.dgClass.Location = new System.Drawing.Point(6, 20);
            this.dgClass.MultiSelect = false;
            this.dgClass.Name = "dgClass";
            this.dgClass.ReadOnly = true;
            this.dgClass.RowHeadersVisible = false;
            this.dgClass.RowTemplate.Height = 23;
            this.dgClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgClass.Size = new System.Drawing.Size(232, 385);
            this.dgClass.TabIndex = 0;
            this.dgClass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgClass_CellClick);
            // 
            // class_id
            // 
            this.class_id.DataPropertyName = "ID";
            this.class_id.HeaderText = "id";
            this.class_id.Name = "class_id";
            this.class_id.ReadOnly = true;
            this.class_id.Visible = false;
            this.class_id.Width = 23;
            // 
            // bjmc
            // 
            this.bjmc.DataPropertyName = "bjmc";
            this.bjmc.HeaderText = "名称";
            this.bjmc.Name = "bjmc";
            this.bjmc.ReadOnly = true;
            this.bjmc.Width = 54;
            // 
            // bjlb
            // 
            this.bjlb.DataPropertyName = "bjlb";
            this.bjlb.HeaderText = "类型";
            this.bjlb.Name = "bjlb";
            this.bjlb.ReadOnly = true;
            this.bjlb.Width = 54;
            // 
            // bzrxm
            // 
            this.bzrxm.DataPropertyName = "bzrxm";
            this.bzrxm.HeaderText = "班主任";
            this.bzrxm.Name = "bzrxm";
            this.bzrxm.ReadOnly = true;
            this.bzrxm.Width = 66;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 626);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "希望高中内高班分班";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabStudent.ResumeLayout(false);
            this.tabStudent.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgStudent)).EndInit();
            this.tabClass.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClassStudent)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabStudent;
        private System.Windows.Forms.TabPage tabClass;
        private System.Windows.Forms.DataGridView dgStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchXm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSearchBkksh;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgClass;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgClassStudent;
        private System.Windows.Forms.Label lblGirls;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBoys;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBjmc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBzrxm;
        private System.Windows.Forms.ComboBox cbBjlb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnDeleteClass;
        private System.Windows.Forms.Button btnEditClass;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.CheckBox chkNoClass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn uid;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn zkksh;
        private System.Windows.Forms.DataGridViewTextBoxColumn xm;
        private System.Windows.Forms.DataGridViewTextBoxColumn xb;
        private System.Windows.Forms.DataGridViewTextBoxColumn mz;
        private System.Windows.Forms.DataGridViewTextBoxColumn zf;
        private System.Windows.Forms.DataGridViewTextBoxColumn sfwk;
        private System.Windows.Forms.DataGridViewTextBoxColumn sfbd;
        private System.Windows.Forms.Button btnSetScience;
        private System.Windows.Forms.Button btnSetLiberalArts;
        private System.Windows.Forms.DataGridViewTextBoxColumn class_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn bjmc;
        private System.Windows.Forms.DataGridViewTextBoxColumn bjlb;
        private System.Windows.Forms.DataGridViewTextBoxColumn bzrxm;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_uid;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_zkksh;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_xm;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_xb;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_mz;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_zf;
        private System.Windows.Forms.ComboBox cbXZBjlb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkLiberalArts;
    }
}

