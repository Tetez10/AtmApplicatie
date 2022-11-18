namespace AtmApplicatie
{
    partial class Menu
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
            this.label10 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Deconnexion = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.TransactieBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SaldoBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.InlegBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IntrekBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 80);
            this.panel1.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(332, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 30);
            this.label9.TabIndex = 24;
            this.label9.Text = "Atm Distribution ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(368, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 37);
            this.label10.TabIndex = 34;
            this.label10.Text = "Menu";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.DarkOrange;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 551);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(927, 42);
            this.panel8.TabIndex = 33;
            // 
            // Deconnexion
            // 
            this.Deconnexion.AutoSize = true;
            this.Deconnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Deconnexion.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Deconnexion.ForeColor = System.Drawing.Color.Black;
            this.Deconnexion.Location = new System.Drawing.Point(583, 506);
            this.Deconnexion.Name = "Deconnexion";
            this.Deconnexion.Size = new System.Drawing.Size(113, 30);
            this.Deconnexion.TabIndex = 32;
            this.Deconnexion.Text = "Deconnect";
            this.Deconnexion.Click += new System.EventHandler(this.Deconnexion_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(583, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(183, 30);
            this.label7.TabIndex = 31;
            this.label7.Text = "AccountNumber : ";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkOrange;
            this.panel7.Controls.Add(this.TransactieBtn);
            this.panel7.Location = new System.Drawing.Point(583, 361);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(205, 110);
            this.panel7.TabIndex = 28;
            // 
            // TransactieBtn
            // 
            this.TransactieBtn.Location = new System.Drawing.Point(48, 38);
            this.TransactieBtn.Name = "TransactieBtn";
            this.TransactieBtn.Size = new System.Drawing.Size(106, 46);
            this.TransactieBtn.TabIndex = 21;
            this.TransactieBtn.Text = "Transactions";
            this.TransactieBtn.UseVisualStyleBackColor = true;
            this.TransactieBtn.Click += new System.EventHandler(this.TransactieBtn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkOrange;
            this.panel4.Controls.Add(this.SaldoBtn);
            this.panel4.Location = new System.Drawing.Point(99, 361);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(205, 110);
            this.panel4.TabIndex = 27;
            // 
            // SaldoBtn
            // 
            this.SaldoBtn.Location = new System.Drawing.Point(41, 38);
            this.SaldoBtn.Name = "SaldoBtn";
            this.SaldoBtn.Size = new System.Drawing.Size(105, 46);
            this.SaldoBtn.TabIndex = 20;
            this.SaldoBtn.Text = "Saldo";
            this.SaldoBtn.UseVisualStyleBackColor = true;
            this.SaldoBtn.Click += new System.EventHandler(this.SaldoBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.Controls.Add(this.InlegBtn);
            this.panel3.Location = new System.Drawing.Point(583, 181);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(205, 110);
            this.panel3.TabIndex = 26;
            // 
            // InlegBtn
            // 
            this.InlegBtn.Location = new System.Drawing.Point(48, 14);
            this.InlegBtn.Name = "InlegBtn";
            this.InlegBtn.Size = new System.Drawing.Size(106, 57);
            this.InlegBtn.TabIndex = 25;
            this.InlegBtn.Text = "Deposit";
            this.InlegBtn.UseVisualStyleBackColor = true;
            this.InlegBtn.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Controls.Add(this.IntrekBtn);
            this.panel2.Location = new System.Drawing.Point(99, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 110);
            this.panel2.TabIndex = 25;
            // 
            // IntrekBtn
            // 
            this.IntrekBtn.Location = new System.Drawing.Point(41, 14);
            this.IntrekBtn.Name = "IntrekBtn";
            this.IntrekBtn.Size = new System.Drawing.Size(90, 49);
            this.IntrekBtn.TabIndex = 23;
            this.IntrekBtn.Text = "Withdraw";
            this.IntrekBtn.UseVisualStyleBackColor = true;
            this.IntrekBtn.Click += new System.EventHandler(this.IntrekBtn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(927, 593);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.Deconnexion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label9;
        private Label label10;
        private Panel panel8;
        private Label Deconnexion;
        private Label label7;
        private Panel panel7;
        private Button TransactieBtn;
        private Panel panel4;
        private Button SaldoBtn;
        private Panel panel3;
        private Button InlegBtn;
        private Panel panel2;
        private Button IntrekBtn;
    }
}