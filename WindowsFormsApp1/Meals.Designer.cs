namespace WindowsFormsApp1
{
    partial class Meals
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHmMls = new System.Windows.Forms.Button();
            this.pnlNdls = new System.Windows.Forms.Panel();
            this.lblNdls = new System.Windows.Forms.Label();
            this.btnNdls = new System.Windows.Forms.Button();
            this.pnlDrink = new System.Windows.Forms.Panel();
            this.lblDrink = new System.Windows.Forms.Label();
            this.btnDrink = new System.Windows.Forms.Button();
            this.pnlRice = new System.Windows.Forms.Panel();
            this.lblRice = new System.Windows.Forms.Label();
            this.btnRice = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlNdls.SuspendLayout();
            this.pnlDrink.SuspendLayout();
            this.pnlRice.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel2.Controls.Add(this.btnHmMls);
            this.panel2.Controls.Add(this.pnlNdls);
            this.panel2.Controls.Add(this.pnlDrink);
            this.panel2.Controls.Add(this.pnlRice);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(206, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 447);
            this.panel2.TabIndex = 1;
            // 
            // btnHmMls
            // 
            this.btnHmMls.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHmMls.Location = new System.Drawing.Point(489, 387);
            this.btnHmMls.Name = "btnHmMls";
            this.btnHmMls.Size = new System.Drawing.Size(93, 35);
            this.btnHmMls.TabIndex = 25;
            this.btnHmMls.Text = "Home";
            this.btnHmMls.UseVisualStyleBackColor = true;
            this.btnHmMls.Click += new System.EventHandler(this.btnHmMls_Click);
            // 
            // pnlNdls
            // 
            this.pnlNdls.BackColor = System.Drawing.Color.Red;
            this.pnlNdls.Controls.Add(this.lblNdls);
            this.pnlNdls.Controls.Add(this.btnNdls);
            this.pnlNdls.Location = new System.Drawing.Point(117, 266);
            this.pnlNdls.Name = "pnlNdls";
            this.pnlNdls.Size = new System.Drawing.Size(254, 172);
            this.pnlNdls.TabIndex = 1;
            // 
            // lblNdls
            // 
            this.lblNdls.AutoSize = true;
            this.lblNdls.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNdls.Location = new System.Drawing.Point(100, 11);
            this.lblNdls.Name = "lblNdls";
            this.lblNdls.Size = new System.Drawing.Size(64, 20);
            this.lblNdls.TabIndex = 13;
            this.lblNdls.Text = "Noodls";
            // 
            // btnNdls
            // 
            this.btnNdls.BackColor = System.Drawing.Color.Brown;
            this.btnNdls.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.btnNoodle;
            this.btnNdls.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNdls.Location = new System.Drawing.Point(26, 33);
            this.btnNdls.Name = "btnNdls";
            this.btnNdls.Size = new System.Drawing.Size(195, 123);
            this.btnNdls.TabIndex = 0;
            this.btnNdls.UseVisualStyleBackColor = false;
            this.btnNdls.Click += new System.EventHandler(this.btnNdls_Click);
            // 
            // pnlDrink
            // 
            this.pnlDrink.BackColor = System.Drawing.Color.Yellow;
            this.pnlDrink.Controls.Add(this.lblDrink);
            this.pnlDrink.Controls.Add(this.btnDrink);
            this.pnlDrink.Location = new System.Drawing.Point(286, 67);
            this.pnlDrink.Name = "pnlDrink";
            this.pnlDrink.Size = new System.Drawing.Size(261, 193);
            this.pnlDrink.TabIndex = 1;
            // 
            // lblDrink
            // 
            this.lblDrink.AutoSize = true;
            this.lblDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrink.Location = new System.Drawing.Point(111, 14);
            this.lblDrink.Name = "lblDrink";
            this.lblDrink.Size = new System.Drawing.Size(51, 20);
            this.lblDrink.TabIndex = 13;
            this.lblDrink.Text = "Drink";
            // 
            // btnDrink
            // 
            this.btnDrink.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnDrink.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.btnSoftDrink;
            this.btnDrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDrink.Location = new System.Drawing.Point(32, 37);
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.Size = new System.Drawing.Size(192, 138);
            this.btnDrink.TabIndex = 0;
            this.btnDrink.UseVisualStyleBackColor = false;
            this.btnDrink.Click += new System.EventHandler(this.btnDrink_Click);
            // 
            // pnlRice
            // 
            this.pnlRice.BackColor = System.Drawing.Color.Lime;
            this.pnlRice.Controls.Add(this.lblRice);
            this.pnlRice.Controls.Add(this.btnRice);
            this.pnlRice.Location = new System.Drawing.Point(14, 67);
            this.pnlRice.Name = "pnlRice";
            this.pnlRice.Size = new System.Drawing.Size(222, 193);
            this.pnlRice.TabIndex = 1;
            // 
            // lblRice
            // 
            this.lblRice.AutoSize = true;
            this.lblRice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRice.Location = new System.Drawing.Point(91, 11);
            this.lblRice.Name = "lblRice";
            this.lblRice.Size = new System.Drawing.Size(45, 20);
            this.lblRice.TabIndex = 13;
            this.lblRice.Text = "Rice";
            // 
            // btnRice
            // 
            this.btnRice.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnRice.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.btnRice;
            this.btnRice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRice.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRice.Location = new System.Drawing.Point(18, 33);
            this.btnRice.Name = "btnRice";
            this.btnRice.Size = new System.Drawing.Size(183, 142);
            this.btnRice.TabIndex = 0;
            this.btnRice.UseVisualStyleBackColor = false;
            this.btnRice.Click += new System.EventHandler(this.btnRice_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(591, 50);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(101, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choos What You Like";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.images1;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(214, 450);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Meals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Meals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meals";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlNdls.ResumeLayout(false);
            this.pnlNdls.PerformLayout();
            this.pnlDrink.ResumeLayout(false);
            this.pnlDrink.PerformLayout();
            this.pnlRice.ResumeLayout(false);
            this.pnlRice.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlRice;
        private System.Windows.Forms.Button btnRice;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnlNdls;
        private System.Windows.Forms.Label lblNdls;
        private System.Windows.Forms.Button btnNdls;
        private System.Windows.Forms.Panel pnlDrink;
        private System.Windows.Forms.Label lblDrink;
        private System.Windows.Forms.Button btnDrink;
        private System.Windows.Forms.Label lblRice;
        private System.Windows.Forms.Button btnHmMls;
        private System.Windows.Forms.Label label1;
    }
}