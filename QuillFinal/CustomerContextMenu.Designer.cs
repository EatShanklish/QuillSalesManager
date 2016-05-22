namespace QuillFinal
{
    partial class CustomerContextMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ConfirmAccountButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateAccountButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Account Number:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(47, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 1;
            // 
            // ConfirmAccountButton
            // 
            this.ConfirmAccountButton.Location = new System.Drawing.Point(47, 210);
            this.ConfirmAccountButton.Name = "ConfirmAccountButton";
            this.ConfirmAccountButton.Size = new System.Drawing.Size(176, 23);
            this.ConfirmAccountButton.TabIndex = 2;
            this.ConfirmAccountButton.Text = "Confirm";
            this.ConfirmAccountButton.UseVisualStyleBackColor = true;
            this.ConfirmAccountButton.Click += new System.EventHandler(this.ConfirmAccountButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Is this a new customer?";
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.Location = new System.Drawing.Point(60, 60);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(148, 23);
            this.CreateAccountButton.TabIndex = 4;
            this.CreateAccountButton.Text = "Create Account";
            this.CreateAccountButton.UseVisualStyleBackColor = true;
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // CustomerContextMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(284, 265);
            this.Controls.Add(this.CreateAccountButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ConfirmAccountButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "CustomerContextMenu";
            this.Text = "Customer Context";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ConfirmAccountButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CreateAccountButton;
    }
}