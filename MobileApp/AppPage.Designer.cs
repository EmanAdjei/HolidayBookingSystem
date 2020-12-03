namespace MobileApp
{
    partial class AppPage
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
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtstaffID = new System.Windows.Forms.TextBox();
            this.btnNavHome = new System.Windows.Forms.Button();
            this.btnNavRequest = new System.Windows.Forms.Button();
            this.btnNavAll = new System.Windows.Forms.Button();
            this.pnlHome = new System.Windows.Forms.Panel();
            this.lbDepartment = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbRole = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbDateJoined = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbStaffID = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pnlRequest = new System.Windows.Forms.Panel();
            this.pnlAll = new System.Windows.Forms.Panel();
            this.pnlNavigation = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSubmitRequest = new System.Windows.Forms.Button();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvAllRequests = new System.Windows.Forms.DataGridView();
            this.pnlLogin.SuspendLayout();
            this.pnlHome.SuspendLayout();
            this.pnlRequest.SuspendLayout();
            this.pnlAll.SuspendLayout();
            this.pnlNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRequests)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Controls.Add(this.label4);
            this.pnlLogin.Controls.Add(this.Title);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.txtpassword);
            this.pnlLogin.Controls.Add(this.txtstaffID);
            this.pnlLogin.Location = new System.Drawing.Point(320, 26);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(64, 66);
            this.pnlLogin.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(73, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Password : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Staff ID : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(292, 31);
            this.label4.TabIndex = 15;
            this.label4.Text = "|| Straight Walls Ltd ||";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(97, 186);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(110, 36);
            this.Title.TabIndex = 16;
            this.Title.Text = "Login";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(115, 384);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(73, 329);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(159, 20);
            this.txtpassword.TabIndex = 13;
            // 
            // txtstaffID
            // 
            this.txtstaffID.Location = new System.Drawing.Point(73, 262);
            this.txtstaffID.MaxLength = 6;
            this.txtstaffID.Name = "txtstaffID";
            this.txtstaffID.ShortcutsEnabled = false;
            this.txtstaffID.Size = new System.Drawing.Size(159, 20);
            this.txtstaffID.TabIndex = 12;
            // 
            // btnNavHome
            // 
            this.btnNavHome.BackColor = System.Drawing.Color.Lavender;
            this.btnNavHome.FlatAppearance.BorderSize = 0;
            this.btnNavHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnNavHome.Location = new System.Drawing.Point(-1, 0);
            this.btnNavHome.Name = "btnNavHome";
            this.btnNavHome.Size = new System.Drawing.Size(101, 37);
            this.btnNavHome.TabIndex = 13;
            this.btnNavHome.Text = "HOME";
            this.btnNavHome.UseVisualStyleBackColor = false;
            this.btnNavHome.Click += new System.EventHandler(this.BtnNavHome_Click);
            // 
            // btnNavRequest
            // 
            this.btnNavRequest.BackColor = System.Drawing.Color.Lavender;
            this.btnNavRequest.FlatAppearance.BorderSize = 0;
            this.btnNavRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnNavRequest.Location = new System.Drawing.Point(101, 0);
            this.btnNavRequest.Name = "btnNavRequest";
            this.btnNavRequest.Size = new System.Drawing.Size(101, 37);
            this.btnNavRequest.TabIndex = 13;
            this.btnNavRequest.Text = "REQUEST";
            this.btnNavRequest.UseVisualStyleBackColor = false;
            this.btnNavRequest.Click += new System.EventHandler(this.BtnNavRequest_Click);
            // 
            // btnNavAll
            // 
            this.btnNavAll.BackColor = System.Drawing.Color.Lavender;
            this.btnNavAll.FlatAppearance.BorderSize = 0;
            this.btnNavAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnNavAll.Location = new System.Drawing.Point(203, 0);
            this.btnNavAll.Name = "btnNavAll";
            this.btnNavAll.Size = new System.Drawing.Size(101, 37);
            this.btnNavAll.TabIndex = 13;
            this.btnNavAll.Text = "ALL";
            this.btnNavAll.UseVisualStyleBackColor = false;
            this.btnNavAll.Click += new System.EventHandler(this.BtnNavAll_Click);
            // 
            // pnlHome
            // 
            this.pnlHome.Controls.Add(this.lbDepartment);
            this.pnlHome.Controls.Add(this.btnLogOut);
            this.pnlHome.Controls.Add(this.lbLastName);
            this.pnlHome.Controls.Add(this.lbRole);
            this.pnlHome.Controls.Add(this.lbFirstName);
            this.pnlHome.Controls.Add(this.lbDateJoined);
            this.pnlHome.Controls.Add(this.lbEmail);
            this.pnlHome.Controls.Add(this.lbStaffID);
            this.pnlHome.Controls.Add(this.label19);
            this.pnlHome.Location = new System.Drawing.Point(320, 21);
            this.pnlHome.Name = "pnlHome";
            this.pnlHome.Size = new System.Drawing.Size(68, 79);
            this.pnlHome.TabIndex = 14;
            // 
            // lbDepartment
            // 
            this.lbDepartment.AutoSize = true;
            this.lbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDepartment.ForeColor = System.Drawing.Color.Transparent;
            this.lbDepartment.Location = new System.Drawing.Point(43, 226);
            this.lbDepartment.Name = "lbDepartment";
            this.lbDepartment.Size = new System.Drawing.Size(38, 17);
            this.lbDepartment.TabIndex = 7;
            this.lbDepartment.Text = "Dept";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Lavender;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnLogOut.Location = new System.Drawing.Point(102, 371);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(101, 37);
            this.btnLogOut.TabIndex = 13;
            this.btnLogOut.Text = "LOG OUT";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbLastName.ForeColor = System.Drawing.Color.Transparent;
            this.lbLastName.Location = new System.Drawing.Point(43, 109);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(78, 17);
            this.lbLastName.TabIndex = 7;
            this.lbLastName.Text = "Last name ";
            // 
            // lbRole
            // 
            this.lbRole.AutoSize = true;
            this.lbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbRole.ForeColor = System.Drawing.Color.Transparent;
            this.lbRole.Location = new System.Drawing.Point(43, 265);
            this.lbRole.Name = "lbRole";
            this.lbRole.Size = new System.Drawing.Size(37, 17);
            this.lbRole.TabIndex = 7;
            this.lbRole.Text = "Role";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbFirstName.ForeColor = System.Drawing.Color.Transparent;
            this.lbFirstName.Location = new System.Drawing.Point(43, 70);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(78, 17);
            this.lbFirstName.TabIndex = 7;
            this.lbFirstName.Text = "First name ";
            // 
            // lbDateJoined
            // 
            this.lbDateJoined.AutoSize = true;
            this.lbDateJoined.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbDateJoined.ForeColor = System.Drawing.Color.Transparent;
            this.lbDateJoined.Location = new System.Drawing.Point(43, 304);
            this.lbDateJoined.Name = "lbDateJoined";
            this.lbDateJoined.Size = new System.Drawing.Size(80, 17);
            this.lbDateJoined.TabIndex = 7;
            this.lbDateJoined.Text = "DateJoined";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbEmail.ForeColor = System.Drawing.Color.Transparent;
            this.lbEmail.Location = new System.Drawing.Point(43, 187);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(42, 17);
            this.lbEmail.TabIndex = 7;
            this.lbEmail.Text = "Email";
            // 
            // lbStaffID
            // 
            this.lbStaffID.AutoSize = true;
            this.lbStaffID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbStaffID.ForeColor = System.Drawing.Color.Transparent;
            this.lbStaffID.Location = new System.Drawing.Point(43, 148);
            this.lbStaffID.Name = "lbStaffID";
            this.lbStaffID.Size = new System.Drawing.Size(19, 17);
            this.lbStaffID.TabIndex = 7;
            this.lbStaffID.Text = "Id";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(43, 17);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(219, 31);
            this.label19.TabIndex = 6;
            this.label19.Text = "Account Details";
            // 
            // pnlRequest
            // 
            this.pnlRequest.Controls.Add(this.dtpEnd);
            this.pnlRequest.Controls.Add(this.dtpStart);
            this.pnlRequest.Controls.Add(this.label6);
            this.pnlRequest.Controls.Add(this.btnSubmitRequest);
            this.pnlRequest.Controls.Add(this.label5);
            this.pnlRequest.Controls.Add(this.label3);
            this.pnlRequest.Location = new System.Drawing.Point(319, 117);
            this.pnlRequest.Name = "pnlRequest";
            this.pnlRequest.Size = new System.Drawing.Size(53, 69);
            this.pnlRequest.TabIndex = 14;
            // 
            // pnlAll
            // 
            this.pnlAll.Controls.Add(this.dgvAllRequests);
            this.pnlAll.Controls.Add(this.label7);
            this.pnlAll.Location = new System.Drawing.Point(0, 1);
            this.pnlAll.Name = "pnlAll";
            this.pnlAll.Size = new System.Drawing.Size(304, 499);
            this.pnlAll.TabIndex = 14;
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.Controls.Add(this.btnNavHome);
            this.pnlNavigation.Controls.Add(this.btnNavRequest);
            this.pnlNavigation.Controls.Add(this.btnNavAll);
            this.pnlNavigation.Location = new System.Drawing.Point(0, 496);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(304, 37);
            this.pnlNavigation.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(15, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Make Holiday Request";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(92, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 26);
            this.label5.TabIndex = 7;
            this.label5.Text = "Start Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(97, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 26);
            this.label6.TabIndex = 7;
            this.label6.Text = "End Date";
            // 
            // btnSubmitRequest
            // 
            this.btnSubmitRequest.BackColor = System.Drawing.Color.Lavender;
            this.btnSubmitRequest.FlatAppearance.BorderSize = 0;
            this.btnSubmitRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSubmitRequest.Location = new System.Drawing.Point(76, 429);
            this.btnSubmitRequest.Name = "btnSubmitRequest";
            this.btnSubmitRequest.Size = new System.Drawing.Size(153, 37);
            this.btnSubmitRequest.TabIndex = 13;
            this.btnSubmitRequest.Text = "SUBMIT REQUEST";
            this.btnSubmitRequest.UseVisualStyleBackColor = false;
            this.btnSubmitRequest.Click += new System.EventHandler(this.BtnSubmitRequest_Click);
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(61, 108);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(182, 20);
            this.dtpStart.TabIndex = 14;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(61, 286);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(182, 20);
            this.dtpEnd.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(60, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "Your Requests";
            // 
            // dgvAllRequests
            // 
            this.dgvAllRequests.AllowUserToAddRows = false;
            this.dgvAllRequests.AllowUserToDeleteRows = false;
            this.dgvAllRequests.AllowUserToResizeColumns = false;
            this.dgvAllRequests.AllowUserToResizeRows = false;
            this.dgvAllRequests.BackgroundColor = System.Drawing.Color.DarkSlateBlue;
            this.dgvAllRequests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAllRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllRequests.Location = new System.Drawing.Point(12, 52);
            this.dgvAllRequests.Name = "dgvAllRequests";
            this.dgvAllRequests.RowHeadersVisible = false;
            this.dgvAllRequests.RowHeadersWidth = 62;
            this.dgvAllRequests.Size = new System.Drawing.Size(280, 380);
            this.dgvAllRequests.TabIndex = 41;
            // 
            // AppPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(304, 533);
            this.Controls.Add(this.pnlNavigation);
            this.Controls.Add(this.pnlAll);
            this.Controls.Add(this.pnlRequest);
            this.Controls.Add(this.pnlHome);
            this.Controls.Add(this.pnlLogin);
            this.Name = "AppPage";
            this.Text = "AppPage";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlHome.ResumeLayout(false);
            this.pnlHome.PerformLayout();
            this.pnlRequest.ResumeLayout(false);
            this.pnlRequest.PerformLayout();
            this.pnlAll.ResumeLayout(false);
            this.pnlAll.PerformLayout();
            this.pnlNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllRequests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtstaffID;
        private System.Windows.Forms.Button btnNavHome;
        private System.Windows.Forms.Button btnNavRequest;
        private System.Windows.Forms.Button btnNavAll;
        private System.Windows.Forms.Panel pnlHome;
        private System.Windows.Forms.Panel pnlRequest;
        private System.Windows.Forms.Panel pnlAll;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbDepartment;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbRole;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbDateJoined;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbStaffID;
        private System.Windows.Forms.Panel pnlNavigation;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSubmitRequest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvAllRequests;
    }
}

