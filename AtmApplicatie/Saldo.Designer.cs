namespace AtmApplicatie
{
    partial class Saldo
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
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.huidigesaldotb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AccountNrTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toonsaldo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 80);
            this.panel1.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Linen;
            this.label9.Location = new System.Drawing.Point(301, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 30);
            this.label9.TabIndex = 24;
            this.label9.Text = "Saldo";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(167, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 39);
            this.button2.TabIndex = 27;
            this.button2.Text = "Menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 254);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(715, 34);
            this.panel2.TabIndex = 28;
            // 
            // huidigesaldotb
            // 
            this.huidigesaldotb.Location = new System.Drawing.Point(368, 130);
            this.huidigesaldotb.Name = "huidigesaldotb";
            this.huidigesaldotb.Size = new System.Drawing.Size(128, 23);
            this.huidigesaldotb.TabIndex = 29;
            this.huidigesaldotb.TextChanged += new System.EventHandler(this.huidigesaldotb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(368, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Your Saldo";
            // 
            // AccountNrTb
            // 
            this.AccountNrTb.Location = new System.Drawing.Point(167, 130);
            this.AccountNrTb.Name = "AccountNrTb";
            this.AccountNrTb.Size = new System.Drawing.Size(154, 23);
            this.AccountNrTb.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(167, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "AccountNumber";
            // 
            // toonsaldo
            // 
            this.toonsaldo.Location = new System.Drawing.Point(347, 191);
            this.toonsaldo.Name = "toonsaldo";
            this.toonsaldo.Size = new System.Drawing.Size(154, 39);
            this.toonsaldo.TabIndex = 33;
            this.toonsaldo.Text = "Show Saldo";
            this.toonsaldo.UseVisualStyleBackColor = true;
            this.toonsaldo.Click += new System.EventHandler(this.toonsaldo_Click);
            // 
            // Saldo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 288);
            this.Controls.Add(this.toonsaldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AccountNrTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.huidigesaldotb);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Name = "Saldo";
            this.Text = "Saldo";
            this.Load += new System.EventHandler(this.Saldo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label9;
        private Button button2;
        private Panel panel2;
        private TextBox huidigesaldotb;
        private Label label1;
        private TextBox AccountNrTb;
        private Label label2;
        private Button toonsaldo;
    }
}