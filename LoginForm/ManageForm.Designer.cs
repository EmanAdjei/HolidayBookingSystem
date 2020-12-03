using System.Collections.Generic;

namespace LoginForm
{
    partial class ManageForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageForm));
            this.pnlCreate = new System.Windows.Forms.Panel();
            this.cbxRole = new System.Windows.Forms.ComboBox();
            this.cbxDept = new System.Windows.Forms.ComboBox();
            this.btnCreateEmploy = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.chbxDetails = new System.Windows.Forms.CheckBox();
            this.cbxERole = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdID = new System.Windows.Forms.RadioButton();
            this.rdName = new System.Windows.Forms.RadioButton();
            this.cbxEDept = new System.Windows.Forms.ComboBox();
            this.btnDeleteEmploy = new System.Windows.Forms.Button();
            this.dgvEdit = new System.Windows.Forms.DataGridView();
            this.btnEditEmploy = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtECounty = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtEPassword = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtEStreet = new System.Windows.Forms.TextBox();
            this.txtEDateJoined = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtECity = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtEEmail = new System.Windows.Forms.TextBox();
            this.txtELast = new System.Windows.Forms.TextBox();
            this.txtEPost = new System.Windows.Forms.TextBox();
            this.txtEFirst = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eDITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dELETEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.holidaysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEQUESTEDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tAKENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companySettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMenuStripe = new System.Windows.Forms.Panel();
            this.pnlTaken = new System.Windows.Forms.Panel();
            this.btnTAK_alltaken = new System.Windows.Forms.Button();
            this.cmbxTaken_search = new System.Windows.Forms.ComboBox();
            this.dgvTaken = new System.Windows.Forms.DataGridView();
            this.pnlRequested = new System.Windows.Forms.Panel();
            this.btnReq_Reject = new System.Windows.Forms.Button();
            this.dgvRequested = new System.Windows.Forms.DataGridView();
            this.btnReq_Approve = new System.Windows.Forms.Button();
            this.cbConstraints = new System.Windows.Forms.CheckBox();
            this.label44 = new System.Windows.Forms.Label();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lbNamePlaceHolder = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.dgvHome_leave = new System.Windows.Forms.DataGridView();
            this.dgvHome_working = new System.Windows.Forms.DataGridView();
            this.mcDate = new System.Windows.Forms.MonthCalendar();
            this.pnlCompanyPolicies = new System.Windows.Forms.Panel();
            this.numOnDutyRelaxed = new System.Windows.Forms.NumericUpDown();
            this.numEntitlement = new System.Windows.Forms.NumericUpDown();
            this.numOnDuty = new System.Windows.Forms.NumericUpDown();
            this.btnSaveSettings = new System.Windows.Forms.Button();
            this.dtpEasterEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpChristmasEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpSummerEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpEasterStart = new System.Windows.Forms.DateTimePicker();
            this.dtpChristmasStart = new System.Windows.Forms.DateTimePicker();
            this.dtpSummerStart = new System.Windows.Forms.DateTimePicker();
            this.cbManagerOrSenior = new System.Windows.Forms.CheckBox();
            this.cbHeadOrDeputy = new System.Windows.Forms.CheckBox();
            this.cbRelaxedMonth = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.createEmployee1 = new Component_A_ClassLibrary.CreateEmployee(this.components);
            this.editEmployee1 = new Component_A_ClassLibrary.EditEmployee(this.components);
            this.deleteEmployee1 = new Component_A_ClassLibrary.DeleteEmployee(this.components);
            this.txtComPhoneNumber = new Component_B_ClassLibrary.Functionality_B.PhoneNumberTextBox();
            this.onLeaveCalendarComponent1 = new Component_B_ClassLibrary.Functionality_F.OnLeaveCalendarComponent(this.components);
            this.txtEComPhoneNumber = new Component_B_ClassLibrary.Functionality_B.PhoneNumberTextBox();
            this.constraintChecker1 = new Component_B_ClassLibrary.Functionality_C.ConstraintChecker(this.components);
            this.pnlCreate.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdit)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnlMenuStripe.SuspendLayout();
            this.pnlTaken.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaken)).BeginInit();
            this.pnlRequested.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequested)).BeginInit();
            this.pnlHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHome_leave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHome_working)).BeginInit();
            this.pnlCompanyPolicies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOnDutyRelaxed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEntitlement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOnDuty)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCreate
            // 
            this.pnlCreate.Controls.Add(this.txtComPhoneNumber);
            this.pnlCreate.Controls.Add(this.cbxRole);
            this.pnlCreate.Controls.Add(this.cbxDept);
            this.pnlCreate.Controls.Add(this.btnCreateEmploy);
            this.pnlCreate.Controls.Add(this.label7);
            this.pnlCreate.Controls.Add(this.txtCounty);
            this.pnlCreate.Controls.Add(this.label20);
            this.pnlCreate.Controls.Add(this.label6);
            this.pnlCreate.Controls.Add(this.txtStreet);
            this.pnlCreate.Controls.Add(this.label8);
            this.pnlCreate.Controls.Add(this.txtCity);
            this.pnlCreate.Controls.Add(this.label5);
            this.pnlCreate.Controls.Add(this.label4);
            this.pnlCreate.Controls.Add(this.label3);
            this.pnlCreate.Controls.Add(this.label26);
            this.pnlCreate.Controls.Add(this.label2);
            this.pnlCreate.Controls.Add(this.label23);
            this.pnlCreate.Controls.Add(this.label25);
            this.pnlCreate.Controls.Add(this.label19);
            this.pnlCreate.Controls.Add(this.label1);
            this.pnlCreate.Controls.Add(this.txtEmail);
            this.pnlCreate.Controls.Add(this.txtSurname);
            this.pnlCreate.Controls.Add(this.txtPostcode);
            this.pnlCreate.Controls.Add(this.txtName);
            this.pnlCreate.Location = new System.Drawing.Point(803, 269);
            this.pnlCreate.Name = "pnlCreate";
            this.pnlCreate.Size = new System.Drawing.Size(34, 44);
            this.pnlCreate.TabIndex = 0;
            // 
            // cbxRole
            // 
            this.cbxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Location = new System.Drawing.Point(646, 182);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(121, 21);
            this.cbxRole.TabIndex = 9;
            // 
            // cbxDept
            // 
            this.cbxDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDept.FormattingEnabled = true;
            this.cbxDept.Location = new System.Drawing.Point(646, 123);
            this.cbxDept.Name = "cbxDept";
            this.cbxDept.Size = new System.Drawing.Size(121, 21);
            this.cbxDept.TabIndex = 8;
            // 
            // btnCreateEmploy
            // 
            this.btnCreateEmploy.Location = new System.Drawing.Point(371, 388);
            this.btnCreateEmploy.Name = "btnCreateEmploy";
            this.btnCreateEmploy.Size = new System.Drawing.Size(109, 37);
            this.btnCreateEmploy.TabIndex = 10;
            this.btnCreateEmploy.Text = "CREATE";
            this.btnCreateEmploy.UseVisualStyleBackColor = true;
            this.btnCreateEmploy.Click += new System.EventHandler(this.BtnCreateEmploy_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(347, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "County";
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(350, 241);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(150, 20);
            this.txtCounty.TabIndex = 6;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(345, 36);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(172, 25);
            this.label20.TabIndex = 17;
            this.label20.Text = "Home Address ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(347, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Street address ";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(350, 123);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(150, 20);
            this.txtStreet.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(347, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "City/Town";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(350, 182);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(150, 20);
            this.txtCity.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(347, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Postcode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(47, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(47, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telephone number";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label26.ForeColor = System.Drawing.Color.Transparent;
            this.label26.Location = new System.Drawing.Point(643, 156);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(37, 17);
            this.label26.TabIndex = 6;
            this.label26.Text = "Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(47, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last name";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label23.ForeColor = System.Drawing.Color.Transparent;
            this.label23.Location = new System.Drawing.Point(641, 36);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(105, 25);
            this.label23.TabIndex = 5;
            this.label23.Text = "Job Role";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label25.ForeColor = System.Drawing.Color.Transparent;
            this.label25.Location = new System.Drawing.Point(643, 97);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(82, 17);
            this.label25.TabIndex = 5;
            this.label25.Text = "Department";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(45, 36);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(185, 25);
            this.label19.TabIndex = 5;
            this.label19.Text = "Personal Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(47, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "First name ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(50, 300);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(50, 182);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(150, 20);
            this.txtSurname.TabIndex = 1;
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(350, 300);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(150, 20);
            this.txtPostcode.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(50, 123);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(150, 20);
            this.txtName.TabIndex = 0;
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.txtEComPhoneNumber);
            this.pnlEdit.Controls.Add(this.chbxDetails);
            this.pnlEdit.Controls.Add(this.cbxERole);
            this.pnlEdit.Controls.Add(this.groupBox1);
            this.pnlEdit.Controls.Add(this.cbxEDept);
            this.pnlEdit.Controls.Add(this.btnDeleteEmploy);
            this.pnlEdit.Controls.Add(this.dgvEdit);
            this.pnlEdit.Controls.Add(this.btnEditEmploy);
            this.pnlEdit.Controls.Add(this.txtSearch);
            this.pnlEdit.Controls.Add(this.btnSearch);
            this.pnlEdit.Controls.Add(this.label9);
            this.pnlEdit.Controls.Add(this.txtECounty);
            this.pnlEdit.Controls.Add(this.label18);
            this.pnlEdit.Controls.Add(this.txtEPassword);
            this.pnlEdit.Controls.Add(this.label22);
            this.pnlEdit.Controls.Add(this.label10);
            this.pnlEdit.Controls.Add(this.label17);
            this.pnlEdit.Controls.Add(this.label21);
            this.pnlEdit.Controls.Add(this.txtEStreet);
            this.pnlEdit.Controls.Add(this.txtEDateJoined);
            this.pnlEdit.Controls.Add(this.label11);
            this.pnlEdit.Controls.Add(this.txtECity);
            this.pnlEdit.Controls.Add(this.label12);
            this.pnlEdit.Controls.Add(this.label13);
            this.pnlEdit.Controls.Add(this.label14);
            this.pnlEdit.Controls.Add(this.label15);
            this.pnlEdit.Controls.Add(this.label16);
            this.pnlEdit.Controls.Add(this.txtEEmail);
            this.pnlEdit.Controls.Add(this.txtELast);
            this.pnlEdit.Controls.Add(this.txtEPost);
            this.pnlEdit.Controls.Add(this.txtEFirst);
            this.pnlEdit.Location = new System.Drawing.Point(803, 100);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(34, 42);
            this.pnlEdit.TabIndex = 4;
            // 
            // chbxDetails
            // 
            this.chbxDetails.AutoSize = true;
            this.chbxDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chbxDetails.ForeColor = System.Drawing.Color.White;
            this.chbxDetails.Location = new System.Drawing.Point(687, 192);
            this.chbxDetails.Name = "chbxDetails";
            this.chbxDetails.Size = new System.Drawing.Size(131, 21);
            this.chbxDetails.TabIndex = 10;
            this.chbxDetails.Text = "Sensitive Details";
            this.chbxDetails.UseVisualStyleBackColor = true;
            this.chbxDetails.CheckedChanged += new System.EventHandler(this.ChbxDetails_CheckedChanged);
            // 
            // cbxERole
            // 
            this.cbxERole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxERole.Enabled = false;
            this.cbxERole.FormattingEnabled = true;
            this.cbxERole.Location = new System.Drawing.Point(499, 264);
            this.cbxERole.Name = "cbxERole";
            this.cbxERole.Size = new System.Drawing.Size(150, 21);
            this.cbxERole.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdID);
            this.groupBox1.Controls.Add(this.rdName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(570, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 36);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            // 
            // rdID
            // 
            this.rdID.AutoSize = true;
            this.rdID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdID.ForeColor = System.Drawing.Color.White;
            this.rdID.Location = new System.Drawing.Point(92, 11);
            this.rdID.Name = "rdID";
            this.rdID.Size = new System.Drawing.Size(39, 20);
            this.rdID.TabIndex = 1;
            this.rdID.TabStop = true;
            this.rdID.Text = "ID";
            this.rdID.UseVisualStyleBackColor = true;
            // 
            // rdName
            // 
            this.rdName.AutoSize = true;
            this.rdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdName.ForeColor = System.Drawing.Color.White;
            this.rdName.Location = new System.Drawing.Point(9, 13);
            this.rdName.Name = "rdName";
            this.rdName.Size = new System.Drawing.Size(53, 17);
            this.rdName.TabIndex = 0;
            this.rdName.TabStop = true;
            this.rdName.Text = "Name";
            this.rdName.UseVisualStyleBackColor = true;
            // 
            // cbxEDept
            // 
            this.cbxEDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEDept.Enabled = false;
            this.cbxEDept.FormattingEnabled = true;
            this.cbxEDept.Location = new System.Drawing.Point(499, 215);
            this.cbxEDept.Name = "cbxEDept";
            this.cbxEDept.Size = new System.Drawing.Size(150, 21);
            this.cbxEDept.TabIndex = 11;
            // 
            // btnDeleteEmploy
            // 
            this.btnDeleteEmploy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEmploy.Location = new System.Drawing.Point(699, 344);
            this.btnDeleteEmploy.Name = "btnDeleteEmploy";
            this.btnDeleteEmploy.Size = new System.Drawing.Size(109, 37);
            this.btnDeleteEmploy.TabIndex = 15;
            this.btnDeleteEmploy.Text = "DELETE";
            this.btnDeleteEmploy.UseVisualStyleBackColor = true;
            this.btnDeleteEmploy.Click += new System.EventHandler(this.BtnDeleteEmploy_Click);
            // 
            // dgvEdit
            // 
            this.dgvEdit.AllowUserToAddRows = false;
            this.dgvEdit.AllowUserToDeleteRows = false;
            this.dgvEdit.AllowUserToResizeColumns = false;
            this.dgvEdit.AllowUserToResizeRows = false;
            this.dgvEdit.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEdit.Location = new System.Drawing.Point(213, 54);
            this.dgvEdit.Name = "dgvEdit";
            this.dgvEdit.RowHeadersVisible = false;
            this.dgvEdit.RowHeadersWidth = 62;
            this.dgvEdit.Size = new System.Drawing.Size(436, 113);
            this.dgvEdit.TabIndex = 40;
            this.dgvEdit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEdit_CellClick);
            // 
            // btnEditEmploy
            // 
            this.btnEditEmploy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEmploy.Location = new System.Drawing.Point(699, 344);
            this.btnEditEmploy.Name = "btnEditEmploy";
            this.btnEditEmploy.Size = new System.Drawing.Size(109, 37);
            this.btnEditEmploy.TabIndex = 39;
            this.btnEditEmploy.Text = "EDIT";
            this.btnEditEmploy.UseVisualStyleBackColor = true;
            this.btnEditEmploy.Click += new System.EventHandler(this.BtnEditEmploy_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(284, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(143, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(442, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(109, 22);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(271, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "County";
            // 
            // txtECounty
            // 
            this.txtECounty.Location = new System.Drawing.Point(274, 312);
            this.txtECounty.Name = "txtECounty";
            this.txtECounty.Size = new System.Drawing.Size(150, 20);
            this.txtECounty.TabIndex = 8;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label18.ForeColor = System.Drawing.SystemColors.Control;
            this.label18.Location = new System.Drawing.Point(496, 291);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 17);
            this.label18.TabIndex = 33;
            this.label18.Text = "Password";
            // 
            // txtEPassword
            // 
            this.txtEPassword.Enabled = false;
            this.txtEPassword.Location = new System.Drawing.Point(499, 312);
            this.txtEPassword.Name = "txtEPassword";
            this.txtEPassword.Size = new System.Drawing.Size(150, 20);
            this.txtEPassword.TabIndex = 13;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label22.ForeColor = System.Drawing.Color.Transparent;
            this.label22.Location = new System.Drawing.Point(496, 242);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(37, 17);
            this.label22.TabIndex = 6;
            this.label22.Text = "Role";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(271, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 17);
            this.label10.TabIndex = 33;
            this.label10.Text = "Street address ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label17.ForeColor = System.Drawing.SystemColors.Control;
            this.label17.Location = new System.Drawing.Point(496, 340);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 17);
            this.label17.TabIndex = 31;
            this.label17.Text = "Date Joined";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label21.ForeColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(496, 193);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(82, 17);
            this.label21.TabIndex = 5;
            this.label21.Text = "Department";
            // 
            // txtEStreet
            // 
            this.txtEStreet.Location = new System.Drawing.Point(273, 214);
            this.txtEStreet.Name = "txtEStreet";
            this.txtEStreet.Size = new System.Drawing.Size(150, 20);
            this.txtEStreet.TabIndex = 6;
            // 
            // txtEDateJoined
            // 
            this.txtEDateJoined.Enabled = false;
            this.txtEDateJoined.Location = new System.Drawing.Point(499, 361);
            this.txtEDateJoined.Name = "txtEDateJoined";
            this.txtEDateJoined.Size = new System.Drawing.Size(150, 20);
            this.txtEDateJoined.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(271, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 17);
            this.label11.TabIndex = 31;
            this.label11.Text = "City / Town";
            // 
            // txtECity
            // 
            this.txtECity.Location = new System.Drawing.Point(274, 263);
            this.txtECity.Name = "txtECity";
            this.txtECity.Size = new System.Drawing.Size(150, 20);
            this.txtECity.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(271, 340);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 17);
            this.label12.TabIndex = 29;
            this.label12.Text = "Postcode";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(45, 340);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 17);
            this.label13.TabIndex = 28;
            this.label13.Text = "Email Address";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(45, 291);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 17);
            this.label14.TabIndex = 27;
            this.label14.Text = "Telephone number";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(45, 242);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 17);
            this.label15.TabIndex = 26;
            this.label15.Text = "Last name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(45, 193);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 17);
            this.label16.TabIndex = 25;
            this.label16.Text = "First name ";
            // 
            // txtEEmail
            // 
            this.txtEEmail.Location = new System.Drawing.Point(48, 361);
            this.txtEEmail.Name = "txtEEmail";
            this.txtEEmail.Size = new System.Drawing.Size(150, 20);
            this.txtEEmail.TabIndex = 5;
            // 
            // txtELast
            // 
            this.txtELast.Location = new System.Drawing.Point(48, 263);
            this.txtELast.Name = "txtELast";
            this.txtELast.Size = new System.Drawing.Size(150, 20);
            this.txtELast.TabIndex = 3;
            // 
            // txtEPost
            // 
            this.txtEPost.Location = new System.Drawing.Point(273, 361);
            this.txtEPost.Name = "txtEPost";
            this.txtEPost.Size = new System.Drawing.Size(150, 20);
            this.txtEPost.TabIndex = 9;
            // 
            // txtEFirst
            // 
            this.txtEFirst.Location = new System.Drawing.Point(48, 214);
            this.txtEFirst.Name = "txtEFirst";
            this.txtEFirst.Size = new System.Drawing.Size(150, 20);
            this.txtEFirst.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.manageEmployeesToolStripMenuItem,
            this.holidaysToolStripMenuItem,
            this.companySettingsToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(851, 37);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(60, 33);
            this.hOMEToolStripMenuItem.Text = "HOME";
            this.hOMEToolStripMenuItem.Click += new System.EventHandler(this.HOMEToolStripMenuItem_Click);
            // 
            // manageEmployeesToolStripMenuItem
            // 
            this.manageEmployeesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.eDITToolStripMenuItem,
            this.dELETEToolStripMenuItem});
            this.manageEmployeesToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.manageEmployeesToolStripMenuItem.Name = "manageEmployeesToolStripMenuItem";
            this.manageEmployeesToolStripMenuItem.Size = new System.Drawing.Size(163, 33);
            this.manageEmployeesToolStripMenuItem.Text = "MANAGE EMPLOYEES";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.addEmployeeToolStripMenuItem.Text = "ADD";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.AddEmployeeToolStripMenuItem_Click);
            // 
            // eDITToolStripMenuItem
            // 
            this.eDITToolStripMenuItem.Name = "eDITToolStripMenuItem";
            this.eDITToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.eDITToolStripMenuItem.Text = "EDIT";
            this.eDITToolStripMenuItem.Click += new System.EventHandler(this.EDITToolStripMenuItem_Click);
            // 
            // dELETEToolStripMenuItem
            // 
            this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
            this.dELETEToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.dELETEToolStripMenuItem.Text = "DELETE";
            this.dELETEToolStripMenuItem.Click += new System.EventHandler(this.DELETEToolStripMenuItem_Click);
            // 
            // holidaysToolStripMenuItem
            // 
            this.holidaysToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEQUESTEDToolStripMenuItem,
            this.tAKENToolStripMenuItem});
            this.holidaysToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.holidaysToolStripMenuItem.Name = "holidaysToolStripMenuItem";
            this.holidaysToolStripMenuItem.Size = new System.Drawing.Size(87, 33);
            this.holidaysToolStripMenuItem.Text = "HOLIDAYS";
            // 
            // rEQUESTEDToolStripMenuItem
            // 
            this.rEQUESTEDToolStripMenuItem.Name = "rEQUESTEDToolStripMenuItem";
            this.rEQUESTEDToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.rEQUESTEDToolStripMenuItem.Text = "REQUESTED";
            this.rEQUESTEDToolStripMenuItem.Click += new System.EventHandler(this.REQUESTEDToolStripMenuItem_Click);
            // 
            // tAKENToolStripMenuItem
            // 
            this.tAKENToolStripMenuItem.Name = "tAKENToolStripMenuItem";
            this.tAKENToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.tAKENToolStripMenuItem.Text = "TAKEN";
            this.tAKENToolStripMenuItem.Click += new System.EventHandler(this.TAKENToolStripMenuItem_Click);
            // 
            // companySettingsToolStripMenuItem
            // 
            this.companySettingsToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.companySettingsToolStripMenuItem.Name = "companySettingsToolStripMenuItem";
            this.companySettingsToolStripMenuItem.Size = new System.Drawing.Size(149, 33);
            this.companySettingsToolStripMenuItem.Text = "COMPANY POLICIES";
            this.companySettingsToolStripMenuItem.Click += new System.EventHandler(this.CompanySettingsToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.logOutToolStripMenuItem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(79, 33);
            this.logOutToolStripMenuItem.Text = "LOG OUT";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click);
            // 
            // pnlMenuStripe
            // 
            this.pnlMenuStripe.Controls.Add(this.menuStrip1);
            this.pnlMenuStripe.Location = new System.Drawing.Point(0, 1);
            this.pnlMenuStripe.Name = "pnlMenuStripe";
            this.pnlMenuStripe.Size = new System.Drawing.Size(851, 37);
            this.pnlMenuStripe.TabIndex = 7;
            // 
            // pnlTaken
            // 
            this.pnlTaken.Controls.Add(this.btnTAK_alltaken);
            this.pnlTaken.Controls.Add(this.cmbxTaken_search);
            this.pnlTaken.Controls.Add(this.dgvTaken);
            this.pnlTaken.Location = new System.Drawing.Point(803, 215);
            this.pnlTaken.Name = "pnlTaken";
            this.pnlTaken.Size = new System.Drawing.Size(36, 43);
            this.pnlTaken.TabIndex = 4;
            // 
            // btnTAK_alltaken
            // 
            this.btnTAK_alltaken.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTAK_alltaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTAK_alltaken.Location = new System.Drawing.Point(333, 375);
            this.btnTAK_alltaken.Name = "btnTAK_alltaken";
            this.btnTAK_alltaken.Size = new System.Drawing.Size(185, 37);
            this.btnTAK_alltaken.TabIndex = 41;
            this.btnTAK_alltaken.Text = "ALL HOLIDAY BOOKINGS";
            this.btnTAK_alltaken.UseVisualStyleBackColor = false;
            this.btnTAK_alltaken.Click += new System.EventHandler(this.BtnTAK_alltaken_Click);
            // 
            // cmbxTaken_search
            // 
            this.cmbxTaken_search.FormattingEnabled = true;
            this.cmbxTaken_search.Location = new System.Drawing.Point(350, 13);
            this.cmbxTaken_search.Name = "cmbxTaken_search";
            this.cmbxTaken_search.Size = new System.Drawing.Size(150, 21);
            this.cmbxTaken_search.TabIndex = 11;
            this.cmbxTaken_search.SelectedIndexChanged += new System.EventHandler(this.CmbxTaken_search_SelectedIndexChanged);
            // 
            // dgvTaken
            // 
            this.dgvTaken.AllowUserToAddRows = false;
            this.dgvTaken.AllowUserToDeleteRows = false;
            this.dgvTaken.AllowUserToResizeColumns = false;
            this.dgvTaken.AllowUserToResizeRows = false;
            this.dgvTaken.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvTaken.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTaken.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaken.Location = new System.Drawing.Point(108, 54);
            this.dgvTaken.Name = "dgvTaken";
            this.dgvTaken.RowHeadersVisible = false;
            this.dgvTaken.RowHeadersWidth = 62;
            this.dgvTaken.Size = new System.Drawing.Size(635, 302);
            this.dgvTaken.TabIndex = 40;
            // 
            // pnlRequested
            // 
            this.pnlRequested.Controls.Add(this.btnReq_Reject);
            this.pnlRequested.Controls.Add(this.dgvRequested);
            this.pnlRequested.Controls.Add(this.btnReq_Approve);
            this.pnlRequested.Controls.Add(this.cbConstraints);
            this.pnlRequested.Controls.Add(this.label44);
            this.pnlRequested.Location = new System.Drawing.Point(803, 52);
            this.pnlRequested.Name = "pnlRequested";
            this.pnlRequested.Size = new System.Drawing.Size(35, 42);
            this.pnlRequested.TabIndex = 4;
            // 
            // btnReq_Reject
            // 
            this.btnReq_Reject.BackColor = System.Drawing.Color.IndianRed;
            this.btnReq_Reject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReq_Reject.Location = new System.Drawing.Point(438, 335);
            this.btnReq_Reject.Name = "btnReq_Reject";
            this.btnReq_Reject.Size = new System.Drawing.Size(109, 37);
            this.btnReq_Reject.TabIndex = 15;
            this.btnReq_Reject.Text = "REJECT";
            this.btnReq_Reject.UseVisualStyleBackColor = false;
            this.btnReq_Reject.Click += new System.EventHandler(this.BtnReq_Reject_Click);
            // 
            // dgvRequested
            // 
            this.dgvRequested.AllowUserToAddRows = false;
            this.dgvRequested.AllowUserToDeleteRows = false;
            this.dgvRequested.AllowUserToResizeColumns = false;
            this.dgvRequested.AllowUserToResizeRows = false;
            this.dgvRequested.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvRequested.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRequested.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequested.Location = new System.Drawing.Point(125, 21);
            this.dgvRequested.Name = "dgvRequested";
            this.dgvRequested.RowHeadersVisible = false;
            this.dgvRequested.RowHeadersWidth = 62;
            this.dgvRequested.Size = new System.Drawing.Size(601, 259);
            this.dgvRequested.TabIndex = 40;
            this.dgvRequested.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvRequested_CellClick);
            // 
            // btnReq_Approve
            // 
            this.btnReq_Approve.BackColor = System.Drawing.Color.SeaGreen;
            this.btnReq_Approve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReq_Approve.Location = new System.Drawing.Point(302, 335);
            this.btnReq_Approve.Name = "btnReq_Approve";
            this.btnReq_Approve.Size = new System.Drawing.Size(109, 37);
            this.btnReq_Approve.TabIndex = 39;
            this.btnReq_Approve.Text = "APPROVE";
            this.btnReq_Approve.UseVisualStyleBackColor = false;
            this.btnReq_Approve.Click += new System.EventHandler(this.BtnReq_Approve_Click);
            // 
            // cbConstraints
            // 
            this.cbConstraints.AutoSize = true;
            this.cbConstraints.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbConstraints.ForeColor = System.Drawing.Color.White;
            this.cbConstraints.Location = new System.Drawing.Point(317, 299);
            this.cbConstraints.Name = "cbConstraints";
            this.cbConstraints.Size = new System.Drawing.Size(216, 21);
            this.cbConstraints.TabIndex = 10;
            this.cbConstraints.Text = "Holidays Breaking Constraints";
            this.cbConstraints.UseVisualStyleBackColor = true;
            this.cbConstraints.Click += new System.EventHandler(this.CbConstraints_Click);
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.PeachPuff;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.ForeColor = System.Drawing.Color.Black;
            this.label44.Location = new System.Drawing.Point(354, 390);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(142, 17);
            this.label44.TabIndex = 44;
            this.label44.Text = "Within Peak Times";
            // 
            // pnlHome
            // 
            this.pnlHome.Controls.Add(this.onLeaveCalendarComponent1);
            this.pnlHome.Controls.Add(this.label28);
            this.pnlHome.Controls.Add(this.label27);
            this.pnlHome.Controls.Add(this.lbNamePlaceHolder);
            this.pnlHome.Controls.Add(this.label24);
            this.pnlHome.Controls.Add(this.dgvHome_leave);
            this.pnlHome.Controls.Add(this.dgvHome_working);
            this.pnlHome.Controls.Add(this.mcDate);
            this.pnlHome.Location = new System.Drawing.Point(803, 333);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(32, 50);
            this.pnlHome.TabIndex = 4;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.Color.Transparent;
            this.label28.Location = new System.Drawing.Point(520, 10);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(194, 25);
            this.label28.TabIndex = 44;
            this.label28.Text = "Will Be On Leave";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Transparent;
            this.label27.Location = new System.Drawing.Point(264, 10);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(179, 25);
            this.label27.TabIndex = 44;
            this.label27.Text = "Will Be Working";
            // 
            // lbNamePlaceHolder
            // 
            this.lbNamePlaceHolder.AutoSize = true;
            this.lbNamePlaceHolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNamePlaceHolder.ForeColor = System.Drawing.Color.Transparent;
            this.lbNamePlaceHolder.Location = new System.Drawing.Point(20, 226);
            this.lbNamePlaceHolder.Name = "lbNamePlaceHolder";
            this.lbNamePlaceHolder.Size = new System.Drawing.Size(0, 25);
            this.lbNamePlaceHolder.TabIndex = 44;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Transparent;
            this.label24.Location = new System.Drawing.Point(20, 10);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(134, 25);
            this.label24.TabIndex = 44;
            this.label24.Text = "Select Date";
            // 
            // dgvHome_leave
            // 
            this.dgvHome_leave.AllowUserToAddRows = false;
            this.dgvHome_leave.AllowUserToDeleteRows = false;
            this.dgvHome_leave.AllowUserToResizeColumns = false;
            this.dgvHome_leave.AllowUserToResizeRows = false;
            this.dgvHome_leave.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvHome_leave.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvHome_leave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHome_leave.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHome_leave.Location = new System.Drawing.Point(525, 47);
            this.dgvHome_leave.Name = "dgvHome_leave";
            this.dgvHome_leave.RowHeadersVisible = false;
            this.dgvHome_leave.RowHeadersWidth = 40;
            this.dgvHome_leave.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvHome_leave.Size = new System.Drawing.Size(303, 277);
            this.dgvHome_leave.TabIndex = 43;
            this.dgvHome_leave.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHome_leave_CellClick);
            // 
            // dgvHome_working
            // 
            this.dgvHome_working.AllowUserToAddRows = false;
            this.dgvHome_working.AllowUserToDeleteRows = false;
            this.dgvHome_working.AllowUserToResizeColumns = false;
            this.dgvHome_working.AllowUserToResizeRows = false;
            this.dgvHome_working.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvHome_working.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dgvHome_working.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHome_working.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHome_working.Location = new System.Drawing.Point(269, 47);
            this.dgvHome_working.Name = "dgvHome_working";
            this.dgvHome_working.RowHeadersVisible = false;
            this.dgvHome_working.RowHeadersWidth = 40;
            this.dgvHome_working.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvHome_working.Size = new System.Drawing.Size(218, 277);
            this.dgvHome_working.TabIndex = 43;
            // 
            // mcDate
            // 
            this.mcDate.Location = new System.Drawing.Point(20, 47);
            this.mcDate.MaxSelectionCount = 1;
            this.mcDate.Name = "mcDate";
            this.mcDate.TabIndex = 42;
            this.mcDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.McDate_DateSelected);
            // 
            // pnlCompanyPolicies
            // 
            this.pnlCompanyPolicies.Controls.Add(this.numOnDutyRelaxed);
            this.pnlCompanyPolicies.Controls.Add(this.numEntitlement);
            this.pnlCompanyPolicies.Controls.Add(this.numOnDuty);
            this.pnlCompanyPolicies.Controls.Add(this.btnSaveSettings);
            this.pnlCompanyPolicies.Controls.Add(this.dtpEasterEnd);
            this.pnlCompanyPolicies.Controls.Add(this.dtpChristmasEnd);
            this.pnlCompanyPolicies.Controls.Add(this.dtpSummerEnd);
            this.pnlCompanyPolicies.Controls.Add(this.dtpEasterStart);
            this.pnlCompanyPolicies.Controls.Add(this.dtpChristmasStart);
            this.pnlCompanyPolicies.Controls.Add(this.dtpSummerStart);
            this.pnlCompanyPolicies.Controls.Add(this.cbManagerOrSenior);
            this.pnlCompanyPolicies.Controls.Add(this.cbHeadOrDeputy);
            this.pnlCompanyPolicies.Controls.Add(this.cbRelaxedMonth);
            this.pnlCompanyPolicies.Controls.Add(this.label29);
            this.pnlCompanyPolicies.Controls.Add(this.label41);
            this.pnlCompanyPolicies.Controls.Add(this.label39);
            this.pnlCompanyPolicies.Controls.Add(this.label42);
            this.pnlCompanyPolicies.Controls.Add(this.label32);
            this.pnlCompanyPolicies.Controls.Add(this.label31);
            this.pnlCompanyPolicies.Controls.Add(this.label35);
            this.pnlCompanyPolicies.Controls.Add(this.label34);
            this.pnlCompanyPolicies.Controls.Add(this.label37);
            this.pnlCompanyPolicies.Controls.Add(this.label43);
            this.pnlCompanyPolicies.Controls.Add(this.label36);
            this.pnlCompanyPolicies.Controls.Add(this.label33);
            this.pnlCompanyPolicies.Controls.Add(this.label30);
            this.pnlCompanyPolicies.Controls.Add(this.label38);
            this.pnlCompanyPolicies.Controls.Add(this.label40);
            this.pnlCompanyPolicies.Location = new System.Drawing.Point(803, 154);
            this.pnlCompanyPolicies.Name = "pnlCompanyPolicies";
            this.pnlCompanyPolicies.Size = new System.Drawing.Size(30, 35);
            this.pnlCompanyPolicies.TabIndex = 4;
            // 
            // numOnDutyRelaxed
            // 
            this.numOnDutyRelaxed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numOnDutyRelaxed.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numOnDutyRelaxed.Location = new System.Drawing.Point(689, 153);
            this.numOnDutyRelaxed.Name = "numOnDutyRelaxed";
            this.numOnDutyRelaxed.Size = new System.Drawing.Size(46, 23);
            this.numOnDutyRelaxed.TabIndex = 44;
            this.numOnDutyRelaxed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numEntitlement
            // 
            this.numEntitlement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numEntitlement.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numEntitlement.Location = new System.Drawing.Point(202, 56);
            this.numEntitlement.Name = "numEntitlement";
            this.numEntitlement.Size = new System.Drawing.Size(46, 23);
            this.numEntitlement.TabIndex = 44;
            this.numEntitlement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numOnDuty
            // 
            this.numOnDuty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numOnDuty.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numOnDuty.Location = new System.Drawing.Point(689, 55);
            this.numOnDuty.Name = "numOnDuty";
            this.numOnDuty.Size = new System.Drawing.Size(46, 23);
            this.numOnDuty.TabIndex = 44;
            this.numOnDuty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSettings.Location = new System.Drawing.Point(360, 390);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(130, 37);
            this.btnSaveSettings.TabIndex = 40;
            this.btnSaveSettings.Text = "SAVE CHANGES";
            this.btnSaveSettings.UseVisualStyleBackColor = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.BtnSaveSettings_Click);
            // 
            // dtpEasterEnd
            // 
            this.dtpEasterEnd.Location = new System.Drawing.Point(535, 334);
            this.dtpEasterEnd.Name = "dtpEasterEnd";
            this.dtpEasterEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEasterEnd.TabIndex = 43;
            // 
            // dtpChristmasEnd
            // 
            this.dtpChristmasEnd.Location = new System.Drawing.Point(535, 294);
            this.dtpChristmasEnd.Name = "dtpChristmasEnd";
            this.dtpChristmasEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpChristmasEnd.TabIndex = 43;
            // 
            // dtpSummerEnd
            // 
            this.dtpSummerEnd.Location = new System.Drawing.Point(535, 254);
            this.dtpSummerEnd.Name = "dtpSummerEnd";
            this.dtpSummerEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpSummerEnd.TabIndex = 43;
            // 
            // dtpEasterStart
            // 
            this.dtpEasterStart.Location = new System.Drawing.Point(224, 334);
            this.dtpEasterStart.Name = "dtpEasterStart";
            this.dtpEasterStart.Size = new System.Drawing.Size(200, 20);
            this.dtpEasterStart.TabIndex = 43;
            // 
            // dtpChristmasStart
            // 
            this.dtpChristmasStart.Location = new System.Drawing.Point(224, 294);
            this.dtpChristmasStart.Name = "dtpChristmasStart";
            this.dtpChristmasStart.Size = new System.Drawing.Size(200, 20);
            this.dtpChristmasStart.TabIndex = 43;
            // 
            // dtpSummerStart
            // 
            this.dtpSummerStart.Location = new System.Drawing.Point(224, 254);
            this.dtpSummerStart.Name = "dtpSummerStart";
            this.dtpSummerStart.Size = new System.Drawing.Size(200, 20);
            this.dtpSummerStart.TabIndex = 43;
            // 
            // cbManagerOrSenior
            // 
            this.cbManagerOrSenior.AutoSize = true;
            this.cbManagerOrSenior.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbManagerOrSenior.ForeColor = System.Drawing.Color.White;
            this.cbManagerOrSenior.Location = new System.Drawing.Point(64, 158);
            this.cbManagerOrSenior.Name = "cbManagerOrSenior";
            this.cbManagerOrSenior.Size = new System.Drawing.Size(277, 21);
            this.cbManagerOrSenior.TabIndex = 10;
            this.cbManagerOrSenior.Text = "Manager or Senior Staff always on Duty";
            this.cbManagerOrSenior.UseVisualStyleBackColor = true;
            this.cbManagerOrSenior.CheckedChanged += new System.EventHandler(this.ChbxDetails_CheckedChanged);
            // 
            // cbHeadOrDeputy
            // 
            this.cbHeadOrDeputy.AutoSize = true;
            this.cbHeadOrDeputy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbHeadOrDeputy.ForeColor = System.Drawing.Color.White;
            this.cbHeadOrDeputy.Location = new System.Drawing.Point(64, 106);
            this.cbHeadOrDeputy.Name = "cbHeadOrDeputy";
            this.cbHeadOrDeputy.Size = new System.Drawing.Size(226, 21);
            this.cbHeadOrDeputy.TabIndex = 10;
            this.cbHeadOrDeputy.Text = "Head or Deputy always on Duty";
            this.cbHeadOrDeputy.UseVisualStyleBackColor = true;
            this.cbHeadOrDeputy.CheckedChanged += new System.EventHandler(this.ChbxDetails_CheckedChanged);
            // 
            // cbRelaxedMonth
            // 
            this.cbRelaxedMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRelaxedMonth.FormattingEnabled = true;
            this.cbRelaxedMonth.Location = new System.Drawing.Point(584, 105);
            this.cbRelaxedMonth.Name = "cbRelaxedMonth";
            this.cbRelaxedMonth.Size = new System.Drawing.Size(151, 21);
            this.cbRelaxedMonth.TabIndex = 11;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.Color.Transparent;
            this.label29.Location = new System.Drawing.Point(59, 211);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(135, 25);
            this.label29.TabIndex = 5;
            this.label29.Text = "Peak Times";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.ForeColor = System.Drawing.Color.Transparent;
            this.label41.Location = new System.Drawing.Point(59, 18);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(218, 25);
            this.label41.TabIndex = 5;
            this.label41.Text = "Holiday Constraints";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label39.ForeColor = System.Drawing.SystemColors.Control;
            this.label39.Location = new System.Drawing.Point(419, 107);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(110, 17);
            this.label39.TabIndex = 25;
            this.label39.Text = "Relaxed Month :";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label42.ForeColor = System.Drawing.SystemColors.Control;
            this.label42.Location = new System.Drawing.Point(419, 156);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(260, 17);
            this.label42.TabIndex = 25;
            this.label42.Text = "Department needed on Duty (Relaxed) :";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label32.ForeColor = System.Drawing.SystemColors.Control;
            this.label32.Location = new System.Drawing.Point(59, 336);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(115, 17);
            this.label32.TabIndex = 25;
            this.label32.Text = "Easter Holidays :";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label31.ForeColor = System.Drawing.SystemColors.Control;
            this.label31.Location = new System.Drawing.Point(59, 296);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(136, 17);
            this.label31.TabIndex = 25;
            this.label31.Text = "Christmas Holidays :";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label35.ForeColor = System.Drawing.SystemColors.Control;
            this.label35.Location = new System.Drawing.Point(465, 336);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(28, 17);
            this.label35.TabIndex = 25;
            this.label35.Text = "TO";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label34.ForeColor = System.Drawing.SystemColors.Control;
            this.label34.Location = new System.Drawing.Point(465, 296);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(28, 17);
            this.label34.TabIndex = 25;
            this.label34.Text = "TO";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label37.ForeColor = System.Drawing.SystemColors.Control;
            this.label37.Location = new System.Drawing.Point(735, 156);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(20, 17);
            this.label37.TabIndex = 25;
            this.label37.Text = "%";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label43.ForeColor = System.Drawing.SystemColors.Control;
            this.label43.Location = new System.Drawing.Point(254, 58);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(40, 17);
            this.label43.TabIndex = 25;
            this.label43.Text = "Days";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label36.ForeColor = System.Drawing.SystemColors.Control;
            this.label36.Location = new System.Drawing.Point(735, 58);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(20, 17);
            this.label36.TabIndex = 25;
            this.label36.Text = "%";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label33.ForeColor = System.Drawing.SystemColors.Control;
            this.label33.Location = new System.Drawing.Point(465, 256);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(28, 17);
            this.label33.TabIndex = 25;
            this.label33.Text = "TO";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label30.ForeColor = System.Drawing.SystemColors.Control;
            this.label30.Location = new System.Drawing.Point(59, 256);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(126, 17);
            this.label30.TabIndex = 25;
            this.label30.Text = "Summer Holidays :";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label38.ForeColor = System.Drawing.SystemColors.Control;
            this.label38.Location = new System.Drawing.Point(61, 58);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(137, 17);
            this.label38.TabIndex = 25;
            this.label38.Text = "Holiday Entitlement :";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label40.ForeColor = System.Drawing.SystemColors.Control;
            this.label40.Location = new System.Drawing.Point(419, 58);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(195, 17);
            this.label40.TabIndex = 25;
            this.label40.Text = "Department needed on Duty :";
            // 
            // txtComPhoneNumber
            // 
            this.txtComPhoneNumber.Location = new System.Drawing.Point(50, 241);
            this.txtComPhoneNumber.Name = "txtComPhoneNumber";
            this.txtComPhoneNumber.Size = new System.Drawing.Size(150, 20);
            this.txtComPhoneNumber.TabIndex = 20;
            // 
            // onLeaveCalendarComponent1
            // 
            this.onLeaveCalendarComponent1.Enabled = false;
            this.onLeaveCalendarComponent1.Location = new System.Drawing.Point(20, 258);
            this.onLeaveCalendarComponent1.MaxSelectionCount = 30;
            this.onLeaveCalendarComponent1.Name = "onLeaveCalendarComponent1";
            this.onLeaveCalendarComponent1.ShowToday = false;
            this.onLeaveCalendarComponent1.ShowTodayCircle = false;
            this.onLeaveCalendarComponent1.TabIndex = 45;
            // 
            // txtEComPhoneNumber
            // 
            this.txtEComPhoneNumber.ForeColor = System.Drawing.Color.Red;
            this.txtEComPhoneNumber.Location = new System.Drawing.Point(48, 312);
            this.txtEComPhoneNumber.Name = "txtEComPhoneNumber";
            this.txtEComPhoneNumber.Size = new System.Drawing.Size(150, 20);
            this.txtEComPhoneNumber.TabIndex = 42;
            // 
            // constraintChecker1
            // 
            this.constraintChecker1.DeptType = new string[] {
        "Engineering",
        "Plumbing",
        "Roofing",
        "Carpentry",
        "Bricklaying",
        "Office"};
            this.constraintChecker1.ExceptionDates = ((System.Collections.Generic.List<System.DateTime>)(resources.GetObject("constraintChecker1.ExceptionDates")));
            this.constraintChecker1.HeadOrDeputy = true;
            this.constraintChecker1.ManagerOrSenior = true;
            this.constraintChecker1.MonthNames = ((System.Collections.Generic.List<string>)(resources.GetObject("constraintChecker1.MonthNames")));
            this.constraintChecker1.MustBeOnDuty = 60;
            this.constraintChecker1.MustBeOnDutyRelaxed = 40;
            this.constraintChecker1.PeakTimeChristmas = ((System.Collections.Generic.List<System.DateTime>)(resources.GetObject("constraintChecker1.PeakTimeChristmas")));
            this.constraintChecker1.PeakTimeEaster = ((System.Collections.Generic.List<System.DateTime>)(resources.GetObject("constraintChecker1.PeakTimeEaster")));
            this.constraintChecker1.PeakTimeSummer = ((System.Collections.Generic.List<System.DateTime>)(resources.GetObject("constraintChecker1.PeakTimeSummer")));
            this.constraintChecker1.RelaxedMonth = "August";
            this.constraintChecker1.RoleType = new string[] {
        "Head",
        "Deputy Head",
        "Manager",
        "Apprentice",
        "Junior Member",
        "Senior Member"};
            this.constraintChecker1.StaffsEntitledDays = 30;
            // 
            // ManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(851, 480);
            this.Controls.Add(this.pnlMenuStripe);
            this.Controls.Add(this.pnlCreate);
            this.Controls.Add(this.pnlRequested);
            this.Controls.Add(this.pnlHome);
            this.Controls.Add(this.pnlTaken);
            this.Controls.Add(this.pnlCompanyPolicies);
            this.Controls.Add(this.pnlEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageForm";
            this.pnlCreate.ResumeLayout(false);
            this.pnlCreate.PerformLayout();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEdit)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlMenuStripe.ResumeLayout(false);
            this.pnlMenuStripe.PerformLayout();
            this.pnlTaken.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaken)).EndInit();
            this.pnlRequested.ResumeLayout(false);
            this.pnlRequested.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequested)).EndInit();
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHome_leave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHome_working)).EndInit();
            this.pnlCompanyPolicies.ResumeLayout(false);
            this.pnlCompanyPolicies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOnDutyRelaxed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEntitlement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOnDuty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCreate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.Button btnCreateEmploy;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Button btnEditEmploy;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtECounty;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEStreet;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtECity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtEEmail;
        private System.Windows.Forms.TextBox txtELast;
        private System.Windows.Forms.TextBox txtEPost;
        private System.Windows.Forms.TextBox txtEFirst;
        private System.Windows.Forms.Button btnDeleteEmploy;
        private Component_A_ClassLibrary.CreateEmployee createEmployee1;
        private System.Windows.Forms.ComboBox cbxRole;
        private System.Windows.Forms.ComboBox cbxDept;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DataGridView dgvEdit;
        private Component_A_ClassLibrary.EditEmployee editEmployee1;
        private Component_A_ClassLibrary.DeleteEmployee deleteEmployee1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdID;
        private System.Windows.Forms.RadioButton rdName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtEPassword;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtEDateJoined;
        private System.Windows.Forms.CheckBox chbxDetails;
        private System.Windows.Forms.ComboBox cbxERole;
        private System.Windows.Forms.ComboBox cbxEDept;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem holidaysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companySettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eDITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tAKENToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEQUESTEDToolStripMenuItem;
        private System.Windows.Forms.Panel pnlMenuStripe;
        private System.Windows.Forms.Panel pnlTaken;
        private System.Windows.Forms.ComboBox cmbxTaken_search;
        private System.Windows.Forms.DataGridView dgvTaken;
        private System.Windows.Forms.Panel pnlRequested;
        private System.Windows.Forms.Button btnReq_Reject;
        private System.Windows.Forms.DataGridView dgvRequested;
        private System.Windows.Forms.Button btnReq_Approve;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.Button btnTAK_alltaken;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.DataGridView dgvHome_leave;
        private System.Windows.Forms.DataGridView dgvHome_working;
        private System.Windows.Forms.MonthCalendar mcDate;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label24;
        private Component_B_ClassLibrary.Functionality_B.PhoneNumberTextBox txtComPhoneNumber;
        private Component_B_ClassLibrary.Functionality_B.PhoneNumberTextBox txtEComPhoneNumber;
        private System.Windows.Forms.Panel pnlCompanyPolicies;
        private System.Windows.Forms.CheckBox cbManagerOrSenior;
        private System.Windows.Forms.CheckBox cbHeadOrDeputy;
        private System.Windows.Forms.ComboBox cbRelaxedMonth;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Button btnSaveSettings;
        private System.Windows.Forms.DateTimePicker dtpEasterEnd;
        private System.Windows.Forms.DateTimePicker dtpChristmasEnd;
        private System.Windows.Forms.DateTimePicker dtpSummerEnd;
        private System.Windows.Forms.DateTimePicker dtpEasterStart;
        private System.Windows.Forms.DateTimePicker dtpChristmasStart;
        private System.Windows.Forms.DateTimePicker dtpSummerStart;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.NumericUpDown numOnDutyRelaxed;
        private System.Windows.Forms.NumericUpDown numOnDuty;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.NumericUpDown numEntitlement;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label43;
        private Component_B_ClassLibrary.Functionality_C.ConstraintChecker constraintChecker1;
        private System.Windows.Forms.CheckBox cbConstraints;
        private Component_B_ClassLibrary.Functionality_F.OnLeaveCalendarComponent onLeaveCalendarComponent1;
        private System.Windows.Forms.Label lbNamePlaceHolder;
        private System.Windows.Forms.Label label44;
    }
}