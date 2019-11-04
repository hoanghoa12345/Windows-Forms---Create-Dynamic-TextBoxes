namespace baitap2
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
            this.btnTong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoPt = new System.Windows.Forms.TextBox();
            this.lbTong = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNhap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTong
            // 
            this.btnTong.Location = new System.Drawing.Point(49, 360);
            this.btnTong.Name = "btnTong";
            this.btnTong.Size = new System.Drawing.Size(90, 33);
            this.btnTong.TabIndex = 0;
            this.btnTong.Text = "Tính Tổng";
            this.btnTong.UseVisualStyleBackColor = true;
            this.btnTong.Click += new System.EventHandler(this.btnTong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập số n";
            // 
            // txtSoPt
            // 
            this.txtSoPt.Location = new System.Drawing.Point(129, 17);
            this.txtSoPt.Name = "txtSoPt";
            this.txtSoPt.Size = new System.Drawing.Size(47, 22);
            this.txtSoPt.TabIndex = 2;
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Location = new System.Drawing.Point(194, 368);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(64, 17);
            this.lbTong.TabIndex = 3;
            this.lbTong.Text = "Tổng là :";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(52, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 261);
            this.panel1.TabIndex = 4;
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(197, 13);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(90, 31);
            this.btnNhap.TabIndex = 5;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTong);
            this.Controls.Add(this.txtSoPt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTong);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSoPt;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNhap;
    }
}

