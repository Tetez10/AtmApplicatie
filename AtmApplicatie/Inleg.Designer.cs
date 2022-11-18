namespace AtmApplicatie
{
    partial class Inleg
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
            this.label7 = new System.Windows.Forms.Label();
            this.NieuweSaldo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DepositAmount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AccountNummerTb = new System.Windows.Forms.TextBox();
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
            this.panel1.Size = new System.Drawing.Size(604, 80);
            this.panel1.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Linen;
            this.label9.Location = new System.Drawing.Point(243, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 30);
            this.label9.TabIndex = 24;
            this.label9.Text = "Deposit";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 267);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 41);
            this.button2.TabIndex = 49;
            this.button2.Text = "Deposit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 402);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(604, 48);
            this.panel2.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(187, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 30);
            this.label7.TabIndex = 50;
            this.label7.Text = "AccountNumber";
            // 
            // NieuweSaldo
            // 
            this.NieuweSaldo.AutoSize = true;
            this.NieuweSaldo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NieuweSaldo.ForeColor = System.Drawing.Color.Black;
            this.NieuweSaldo.Location = new System.Drawing.Point(368, 206);
            this.NieuweSaldo.Name = "NieuweSaldo";
            this.NieuweSaldo.Size = new System.Drawing.Size(0, 30);
            this.NieuweSaldo.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(188, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 30);
            this.label2.TabIndex = 57;
            this.label2.Text = "DepositAmount";
            // 
            // DepositAmount
            // 
            this.DepositAmount.Location = new System.Drawing.Point(188, 221);
            this.DepositAmount.Name = "DepositAmount";
            this.DepositAmount.Size = new System.Drawing.Size(159, 23);
            this.DepositAmount.TabIndex = 58;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 39);
            this.button1.TabIndex = 59;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AccountNummerTb
            // 
            this.AccountNummerTb.Location = new System.Drawing.Point(188, 139);
            this.AccountNummerTb.Name = "AccountNummerTb";
            this.AccountNummerTb.Size = new System.Drawing.Size(159, 23);
            this.AccountNummerTb.TabIndex = 60;
            // 
            // Inleg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(604, 450);
            this.Controls.Add(this.AccountNummerTb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DepositAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NieuweSaldo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Name = "Inleg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inleg";
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
        private Label label7;
        private Label NieuweSaldo;
        private Label label2;
        private TextBox DepositAmount;
        private Button button1;
        private TextBox AccountNummerTb;
    }
}