namespace RGCA
{
    partial class AnaForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lst_displayBın = new System.Windows.Forms.ListBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.button14 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_binEmpId = new System.Windows.Forms.TextBox();
            this.txt_binID_employee = new System.Windows.Forms.TextBox();
            this.txt_Bin_emp_ID = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button13 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_empSurname11 = new System.Windows.Forms.TextBox();
            this.txt_empName11 = new System.Windows.Forms.TextBox();
            this.txt_employeeId11 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.txt_wasteDPId11 = new System.Windows.Forms.TextBox();
            this.txt_location11 = new System.Windows.Forms.TextBox();
            this.txt_trashType11 = new System.Windows.Forms.TextBox();
            this.txt_garbageType11 = new System.Windows.Forms.TextBox();
            this.txt_binName11 = new System.Windows.Forms.TextBox();
            this.txt_binId11 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.rGCADataSet = new RGCA.RGCADataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lst_display = new System.Windows.Forms.ListBox();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rGCADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.lst_display);
            this.groupBox2.Location = new System.Drawing.Point(4, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(746, 303);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "General Inofrmation";
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox6.Controls.Add(this.lst_displayBın);
            this.groupBox6.Location = new System.Drawing.Point(0, 151);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(745, 142);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "BIN Information(Under Update and delete, select the data here.)";
            // 
            // lst_displayBın
            // 
            this.lst_displayBın.FormattingEnabled = true;
            this.lst_displayBın.Location = new System.Drawing.Point(5, 20);
            this.lst_displayBın.Name = "lst_displayBın";
            this.lst_displayBın.Size = new System.Drawing.Size(732, 147);
            this.lst_displayBın.TabIndex = 0;
            this.lst_displayBın.SelectedIndexChanged += new System.EventHandler(this.lst_displayBın_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(746, 530);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Employee";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Aqua;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 232);
            this.dataGridView2.Name = "dataGridView2";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView2.Size = new System.Drawing.Size(736, 276);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(737, 219);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Employee Operations";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox5.Controls.Add(this.maskedTextBox2);
            this.groupBox5.Controls.Add(this.button14);
            this.groupBox5.Controls.Add(this.button11);
            this.groupBox5.Controls.Add(this.button12);
            this.groupBox5.Controls.Add(this.button10);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.txt_binEmpId);
            this.groupBox5.Controls.Add(this.txt_binID_employee);
            this.groupBox5.Controls.Add(this.txt_Bin_emp_ID);
            this.groupBox5.Location = new System.Drawing.Point(381, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(349, 194);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "New BIN Employee";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.BackColor = System.Drawing.SystemColors.Info;
            this.maskedTextBox2.Location = new System.Drawing.Point(9, 131);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(334, 20);
            this.maskedTextBox2.TabIndex = 21;
            this.maskedTextBox2.Text = "In order to enter information, data control should be done with buttons.";
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button14.Location = new System.Drawing.Point(9, 15);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(240, 23);
            this.button14.TabIndex = 3;
            this.button14.Text = "Show BIN Employee";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button11.Location = new System.Drawing.Point(9, 70);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 2;
            this.button11.Text = "BIN ID";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button12.Location = new System.Drawing.Point(9, 102);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 2;
            this.button12.Text = "Employee ID";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button10.Location = new System.Drawing.Point(100, 157);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(149, 23);
            this.button10.TabIndex = 2;
            this.button10.Text = "Add BIN Employee";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "BIN Employee ID";
            // 
            // txt_binEmpId
            // 
            this.txt_binEmpId.Location = new System.Drawing.Point(100, 105);
            this.txt_binEmpId.Name = "txt_binEmpId";
            this.txt_binEmpId.Size = new System.Drawing.Size(149, 20);
            this.txt_binEmpId.TabIndex = 1;
            // 
            // txt_binID_employee
            // 
            this.txt_binID_employee.Location = new System.Drawing.Point(100, 72);
            this.txt_binID_employee.Name = "txt_binID_employee";
            this.txt_binID_employee.Size = new System.Drawing.Size(149, 20);
            this.txt_binID_employee.TabIndex = 1;
            // 
            // txt_Bin_emp_ID
            // 
            this.txt_Bin_emp_ID.Location = new System.Drawing.Point(100, 44);
            this.txt_Bin_emp_ID.Name = "txt_Bin_emp_ID";
            this.txt_Bin_emp_ID.Size = new System.Drawing.Size(149, 20);
            this.txt_Bin_emp_ID.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox4.Controls.Add(this.button13);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.txt_empSurname11);
            this.groupBox4.Controls.Add(this.txt_empName11);
            this.groupBox4.Controls.Add(this.txt_employeeId11);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(6, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(369, 194);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "New Employee";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button13.Location = new System.Drawing.Point(7, 16);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(240, 23);
            this.button13.TabIndex = 3;
            this.button13.Text = "Show Employee";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(119, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add Employee";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_empSurname11
            // 
            this.txt_empSurname11.Location = new System.Drawing.Point(119, 110);
            this.txt_empSurname11.Name = "txt_empSurname11";
            this.txt_empSurname11.Size = new System.Drawing.Size(128, 20);
            this.txt_empSurname11.TabIndex = 1;
            // 
            // txt_empName11
            // 
            this.txt_empName11.Location = new System.Drawing.Point(119, 77);
            this.txt_empName11.Name = "txt_empName11";
            this.txt_empName11.Size = new System.Drawing.Size(128, 20);
            this.txt_empName11.TabIndex = 1;
            // 
            // txt_employeeId11
            // 
            this.txt_employeeId11.Location = new System.Drawing.Point(120, 48);
            this.txt_employeeId11.Name = "txt_employeeId11";
            this.txt_employeeId11.Size = new System.Drawing.Size(128, 20);
            this.txt_employeeId11.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Employee Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Employee Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(746, 530);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "BIN";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.OrangeRed;
            this.pictureBox1.Image = global::RGCA.Properties.Resources.Webp_net_resizeimage__2_;
            this.pictureBox1.Location = new System.Drawing.Point(6, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 202);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button16);
            this.groupBox1.Controls.Add(this.button15);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.txt_wasteDPId11);
            this.groupBox1.Controls.Add(this.txt_location11);
            this.groupBox1.Controls.Add(this.txt_trashType11);
            this.groupBox1.Controls.Add(this.txt_garbageType11);
            this.groupBox1.Controls.Add(this.txt_binName11);
            this.groupBox1.Controls.Add(this.txt_binId11);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(183, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Garbage Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BackColor = System.Drawing.SystemColors.Info;
            this.maskedTextBox1.Location = new System.Drawing.Point(16, 102);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(538, 20);
            this.maskedTextBox1.TabIndex = 20;
            this.maskedTextBox1.Text = "In order to enter information, data control should be done with buttons.";
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 19;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Red;
            this.button16.Location = new System.Drawing.Point(435, 188);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(119, 23);
            this.button16.TabIndex = 18;
            this.button16.Text = "Exit";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button15.Location = new System.Drawing.Point(16, 18);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(139, 23);
            this.button15.TabIndex = 17;
            this.button15.Text = "BIN Detail";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "BIN Name";
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.GrayText;
            this.button9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button9.Location = new System.Drawing.Point(140, 188);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(289, 23);
            this.button9.TabIndex = 13;
            this.button9.Text = "Delete BIN";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.GrayText;
            this.button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button8.Location = new System.Drawing.Point(140, 158);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(289, 23);
            this.button8.TabIndex = 12;
            this.button8.Text = "Update BIN";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.GrayText;
            this.button7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button7.Location = new System.Drawing.Point(140, 128);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(289, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "Add BIN";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // txt_wasteDPId11
            // 
            this.txt_wasteDPId11.Location = new System.Drawing.Point(423, 78);
            this.txt_wasteDPId11.Name = "txt_wasteDPId11";
            this.txt_wasteDPId11.Size = new System.Drawing.Size(131, 20);
            this.txt_wasteDPId11.TabIndex = 11;
            // 
            // txt_location11
            // 
            this.txt_location11.Location = new System.Drawing.Point(423, 49);
            this.txt_location11.Name = "txt_location11";
            this.txt_location11.Size = new System.Drawing.Size(131, 20);
            this.txt_location11.TabIndex = 10;
            // 
            // txt_trashType11
            // 
            this.txt_trashType11.Location = new System.Drawing.Point(423, 21);
            this.txt_trashType11.Name = "txt_trashType11";
            this.txt_trashType11.Size = new System.Drawing.Size(131, 20);
            this.txt_trashType11.TabIndex = 9;
            // 
            // txt_garbageType11
            // 
            this.txt_garbageType11.Location = new System.Drawing.Point(161, 79);
            this.txt_garbageType11.Name = "txt_garbageType11";
            this.txt_garbageType11.Size = new System.Drawing.Size(109, 20);
            this.txt_garbageType11.TabIndex = 8;
            // 
            // txt_binName11
            // 
            this.txt_binName11.Location = new System.Drawing.Point(161, 50);
            this.txt_binName11.Name = "txt_binName11";
            this.txt_binName11.Size = new System.Drawing.Size(109, 20);
            this.txt_binName11.TabIndex = 7;
            // 
            // txt_binId11
            // 
            this.txt_binId11.Location = new System.Drawing.Point(161, 21);
            this.txt_binId11.Name = "txt_binId11";
            this.txt_binId11.Size = new System.Drawing.Size(109, 20);
            this.txt_binId11.TabIndex = 6;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button6.Location = new System.Drawing.Point(276, 77);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(141, 23);
            this.button6.TabIndex = 5;
            this.button6.Text = "Waste Disposal Point";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button3.Location = new System.Drawing.Point(16, 77);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Garbage Types";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button5.Location = new System.Drawing.Point(276, 48);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Locations";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button4.Location = new System.Drawing.Point(276, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(141, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Trash Types";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.DropList;
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(754, 556);
            this.tabControl1.TabIndex = 0;
            // 
            // rGCADataSet
            // 
            this.rGCADataSet.DataSetName = "RGCADataSet";
            this.rGCADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(731, 126);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // lst_display
            // 
            this.lst_display.FormattingEnabled = true;
            this.lst_display.Location = new System.Drawing.Point(198, 26);
            this.lst_display.Name = "lst_display";
            this.lst_display.Size = new System.Drawing.Size(233, 108);
            this.lst_display.TabIndex = 0;
            this.lst_display.SelectedIndexChanged += new System.EventHandler(this.lst_display_SelectedIndexChanged_1);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 555);
            this.Controls.Add(this.tabControl1);
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recycling Garbage Collector Application";
            this.Load += new System.EventHandler(this.AnaForm_Load_1);
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rGCADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_binEmpId;
        private System.Windows.Forms.TextBox txt_binID_employee;
        private System.Windows.Forms.TextBox txt_Bin_emp_ID;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_empSurname11;
        private System.Windows.Forms.TextBox txt_empName11;
        private System.Windows.Forms.TextBox txt_employeeId11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txt_wasteDPId11;
        private System.Windows.Forms.TextBox txt_location11;
        private System.Windows.Forms.TextBox txt_trashType11;
        private System.Windows.Forms.TextBox txt_garbageType11;
        private System.Windows.Forms.TextBox txt_binName11;
        private System.Windows.Forms.TextBox txt_binId11;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox lst_displayBın;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private RGCADataSet rGCADataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox lst_display;
    }
}