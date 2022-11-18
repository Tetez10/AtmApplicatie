namespace AtmApplicatie
{
    partial class Intrek
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.CurrentSaldo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.WithdrawAmounttb = new System.Windows.Forms.TextBox();
            this.AccountNummerTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 402);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 48);
            this.panel2.TabIndex = 31;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(282, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 41);
            this.button2.TabIndex = 34;
            this.button2.Text = "Withdraw";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // CurrentSaldo
            // 
            this.CurrentSaldo.AutoSize = true;
            this.CurrentSaldo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentSaldo.ForeColor = System.Drawing.Color.Black;
            this.CurrentSaldo.Location = new System.Drawing.Point(282, 203);
            this.CurrentSaldo.Name = "CurrentSaldo";
            this.CurrentSaldo.Size = new System.Drawing.Size(177, 30);
            this.CurrentSaldo.TabIndex = 33;
            this.CurrentSaldo.Text = "WithdrawAmount";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(282, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 30);
            this.label7.TabIndex = 32;
            this.label7.Text = "AccountNumber";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 80);
            this.panel1.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(295, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 40);
            this.label9.TabIndex = 24;
            this.label9.Text = "Withdraw";
            // 
            // WithdrawAmounttb
            // 
            this.WithdrawAmounttb.Location = new System.Drawing.Point(282, 236);
            this.WithdrawAmounttb.Name = "WithdrawAmounttb";
            this.WithdrawAmounttb.Size = new System.Drawing.Size(159, 23);
            this.WithdrawAmounttb.TabIndex = 35;
            // 
            // AccountNummerTb
            // 
            this.AccountNummerTb.Location = new System.Drawing.Point(282, 160);
            this.AccountNummerTb.Name = "AccountNummerTb";
            this.AccountNummerTb.Size = new System.Drawing.Size(159, 23);
            this.AccountNummerTb.TabIndex = 62;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 39);
            this.button1.TabIndex = 63;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Intrek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AccountNummerTb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.WithdrawAmounttb);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CurrentSaldo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Name = "Intrek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intrek";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel2;
        private Button button2;
        private Label CurrentSaldo;
        private Label label7;
        private Panel panel1;
        private Label label9;
        private TextBox WithdrawAmounttb;
        private TextBox AccountNummerTb;
        private Button button1;
    }
}