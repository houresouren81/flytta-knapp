namespace flytta_knapp
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
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.tbxX = new System.Windows.Forms.TextBox();
            this.tbxY = new System.Windows.Forms.TextBox();
            this.btnFlytta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(93, 47);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(26, 25);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(98, 110);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(25, 25);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "Y";
            // 
            // tbxX
            // 
            this.tbxX.Location = new System.Drawing.Point(293, 47);
            this.tbxX.Name = "tbxX";
            this.tbxX.Size = new System.Drawing.Size(207, 29);
            this.tbxX.TabIndex = 2;
            // 
            // tbxY
            // 
            this.tbxY.Location = new System.Drawing.Point(293, 110);
            this.tbxY.Name = "tbxY";
            this.tbxY.Size = new System.Drawing.Size(207, 29);
            this.tbxY.TabIndex = 3;
            // 
            // btnFlytta
            // 
            this.btnFlytta.Location = new System.Drawing.Point(266, 276);
            this.btnFlytta.Name = "btnFlytta";
            this.btnFlytta.Size = new System.Drawing.Size(248, 98);
            this.btnFlytta.TabIndex = 4;
            this.btnFlytta.Text = "Flytta";
            this.btnFlytta.UseVisualStyleBackColor = true;
            this.btnFlytta.Click += new System.EventHandler(this.btnFlytta_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFlytta);
            this.Controls.Add(this.tbxY);
            this.Controls.Add(this.tbxX);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Name = "Form1";
            this.Text = "flytta knapp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox tbxX;
        private System.Windows.Forms.TextBox tbxY;
        private System.Windows.Forms.Button btnFlytta;
    }
}

