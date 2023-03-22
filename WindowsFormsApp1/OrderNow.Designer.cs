namespace WindowsFormsApp1
{
    partial class OrderNow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlRightOrder = new System.Windows.Forms.Panel();
            this.clstCntct = new System.Windows.Forms.CheckedListBox();
            this.groupBoxTime = new System.Windows.Forms.GroupBox();
            this.rdbBrkFst = new System.Windows.Forms.RadioButton();
            this.rdbDnr = new System.Windows.Forms.RadioButton();
            this.rdbLnch = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHm = new System.Windows.Forms.Button();
            this.btnMls = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbMbr = new System.Windows.Forms.ComboBox();
            this.cmbTblNum = new System.Windows.Forms.ComboBox();
            this.dtPkrArriving = new System.Windows.Forms.DateTimePicker();
            this.txtMbNum = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblMember = new System.Windows.Forms.Label();
            this.lblMblNum = new System.Windows.Forms.Label();
            this.lblEml = new System.Windows.Forms.Label();
            this.lblTblNum = new System.Windows.Forms.Label();
            this.lbldate = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.pnlLeftOrder = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlRightOrder.SuspendLayout();
            this.groupBoxTime.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlRightOrder);
            this.panel1.Controls.Add(this.pnlLeftOrder);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(797, 449);
            this.panel1.TabIndex = 0;
            // 
            // pnlRightOrder
            // 
            this.pnlRightOrder.BackColor = System.Drawing.SystemColors.GrayText;
            this.pnlRightOrder.Controls.Add(this.clstCntct);
            this.pnlRightOrder.Controls.Add(this.groupBoxTime);
            this.pnlRightOrder.Controls.Add(this.panel5);
            this.pnlRightOrder.Controls.Add(this.btnHm);
            this.pnlRightOrder.Controls.Add(this.btnMls);
            this.pnlRightOrder.Controls.Add(this.btnClear);
            this.pnlRightOrder.Controls.Add(this.cmbMbr);
            this.pnlRightOrder.Controls.Add(this.cmbTblNum);
            this.pnlRightOrder.Controls.Add(this.dtPkrArriving);
            this.pnlRightOrder.Controls.Add(this.txtMbNum);
            this.pnlRightOrder.Controls.Add(this.txtEmail);
            this.pnlRightOrder.Controls.Add(this.txtLName);
            this.pnlRightOrder.Controls.Add(this.txtFName);
            this.pnlRightOrder.Controls.Add(this.lblContact);
            this.pnlRightOrder.Controls.Add(this.lblMember);
            this.pnlRightOrder.Controls.Add(this.lblMblNum);
            this.pnlRightOrder.Controls.Add(this.lblEml);
            this.pnlRightOrder.Controls.Add(this.lblTblNum);
            this.pnlRightOrder.Controls.Add(this.lbldate);
            this.pnlRightOrder.Controls.Add(this.lblLname);
            this.pnlRightOrder.Controls.Add(this.lblFName);
            this.pnlRightOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlRightOrder.Location = new System.Drawing.Point(208, 3);
            this.pnlRightOrder.Name = "pnlRightOrder";
            this.pnlRightOrder.Size = new System.Drawing.Size(588, 444);
            this.pnlRightOrder.TabIndex = 1;
            // 
            // clstCntct
            // 
            this.clstCntct.BackColor = System.Drawing.Color.Gray;
            this.clstCntct.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clstCntct.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.clstCntct.FormattingEnabled = true;
            this.clstCntct.Items.AddRange(new object[] {
            "Phone",
            "Email"});
            this.clstCntct.Location = new System.Drawing.Point(433, 340);
            this.clstCntct.Name = "clstCntct";
            this.clstCntct.Size = new System.Drawing.Size(98, 42);
            this.clstCntct.TabIndex = 8;
            // 
            // groupBoxTime
            // 
            this.groupBoxTime.Controls.Add(this.rdbBrkFst);
            this.groupBoxTime.Controls.Add(this.rdbDnr);
            this.groupBoxTime.Controls.Add(this.rdbLnch);
            this.groupBoxTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTime.ForeColor = System.Drawing.Color.White;
            this.groupBoxTime.Location = new System.Drawing.Point(68, 163);
            this.groupBoxTime.Name = "groupBoxTime";
            this.groupBoxTime.Size = new System.Drawing.Size(331, 44);
            this.groupBoxTime.TabIndex = 7;
            this.groupBoxTime.TabStop = false;
            this.groupBoxTime.Text = "Time";
            // 
            // rdbBrkFst
            // 
            this.rdbBrkFst.AutoSize = true;
            this.rdbBrkFst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBrkFst.Location = new System.Drawing.Point(48, 16);
            this.rdbBrkFst.Name = "rdbBrkFst";
            this.rdbBrkFst.Size = new System.Drawing.Size(82, 20);
            this.rdbBrkFst.TabIndex = 0;
            this.rdbBrkFst.TabStop = true;
            this.rdbBrkFst.Text = "Breakfast";
            this.rdbBrkFst.UseVisualStyleBackColor = true;
            // 
            // rdbDnr
            // 
            this.rdbDnr.AutoSize = true;
            this.rdbDnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDnr.Location = new System.Drawing.Point(247, 16);
            this.rdbDnr.Name = "rdbDnr";
            this.rdbDnr.Size = new System.Drawing.Size(64, 20);
            this.rdbDnr.TabIndex = 0;
            this.rdbDnr.TabStop = true;
            this.rdbDnr.Text = "Dinner";
            this.rdbDnr.UseVisualStyleBackColor = true;
            // 
            // rdbLnch
            // 
            this.rdbLnch.AutoSize = true;
            this.rdbLnch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbLnch.Location = new System.Drawing.Point(159, 16);
            this.rdbLnch.Name = "rdbLnch";
            this.rdbLnch.Size = new System.Drawing.Size(60, 20);
            this.rdbLnch.TabIndex = 0;
            this.rdbLnch.TabStop = true;
            this.rdbLnch.Text = "Lunch";
            this.rdbLnch.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Orange;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(588, 37);
            this.panel5.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(204, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Order Now";
            // 
            // btnHm
            // 
            this.btnHm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHm.Location = new System.Drawing.Point(305, 393);
            this.btnHm.Name = "btnHm";
            this.btnHm.Size = new System.Drawing.Size(93, 35);
            this.btnHm.TabIndex = 5;
            this.btnHm.Text = "Home";
            this.btnHm.UseVisualStyleBackColor = true;
            this.btnHm.Click += new System.EventHandler(this.btnHm_Click);
            // 
            // btnMls
            // 
            this.btnMls.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMls.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMls.Location = new System.Drawing.Point(164, 393);
            this.btnMls.Name = "btnMls";
            this.btnMls.Size = new System.Drawing.Size(124, 35);
            this.btnMls.TabIndex = 5;
            this.btnMls.Text = "Select Meals";
            this.btnMls.UseVisualStyleBackColor = true;
            this.btnMls.Click += new System.EventHandler(this.btnMls_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Location = new System.Drawing.Point(66, 393);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(83, 35);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbMbr
            // 
            this.cmbMbr.FormattingEnabled = true;
            this.cmbMbr.Location = new System.Drawing.Point(193, 342);
            this.cmbMbr.Name = "cmbMbr";
            this.cmbMbr.Size = new System.Drawing.Size(103, 21);
            this.cmbMbr.TabIndex = 4;
            // 
            // cmbTblNum
            // 
            this.cmbTblNum.FormattingEnabled = true;
            this.cmbTblNum.Location = new System.Drawing.Point(193, 224);
            this.cmbTblNum.Name = "cmbTblNum";
            this.cmbTblNum.Size = new System.Drawing.Size(103, 21);
            this.cmbTblNum.TabIndex = 4;
            // 
            // dtPkrArriving
            // 
            this.dtPkrArriving.Location = new System.Drawing.Point(193, 123);
            this.dtPkrArriving.Name = "dtPkrArriving";
            this.dtPkrArriving.Size = new System.Drawing.Size(200, 20);
            this.dtPkrArriving.TabIndex = 2;
            // 
            // txtMbNum
            // 
            this.txtMbNum.Location = new System.Drawing.Point(193, 304);
            this.txtMbNum.Name = "txtMbNum";
            this.txtMbNum.Size = new System.Drawing.Size(168, 20);
            this.txtMbNum.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(193, 271);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(238, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(193, 79);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(192, 20);
            this.txtLName.TabIndex = 1;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(193, 42);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(192, 20);
            this.txtFName.TabIndex = 1;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContact.Location = new System.Drawing.Point(429, 317);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(137, 20);
            this.lblContact.TabIndex = 0;
            this.lblContact.Text = "Contact Method";
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMember.Location = new System.Drawing.Point(62, 340);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(82, 20);
            this.lblMember.TabIndex = 0;
            this.lblMember.Text = "Members";
            // 
            // lblMblNum
            // 
            this.lblMblNum.AutoSize = true;
            this.lblMblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMblNum.Location = new System.Drawing.Point(62, 302);
            this.lblMblNum.Name = "lblMblNum";
            this.lblMblNum.Size = new System.Drawing.Size(128, 20);
            this.lblMblNum.TabIndex = 0;
            this.lblMblNum.Text = "Mobile Number";
            // 
            // lblEml
            // 
            this.lblEml.AutoSize = true;
            this.lblEml.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEml.Location = new System.Drawing.Point(62, 269);
            this.lblEml.Name = "lblEml";
            this.lblEml.Size = new System.Drawing.Size(53, 20);
            this.lblEml.TabIndex = 0;
            this.lblEml.Text = "Email";
            // 
            // lblTblNum
            // 
            this.lblTblNum.AutoSize = true;
            this.lblTblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTblNum.Location = new System.Drawing.Point(62, 225);
            this.lblTblNum.Name = "lblTblNum";
            this.lblTblNum.Size = new System.Drawing.Size(120, 20);
            this.lblTblNum.TabIndex = 0;
            this.lblTblNum.Text = "Table Number";
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(62, 124);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(113, 20);
            this.lbldate.TabIndex = 0;
            this.lbldate.Text = "Arriving Date";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLname.Location = new System.Drawing.Point(62, 77);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(95, 20);
            this.lblLname.TabIndex = 0;
            this.lblLname.Text = "Last Name";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.Location = new System.Drawing.Point(62, 40);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(96, 20);
            this.lblFName.TabIndex = 0;
            this.lblFName.Text = "First Name";
            // 
            // pnlLeftOrder
            // 
            this.pnlLeftOrder.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.images;
            this.pnlLeftOrder.Location = new System.Drawing.Point(3, 2);
            this.pnlLeftOrder.Name = "pnlLeftOrder";
            this.pnlLeftOrder.Size = new System.Drawing.Size(200, 446);
            this.pnlLeftOrder.TabIndex = 0;
            // 
            // OrderNow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderNow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderNow";
            this.Load += new System.EventHandler(this.OrderNow_Load);
            this.panel1.ResumeLayout(false);
            this.pnlRightOrder.ResumeLayout(false);
            this.pnlRightOrder.PerformLayout();
            this.groupBoxTime.ResumeLayout(false);
            this.groupBoxTime.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlRightOrder;
        private System.Windows.Forms.ComboBox cmbMbr;
        private System.Windows.Forms.ComboBox cmbTblNum;
        private System.Windows.Forms.RadioButton rdbDnr;
        private System.Windows.Forms.RadioButton rdbLnch;
        private System.Windows.Forms.RadioButton rdbBrkFst;
        private System.Windows.Forms.DateTimePicker dtPkrArriving;
        private System.Windows.Forms.TextBox txtMbNum;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.Label lblMblNum;
        private System.Windows.Forms.Label lblEml;
        private System.Windows.Forms.Label lblTblNum;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Panel pnlLeftOrder;
        private System.Windows.Forms.Button btnHm;
        private System.Windows.Forms.Button btnMls;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxTime;
        private System.Windows.Forms.CheckedListBox clstCntct;
        private System.Windows.Forms.Label lblContact;
    }
}