namespace AtmApplicatie
{
    partial class Loading
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenAtmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenAtmButton
            // 
            this.OpenAtmButton.Location = new System.Drawing.Point(304, 162);
            this.OpenAtmButton.Name = "OpenAtmButton";
            this.OpenAtmButton.Size = new System.Drawing.Size(156, 61);
            this.OpenAtmButton.TabIndex = 1;
            this.OpenAtmButton.Text = "Open Atm";
            this.OpenAtmButton.UseVisualStyleBackColor = true;
            this.OpenAtmButton.Click += new System.EventHandler(this.OpenAtmButton_Click);
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OpenAtmButton);
            this.IsMdiContainer = true;
            this.Name = "Loading";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button OpenAtmButton;
    }
}