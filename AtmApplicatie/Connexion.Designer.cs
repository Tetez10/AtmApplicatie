namespace AtmApplicatie
{
    partial class Connexion
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
            this.ConnecterenBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AdminButton = new System.Windows.Forms.Button();
            this.NaamTb = new System.Windows.Forms.TextBox();
            this.Naam = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 410);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(521, 40);
            this.panel2.TabIndex = 9;
            // 
            // ConnecterenBtn
            // 
            this.ConnecterenBtn.Location = new System.Drawing.Point(76, 243);
            this.ConnecterenBtn.Name = "ConnecterenBtn";
            this.ConnecterenBtn.Size = new System.Drawing.Size(153, 41);
            this.ConnecterenBtn.TabIndex = 15;
            this.ConnecterenBtn.Text = "Connect user";
            this.ConnecterenBtn.UseVisualStyleBackColor = true;
            this.ConnecterenBtn.Click += new System.EventHandler(this.ConnecterenBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(182, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 30);
            this.label4.TabIndex = 14;
            this.label4.Text = "Password";
            // 
            // PasswordTb
            // 
            this.PasswordTb.Location = new System.Drawing.Point(182, 202);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.Size = new System.Drawing.Size(153, 23);
            this.PasswordTb.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(182, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "Connexion";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(521, 53);
            this.panel1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(182, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Atm Distribution ";
            // 
            // AdminButton
            // 
            this.AdminButton.Location = new System.Drawing.Point(182, 321);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(153, 41);
            this.AdminButton.TabIndex = 18;
            this.AdminButton.Text = "Sign Up";
            this.AdminButton.UseVisualStyleBackColor = true;
            this.AdminButton.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // NaamTb
            // 
            this.NaamTb.Location = new System.Drawing.Point(182, 131);
            this.NaamTb.Name = "NaamTb";
            this.NaamTb.Size = new System.Drawing.Size(153, 23);
            this.NaamTb.TabIndex = 19;
            // 
            // Naam
            // 
            this.Naam.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Naam.ForeColor = System.Drawing.Color.Black;
            this.Naam.Location = new System.Drawing.Point(182, 98);
            this.Naam.Name = "Naam";
            this.Naam.Size = new System.Drawing.Size(172, 30);
            this.Naam.TabIndex = 20;
            this.Naam.Text = "Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 41);
            this.button1.TabIndex = 22;
            this.button1.Text = "Connect Admin";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Naam);
            this.Controls.Add(this.NaamTb);
            this.Controls.Add(this.AdminButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ConnecterenBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Name = "Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connexion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel2;
        private Button ConnecterenBtn;
        private Label label4;
        private TextBox PasswordTb;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Button AdminButton;
        private TextBox NaamTb;
        private Label Naam;
        private Button button1;
    }
}