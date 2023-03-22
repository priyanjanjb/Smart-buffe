namespace WindowsFormsApp1
{
    partial class Rice
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnHm = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.numericUpDownChknRc = new System.Windows.Forms.NumericUpDown();
            this.rdbMutnGrv = new System.Windows.Forms.RadioButton();
            this.lblChknRc = new System.Windows.Forms.Label();
            this.rdbChknGrv = new System.Windows.Forms.RadioButton();
            this.rdbFishGrv = new System.Windows.Forms.RadioButton();
            this.lblGrv = new System.Windows.Forms.Label();
            this.lblChknPlt = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.numericUpDownEgRc = new System.Windows.Forms.NumericUpDown();
            this.rdbMtnEg = new System.Windows.Forms.RadioButton();
            this.lblEgRc = new System.Windows.Forms.Label();
            this.rdbChknEg = new System.Windows.Forms.RadioButton();
            this.rdbFishEg = new System.Windows.Forms.RadioButton();
            this.lblEgCurry = new System.Windows.Forms.Label();
            this.lblPlt = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.numericUpDownRc = new System.Windows.Forms.NumericUpDown();
            this.rdbNmlVeg = new System.Windows.Forms.RadioButton();
            this.lblNormalRc = new System.Windows.Forms.Label();
            this.rdbNmlChkn = new System.Windows.Forms.RadioButton();
            this.rdbNmlFish = new System.Windows.Forms.RadioButton();
            this.lblCurryNml = new System.Windows.Forms.Label();
            this.lblPlateNml = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChknRc)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEgRc)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRc)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel3.Controls.Add(this.btnBack);
            this.panel3.Controls.Add(this.btnHm);
            this.panel3.Controls.Add(this.btnOrder);
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Location = new System.Drawing.Point(204, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(595, 448);
            this.panel3.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(468, 379);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(83, 35);
            this.btnBack.TabIndex = 27;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnHm
            // 
            this.btnHm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHm.Location = new System.Drawing.Point(366, 338);
            this.btnHm.Name = "btnHm";
            this.btnHm.Size = new System.Drawing.Size(93, 35);
            this.btnHm.TabIndex = 24;
            this.btnHm.Text = "Home";
            this.btnHm.UseVisualStyleBackColor = true;
            this.btnHm.Click += new System.EventHandler(this.btnHm_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOrder.Location = new System.Drawing.Point(468, 338);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(99, 35);
            this.btnOrder.TabIndex = 25;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(376, 379);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(83, 35);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel7.Controls.Add(this.numericUpDownChknRc);
            this.panel7.Controls.Add(this.rdbMutnGrv);
            this.panel7.Controls.Add(this.lblChknRc);
            this.panel7.Controls.Add(this.rdbChknGrv);
            this.panel7.Controls.Add(this.rdbFishGrv);
            this.panel7.Controls.Add(this.lblGrv);
            this.panel7.Controls.Add(this.lblChknPlt);
            this.panel7.Location = new System.Drawing.Point(14, 310);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(314, 114);
            this.panel7.TabIndex = 3;
            // 
            // numericUpDownChknRc
            // 
            this.numericUpDownChknRc.Location = new System.Drawing.Point(83, 38);
            this.numericUpDownChknRc.Name = "numericUpDownChknRc";
            this.numericUpDownChknRc.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownChknRc.TabIndex = 6;
            // 
            // rdbMutnGrv
            // 
            this.rdbMutnGrv.AutoSize = true;
            this.rdbMutnGrv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMutnGrv.Location = new System.Drawing.Point(234, 78);
            this.rdbMutnGrv.Name = "rdbMutnGrv";
            this.rdbMutnGrv.Size = new System.Drawing.Size(72, 22);
            this.rdbMutnGrv.TabIndex = 5;
            this.rdbMutnGrv.Text = "Mutton";
            this.rdbMutnGrv.UseVisualStyleBackColor = true;
            // 
            // lblChknRc
            // 
            this.lblChknRc.AutoSize = true;
            this.lblChknRc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChknRc.Location = new System.Drawing.Point(3, 3);
            this.lblChknRc.Name = "lblChknRc";
            this.lblChknRc.Size = new System.Drawing.Size(114, 20);
            this.lblChknRc.TabIndex = 2;
            this.lblChknRc.Text = "Chicken Rice";
            this.lblChknRc.Click += new System.EventHandler(this.lblRiceNorml_Click);
            // 
            // rdbChknGrv
            // 
            this.rdbChknGrv.AutoSize = true;
            this.rdbChknGrv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbChknGrv.Location = new System.Drawing.Point(148, 78);
            this.rdbChknGrv.Name = "rdbChknGrv";
            this.rdbChknGrv.Size = new System.Drawing.Size(80, 22);
            this.rdbChknGrv.TabIndex = 5;
            this.rdbChknGrv.Text = "Chicken";
            this.rdbChknGrv.UseVisualStyleBackColor = true;
            // 
            // rdbFishGrv
            // 
            this.rdbFishGrv.AutoSize = true;
            this.rdbFishGrv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFishGrv.Location = new System.Drawing.Point(81, 78);
            this.rdbFishGrv.Name = "rdbFishGrv";
            this.rdbFishGrv.Size = new System.Drawing.Size(54, 22);
            this.rdbFishGrv.TabIndex = 5;
            this.rdbFishGrv.Text = "Fish";
            this.rdbFishGrv.UseVisualStyleBackColor = true;
            // 
            // lblGrv
            // 
            this.lblGrv.AutoSize = true;
            this.lblGrv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrv.Location = new System.Drawing.Point(15, 76);
            this.lblGrv.Name = "lblGrv";
            this.lblGrv.Size = new System.Drawing.Size(55, 20);
            this.lblGrv.TabIndex = 3;
            this.lblGrv.Text = "Gravy";
            // 
            // lblChknPlt
            // 
            this.lblChknPlt.AutoSize = true;
            this.lblChknPlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChknPlt.Location = new System.Drawing.Point(15, 35);
            this.lblChknPlt.Name = "lblChknPlt";
            this.lblChknPlt.Size = new System.Drawing.Size(59, 20);
            this.lblChknPlt.TabIndex = 3;
            this.lblChknPlt.Text = "Plates";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Purple;
            this.panel6.Controls.Add(this.numericUpDownEgRc);
            this.panel6.Controls.Add(this.rdbMtnEg);
            this.panel6.Controls.Add(this.lblEgRc);
            this.panel6.Controls.Add(this.rdbChknEg);
            this.panel6.Controls.Add(this.rdbFishEg);
            this.panel6.Controls.Add(this.lblEgCurry);
            this.panel6.Controls.Add(this.lblPlt);
            this.panel6.Location = new System.Drawing.Point(231, 183);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(336, 114);
            this.panel6.TabIndex = 3;
            // 
            // numericUpDownEgRc
            // 
            this.numericUpDownEgRc.Location = new System.Drawing.Point(81, 35);
            this.numericUpDownEgRc.Name = "numericUpDownEgRc";
            this.numericUpDownEgRc.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownEgRc.TabIndex = 6;
            // 
            // rdbMtnEg
            // 
            this.rdbMtnEg.AutoSize = true;
            this.rdbMtnEg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMtnEg.Location = new System.Drawing.Point(234, 78);
            this.rdbMtnEg.Name = "rdbMtnEg";
            this.rdbMtnEg.Size = new System.Drawing.Size(72, 22);
            this.rdbMtnEg.TabIndex = 5;
            this.rdbMtnEg.Text = "Mutton";
            this.rdbMtnEg.UseVisualStyleBackColor = true;
            // 
            // lblEgRc
            // 
            this.lblEgRc.AutoSize = true;
            this.lblEgRc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEgRc.Location = new System.Drawing.Point(3, 3);
            this.lblEgRc.Name = "lblEgRc";
            this.lblEgRc.Size = new System.Drawing.Size(82, 20);
            this.lblEgRc.TabIndex = 2;
            this.lblEgRc.Text = "Egg Rice";
            this.lblEgRc.Click += new System.EventHandler(this.lblRiceNorml_Click);
            // 
            // rdbChknEg
            // 
            this.rdbChknEg.AutoSize = true;
            this.rdbChknEg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbChknEg.Location = new System.Drawing.Point(148, 78);
            this.rdbChknEg.Name = "rdbChknEg";
            this.rdbChknEg.Size = new System.Drawing.Size(80, 22);
            this.rdbChknEg.TabIndex = 5;
            this.rdbChknEg.Text = "Chicken";
            this.rdbChknEg.UseVisualStyleBackColor = true;
            // 
            // rdbFishEg
            // 
            this.rdbFishEg.AutoSize = true;
            this.rdbFishEg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFishEg.Location = new System.Drawing.Point(81, 78);
            this.rdbFishEg.Name = "rdbFishEg";
            this.rdbFishEg.Size = new System.Drawing.Size(54, 22);
            this.rdbFishEg.TabIndex = 5;
            this.rdbFishEg.Text = "Fish";
            this.rdbFishEg.UseVisualStyleBackColor = true;
            // 
            // lblEgCurry
            // 
            this.lblEgCurry.AutoSize = true;
            this.lblEgCurry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEgCurry.Location = new System.Drawing.Point(15, 76);
            this.lblEgCurry.Name = "lblEgCurry";
            this.lblEgCurry.Size = new System.Drawing.Size(51, 20);
            this.lblEgCurry.TabIndex = 3;
            this.lblEgCurry.Text = "Curry";
            // 
            // lblPlt
            // 
            this.lblPlt.AutoSize = true;
            this.lblPlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlt.Location = new System.Drawing.Point(15, 35);
            this.lblPlt.Name = "lblPlt";
            this.lblPlt.Size = new System.Drawing.Size(59, 20);
            this.lblPlt.TabIndex = 3;
            this.lblPlt.Text = "Plates";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.numericUpDownRc);
            this.panel5.Controls.Add(this.rdbNmlVeg);
            this.panel5.Controls.Add(this.lblNormalRc);
            this.panel5.Controls.Add(this.rdbNmlChkn);
            this.panel5.Controls.Add(this.rdbNmlFish);
            this.panel5.Controls.Add(this.lblCurryNml);
            this.panel5.Controls.Add(this.lblPlateNml);
            this.panel5.Location = new System.Drawing.Point(16, 58);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(302, 114);
            this.panel5.TabIndex = 3;
            // 
            // numericUpDownRc
            // 
            this.numericUpDownRc.Location = new System.Drawing.Point(97, 38);
            this.numericUpDownRc.Name = "numericUpDownRc";
            this.numericUpDownRc.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownRc.TabIndex = 6;
            // 
            // rdbNmlVeg
            // 
            this.rdbNmlVeg.AutoSize = true;
            this.rdbNmlVeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNmlVeg.Location = new System.Drawing.Point(234, 78);
            this.rdbNmlVeg.Name = "rdbNmlVeg";
            this.rdbNmlVeg.Size = new System.Drawing.Size(62, 22);
            this.rdbNmlVeg.TabIndex = 5;
            this.rdbNmlVeg.TabStop = true;
            this.rdbNmlVeg.Text = "Veggi";
            this.rdbNmlVeg.UseVisualStyleBackColor = true;
            // 
            // lblNormalRc
            // 
            this.lblNormalRc.AutoSize = true;
            this.lblNormalRc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNormalRc.Location = new System.Drawing.Point(3, 3);
            this.lblNormalRc.Name = "lblNormalRc";
            this.lblNormalRc.Size = new System.Drawing.Size(106, 20);
            this.lblNormalRc.TabIndex = 2;
            this.lblNormalRc.Text = "Normal Rice";
            this.lblNormalRc.Click += new System.EventHandler(this.lblRiceNorml_Click);
            // 
            // rdbNmlChkn
            // 
            this.rdbNmlChkn.AutoSize = true;
            this.rdbNmlChkn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNmlChkn.Location = new System.Drawing.Point(148, 78);
            this.rdbNmlChkn.Name = "rdbNmlChkn";
            this.rdbNmlChkn.Size = new System.Drawing.Size(80, 22);
            this.rdbNmlChkn.TabIndex = 5;
            this.rdbNmlChkn.TabStop = true;
            this.rdbNmlChkn.Text = "Chicken";
            this.rdbNmlChkn.UseVisualStyleBackColor = true;
            // 
            // rdbNmlFish
            // 
            this.rdbNmlFish.AutoSize = true;
            this.rdbNmlFish.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNmlFish.Location = new System.Drawing.Point(81, 78);
            this.rdbNmlFish.Name = "rdbNmlFish";
            this.rdbNmlFish.Size = new System.Drawing.Size(54, 22);
            this.rdbNmlFish.TabIndex = 5;
            this.rdbNmlFish.TabStop = true;
            this.rdbNmlFish.Text = "Fish";
            this.rdbNmlFish.UseVisualStyleBackColor = true;
            // 
            // lblCurryNml
            // 
            this.lblCurryNml.AutoSize = true;
            this.lblCurryNml.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurryNml.Location = new System.Drawing.Point(15, 76);
            this.lblCurryNml.Name = "lblCurryNml";
            this.lblCurryNml.Size = new System.Drawing.Size(51, 20);
            this.lblCurryNml.TabIndex = 3;
            this.lblCurryNml.Text = "Curry";
            // 
            // lblPlateNml
            // 
            this.lblPlateNml.AutoSize = true;
            this.lblPlateNml.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlateNml.Location = new System.Drawing.Point(15, 35);
            this.lblPlateNml.Name = "lblPlateNml";
            this.lblPlateNml.Size = new System.Drawing.Size(59, 20);
            this.lblPlateNml.TabIndex = 3;
            this.lblPlateNml.Text = "Plates";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Orange;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(595, 52);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(207, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rice";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.download;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 450);
            this.panel2.TabIndex = 0;
            // 
            // Rice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rice";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownChknRc)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEgRc)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRc)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblNormalRc;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RadioButton rdbMutnGrv;
        private System.Windows.Forms.Label lblChknRc;
        private System.Windows.Forms.RadioButton rdbChknGrv;
        private System.Windows.Forms.RadioButton rdbFishGrv;
        private System.Windows.Forms.Label lblGrv;
        private System.Windows.Forms.Label lblChknPlt;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton rdbMtnEg;
        private System.Windows.Forms.Label lblEgRc;
        private System.Windows.Forms.RadioButton rdbChknEg;
        private System.Windows.Forms.RadioButton rdbFishEg;
        private System.Windows.Forms.Label lblEgCurry;
        private System.Windows.Forms.Label lblPlt;
        private System.Windows.Forms.RadioButton rdbNmlVeg;
        private System.Windows.Forms.RadioButton rdbNmlChkn;
        private System.Windows.Forms.RadioButton rdbNmlFish;
        private System.Windows.Forms.Label lblCurryNml;
        private System.Windows.Forms.Label lblPlateNml;
        private System.Windows.Forms.Button btnHm;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.NumericUpDown numericUpDownChknRc;
        private System.Windows.Forms.NumericUpDown numericUpDownEgRc;
        private System.Windows.Forms.NumericUpDown numericUpDownRc;
    }
}