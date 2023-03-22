namespace WindowsFormsApp1
{
    partial class Form1
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
            this.pnlRight = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnDelivery = new System.Windows.Forms.Button();
            this.btnBookingMl = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnExt = new System.Windows.Forms.Button();
            this.pnlRight.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.panel1);
            this.pnlRight.Controls.Add(this.panel2);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(384, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(400, 461);
            this.pnlRight.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 47);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(65, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Smart Buffe..!";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GrayText;
            this.panel2.Controls.Add(this.btnOrder);
            this.panel2.Controls.Add(this.btnDelivery);
            this.panel2.Controls.Add(this.btnBookingMl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 461);
            this.panel2.TabIndex = 2;
            // 
            // btnOrder
            // 
            this.btnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.Location = new System.Drawing.Point(91, 324);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(233, 70);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Order Now";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnDelivery
            // 
            this.btnDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelivery.Location = new System.Drawing.Point(91, 200);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(233, 70);
            this.btnDelivery.TabIndex = 0;
            this.btnDelivery.Text = "Home Delivery";
            this.btnDelivery.UseVisualStyleBackColor = true;
            this.btnDelivery.Click += new System.EventHandler(this.btnDelivery_Click);
            // 
            // btnBookingMl
            // 
            this.btnBookingMl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookingMl.Location = new System.Drawing.Point(91, 82);
            this.btnBookingMl.Name = "btnBookingMl";
            this.btnBookingMl.Size = new System.Drawing.Size(233, 70);
            this.btnBookingMl.TabIndex = 0;
            this.btnBookingMl.Text = "Booking Meal";
            this.btnBookingMl.UseVisualStyleBackColor = true;
            this.btnBookingMl.Click += new System.EventHandler(this.btnBookingMl_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.photo_1567620905732_2d1ec7ab7445;
            this.pnlLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLeft.Controls.Add(this.btnExt);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(392, 461);
            this.pnlLeft.TabIndex = 0;
            // 
            // btnExt
            // 
            this.btnExt.BackColor = System.Drawing.Color.Red;
            this.btnExt.FlatAppearance.BorderSize = 0;
            this.btnExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExt.Location = new System.Drawing.Point(0, 413);
            this.btnExt.Name = "btnExt";
            this.btnExt.Size = new System.Drawing.Size(101, 48);
            this.btnExt.TabIndex = 0;
            this.btnExt.Text = "Exit";
            this.btnExt.UseVisualStyleBackColor = false;
            this.btnExt.Click += new System.EventHandler(this.btnExt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlRight.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Button btnBookingMl;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnDelivery;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExt;
    }
}

