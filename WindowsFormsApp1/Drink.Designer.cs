namespace WindowsFormsApp1
{
    partial class Drink
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
            this.btnOrdrDrink = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.numericUpDownSft = new System.Windows.Forms.NumericUpDown();
            this.rdbSftFnta = new System.Windows.Forms.RadioButton();
            this.lblSftDrnk = new System.Windows.Forms.Label();
            this.rdbSftCcl = new System.Windows.Forms.RadioButton();
            this.rdbSftPpc = new System.Windows.Forms.RadioButton();
            this.lblsftDnkTp = new System.Windows.Forms.Label();
            this.lblsftCps = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.numericUpDownJc = new System.Windows.Forms.NumericUpDown();
            this.rdbMngJc = new System.Windows.Forms.RadioButton();
            this.lbljc = new System.Windows.Forms.Label();
            this.rdbPnplJc = new System.Windows.Forms.RadioButton();
            this.rdbOrngJc = new System.Windows.Forms.RadioButton();
            this.lbljucTp = new System.Windows.Forms.Label();
            this.lblJcCps = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.numericUpDownCfe = new System.Windows.Forms.NumericUpDown();
            this.rdbIceCfe = new System.Windows.Forms.RadioButton();
            this.lblCfeCp = new System.Windows.Forms.Label();
            this.rdbMlkCfe = new System.Windows.Forms.RadioButton();
            this.rdbNmlCfe = new System.Windows.Forms.RadioButton();
            this.lblCurryNml = new System.Windows.Forms.Label();
            this.lblCfeCps = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSft)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJc)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCfe)).BeginInit();
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
            this.panel3.Controls.Add(this.btnOrdrDrink);
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Location = new System.Drawing.Point(202, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(597, 448);
            this.panel3.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBack.Location = new System.Drawing.Point(487, 389);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(83, 35);
            this.btnBack.TabIndex = 30;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnHm
            // 
            this.btnHm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHm.Location = new System.Drawing.Point(385, 345);
            this.btnHm.Name = "btnHm";
            this.btnHm.Size = new System.Drawing.Size(93, 35);
            this.btnHm.TabIndex = 27;
            this.btnHm.Text = "Home";
            this.btnHm.UseVisualStyleBackColor = true;
            this.btnHm.Click += new System.EventHandler(this.btnHm_Click);
            // 
            // btnOrdrDrink
            // 
            this.btnOrdrDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdrDrink.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOrdrDrink.Location = new System.Drawing.Point(487, 345);
            this.btnOrdrDrink.Name = "btnOrdrDrink";
            this.btnOrdrDrink.Size = new System.Drawing.Size(99, 35);
            this.btnOrdrDrink.TabIndex = 28;
            this.btnOrdrDrink.Text = "Order";
            this.btnOrdrDrink.UseVisualStyleBackColor = true;
            this.btnOrdrDrink.Click += new System.EventHandler(this.btnOrdrDrink_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClear.Location = new System.Drawing.Point(395, 389);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(83, 35);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Purple;
            this.panel7.Controls.Add(this.numericUpDownSft);
            this.panel7.Controls.Add(this.rdbSftFnta);
            this.panel7.Controls.Add(this.lblSftDrnk);
            this.panel7.Controls.Add(this.rdbSftCcl);
            this.panel7.Controls.Add(this.rdbSftPpc);
            this.panel7.Controls.Add(this.lblsftDnkTp);
            this.panel7.Controls.Add(this.lblsftCps);
            this.panel7.Location = new System.Drawing.Point(22, 310);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(353, 114);
            this.panel7.TabIndex = 4;
            // 
            // numericUpDownSft
            // 
            this.numericUpDownSft.Location = new System.Drawing.Point(82, 38);
            this.numericUpDownSft.Name = "numericUpDownSft";
            this.numericUpDownSft.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownSft.TabIndex = 7;
            // 
            // rdbSftFnta
            // 
            this.rdbSftFnta.AutoSize = true;
            this.rdbSftFnta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSftFnta.Location = new System.Drawing.Point(256, 78);
            this.rdbSftFnta.Name = "rdbSftFnta";
            this.rdbSftFnta.Size = new System.Drawing.Size(63, 22);
            this.rdbSftFnta.TabIndex = 5;
            this.rdbSftFnta.Text = "Fanta";
            this.rdbSftFnta.UseVisualStyleBackColor = true;
            // 
            // lblSftDrnk
            // 
            this.lblSftDrnk.AutoSize = true;
            this.lblSftDrnk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSftDrnk.Location = new System.Drawing.Point(3, 3);
            this.lblSftDrnk.Name = "lblSftDrnk";
            this.lblSftDrnk.Size = new System.Drawing.Size(90, 20);
            this.lblSftDrnk.TabIndex = 2;
            this.lblSftDrnk.Text = "Soft Drink";
            // 
            // rdbSftCcl
            // 
            this.rdbSftCcl.AutoSize = true;
            this.rdbSftCcl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSftCcl.Location = new System.Drawing.Point(151, 78);
            this.rdbSftCcl.Name = "rdbSftCcl";
            this.rdbSftCcl.Size = new System.Drawing.Size(98, 22);
            this.rdbSftCcl.TabIndex = 5;
            this.rdbSftCcl.Text = "Coka-Cola";
            this.rdbSftCcl.UseVisualStyleBackColor = true;
            // 
            // rdbSftPpc
            // 
            this.rdbSftPpc.AutoSize = true;
            this.rdbSftPpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSftPpc.Location = new System.Drawing.Point(81, 78);
            this.rdbSftPpc.Name = "rdbSftPpc";
            this.rdbSftPpc.Size = new System.Drawing.Size(63, 22);
            this.rdbSftPpc.TabIndex = 5;
            this.rdbSftPpc.Text = "Pepsi";
            this.rdbSftPpc.UseVisualStyleBackColor = true;
            // 
            // lblsftDnkTp
            // 
            this.lblsftDnkTp.AutoSize = true;
            this.lblsftDnkTp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsftDnkTp.Location = new System.Drawing.Point(15, 76);
            this.lblsftDnkTp.Name = "lblsftDnkTp";
            this.lblsftDnkTp.Size = new System.Drawing.Size(47, 20);
            this.lblsftDnkTp.TabIndex = 3;
            this.lblsftDnkTp.Text = "Type";
            // 
            // lblsftCps
            // 
            this.lblsftCps.AutoSize = true;
            this.lblsftCps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsftCps.Location = new System.Drawing.Point(15, 35);
            this.lblsftCps.Name = "lblsftCps";
            this.lblsftCps.Size = new System.Drawing.Size(50, 20);
            this.lblsftCps.TabIndex = 3;
            this.lblsftCps.Text = "Cups";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Teal;
            this.panel6.Controls.Add(this.numericUpDownJc);
            this.panel6.Controls.Add(this.rdbMngJc);
            this.panel6.Controls.Add(this.lbljc);
            this.panel6.Controls.Add(this.rdbPnplJc);
            this.panel6.Controls.Add(this.rdbOrngJc);
            this.panel6.Controls.Add(this.lbljucTp);
            this.panel6.Controls.Add(this.lblJcCps);
            this.panel6.Location = new System.Drawing.Point(233, 183);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(336, 114);
            this.panel6.TabIndex = 5;
            // 
            // numericUpDownJc
            // 
            this.numericUpDownJc.Location = new System.Drawing.Point(71, 37);
            this.numericUpDownJc.Name = "numericUpDownJc";
            this.numericUpDownJc.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownJc.TabIndex = 7;
            // 
            // rdbMngJc
            // 
            this.rdbMngJc.AutoSize = true;
            this.rdbMngJc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMngJc.Location = new System.Drawing.Point(261, 78);
            this.rdbMngJc.Name = "rdbMngJc";
            this.rdbMngJc.Size = new System.Drawing.Size(72, 22);
            this.rdbMngJc.TabIndex = 5;
            this.rdbMngJc.TabStop = true;
            this.rdbMngJc.Text = "Mango";
            this.rdbMngJc.UseVisualStyleBackColor = true;
            // 
            // lbljc
            // 
            this.lbljc.AutoSize = true;
            this.lbljc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljc.Location = new System.Drawing.Point(3, 3);
            this.lbljc.Name = "lbljc";
            this.lbljc.Size = new System.Drawing.Size(51, 20);
            this.lbljc.TabIndex = 2;
            this.lbljc.Text = "Juice";
            // 
            // rdbPnplJc
            // 
            this.rdbPnplJc.AutoSize = true;
            this.rdbPnplJc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPnplJc.Location = new System.Drawing.Point(171, 78);
            this.rdbPnplJc.Name = "rdbPnplJc";
            this.rdbPnplJc.Size = new System.Drawing.Size(74, 22);
            this.rdbPnplJc.TabIndex = 5;
            this.rdbPnplJc.TabStop = true;
            this.rdbPnplJc.Text = "Pinaple";
            this.rdbPnplJc.UseVisualStyleBackColor = true;
            // 
            // rdbOrngJc
            // 
            this.rdbOrngJc.AutoSize = true;
            this.rdbOrngJc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOrngJc.Location = new System.Drawing.Point(81, 78);
            this.rdbOrngJc.Name = "rdbOrngJc";
            this.rdbOrngJc.Size = new System.Drawing.Size(75, 22);
            this.rdbOrngJc.TabIndex = 5;
            this.rdbOrngJc.TabStop = true;
            this.rdbOrngJc.Text = "Orange";
            this.rdbOrngJc.UseVisualStyleBackColor = true;
            // 
            // lbljucTp
            // 
            this.lbljucTp.AutoSize = true;
            this.lbljucTp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljucTp.Location = new System.Drawing.Point(15, 76);
            this.lbljucTp.Name = "lbljucTp";
            this.lbljucTp.Size = new System.Drawing.Size(47, 20);
            this.lbljucTp.TabIndex = 3;
            this.lbljucTp.Text = "Type";
            // 
            // lblJcCps
            // 
            this.lblJcCps.AutoSize = true;
            this.lblJcCps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJcCps.Location = new System.Drawing.Point(15, 35);
            this.lblJcCps.Name = "lblJcCps";
            this.lblJcCps.Size = new System.Drawing.Size(50, 20);
            this.lblJcCps.TabIndex = 3;
            this.lblJcCps.Text = "Cups";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Red;
            this.panel5.Controls.Add(this.numericUpDownCfe);
            this.panel5.Controls.Add(this.rdbIceCfe);
            this.panel5.Controls.Add(this.lblCfeCp);
            this.panel5.Controls.Add(this.rdbMlkCfe);
            this.panel5.Controls.Add(this.rdbNmlCfe);
            this.panel5.Controls.Add(this.lblCurryNml);
            this.panel5.Controls.Add(this.lblCfeCps);
            this.panel5.Location = new System.Drawing.Point(23, 58);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(302, 114);
            this.panel5.TabIndex = 6;
            // 
            // numericUpDownCfe
            // 
            this.numericUpDownCfe.Location = new System.Drawing.Point(91, 36);
            this.numericUpDownCfe.Name = "numericUpDownCfe";
            this.numericUpDownCfe.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownCfe.TabIndex = 7;
            // 
            // rdbIceCfe
            // 
            this.rdbIceCfe.AutoSize = true;
            this.rdbIceCfe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbIceCfe.Location = new System.Drawing.Point(233, 78);
            this.rdbIceCfe.Name = "rdbIceCfe";
            this.rdbIceCfe.Size = new System.Drawing.Size(45, 22);
            this.rdbIceCfe.TabIndex = 6;
            this.rdbIceCfe.TabStop = true;
            this.rdbIceCfe.Text = "Ice";
            this.rdbIceCfe.UseVisualStyleBackColor = true;
            // 
            // lblCfeCp
            // 
            this.lblCfeCp.AutoSize = true;
            this.lblCfeCp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCfeCp.Location = new System.Drawing.Point(3, 3);
            this.lblCfeCp.Name = "lblCfeCp";
            this.lblCfeCp.Size = new System.Drawing.Size(63, 20);
            this.lblCfeCp.TabIndex = 2;
            this.lblCfeCp.Text = "Coffee";
            // 
            // rdbMlkCfe
            // 
            this.rdbMlkCfe.AutoSize = true;
            this.rdbMlkCfe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMlkCfe.Location = new System.Drawing.Point(171, 78);
            this.rdbMlkCfe.Name = "rdbMlkCfe";
            this.rdbMlkCfe.Size = new System.Drawing.Size(53, 22);
            this.rdbMlkCfe.TabIndex = 5;
            this.rdbMlkCfe.TabStop = true;
            this.rdbMlkCfe.Text = "Milk";
            this.rdbMlkCfe.UseVisualStyleBackColor = true;
            // 
            // rdbNmlCfe
            // 
            this.rdbNmlCfe.AutoSize = true;
            this.rdbNmlCfe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNmlCfe.Location = new System.Drawing.Point(81, 78);
            this.rdbNmlCfe.Name = "rdbNmlCfe";
            this.rdbNmlCfe.Size = new System.Drawing.Size(75, 22);
            this.rdbNmlCfe.TabIndex = 5;
            this.rdbNmlCfe.TabStop = true;
            this.rdbNmlCfe.Text = "Normal";
            this.rdbNmlCfe.UseVisualStyleBackColor = true;
            // 
            // lblCurryNml
            // 
            this.lblCurryNml.AutoSize = true;
            this.lblCurryNml.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurryNml.Location = new System.Drawing.Point(15, 76);
            this.lblCurryNml.Name = "lblCurryNml";
            this.lblCurryNml.Size = new System.Drawing.Size(47, 20);
            this.lblCurryNml.TabIndex = 3;
            this.lblCurryNml.Text = "Type";
            // 
            // lblCfeCps
            // 
            this.lblCfeCps.AutoSize = true;
            this.lblCfeCps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCfeCps.Location = new System.Drawing.Point(15, 35);
            this.lblCfeCps.Name = "lblCfeCps";
            this.lblCfeCps.Size = new System.Drawing.Size(50, 20);
            this.lblCfeCps.TabIndex = 3;
            this.lblCfeCps.Text = "Cups";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Orange;
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(597, 40);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(215, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Drink";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Soft_drink_health_concerns_not_yet_trickled_down_into_social_media_users_mentions_of_brands;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 446);
            this.panel2.TabIndex = 0;
            // 
            // Drink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Drink";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drink";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSft)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownJc)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCfe)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RadioButton rdbSftFnta;
        private System.Windows.Forms.Label lblSftDrnk;
        private System.Windows.Forms.RadioButton rdbSftCcl;
        private System.Windows.Forms.RadioButton rdbSftPpc;
        private System.Windows.Forms.Label lblsftDnkTp;
        private System.Windows.Forms.Label lblsftCps;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RadioButton rdbMngJc;
        private System.Windows.Forms.Label lbljc;
        private System.Windows.Forms.RadioButton rdbPnplJc;
        private System.Windows.Forms.RadioButton rdbOrngJc;
        private System.Windows.Forms.Label lbljucTp;
        private System.Windows.Forms.Label lblJcCps;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblCfeCp;
        private System.Windows.Forms.RadioButton rdbMlkCfe;
        private System.Windows.Forms.RadioButton rdbNmlCfe;
        private System.Windows.Forms.Label lblCurryNml;
        private System.Windows.Forms.Label lblCfeCps;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdbIceCfe;
        private System.Windows.Forms.Button btnHm;
        private System.Windows.Forms.Button btnOrdrDrink;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.NumericUpDown numericUpDownSft;
        private System.Windows.Forms.NumericUpDown numericUpDownJc;
        private System.Windows.Forms.NumericUpDown numericUpDownCfe;
    }
}