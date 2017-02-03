namespace EmployeeFormCSharp
{
    partial class createEmployee
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
            this.exitButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.annualPayTextBox = new System.Windows.Forms.Label();
            this.salarytextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(202, 297);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(47, 91);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(47, 157);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(47, 13);
            this.positionLabel.TabIndex = 2;
            this.positionLabel.Text = "Position:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(155, 91);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // positionTextBox
            // 
            this.positionTextBox.Location = new System.Drawing.Point(155, 157);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(100, 20);
            this.positionTextBox.TabIndex = 4;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(49, 297);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 7;
            this.SubmitButton.Text = "&Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // annualPayTextBox
            // 
            this.annualPayTextBox.AutoSize = true;
            this.annualPayTextBox.Location = new System.Drawing.Point(47, 214);
            this.annualPayTextBox.Name = "annualPayTextBox";
            this.annualPayTextBox.Size = new System.Drawing.Size(64, 13);
            this.annualPayTextBox.TabIndex = 8;
            this.annualPayTextBox.Text = "Annual Pay:";
            // 
            // salarytextBox
            // 
            this.salarytextBox.Location = new System.Drawing.Point(155, 214);
            this.salarytextBox.Name = "salarytextBox";
            this.salarytextBox.Size = new System.Drawing.Size(100, 20);
            this.salarytextBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(85, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Create a new record";
            
            // 
            // createEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 349);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salarytextBox);
            this.Controls.Add(this.annualPayTextBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.exitButton);
            this.Name = "createEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.createEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label annualPayTextBox;
        private System.Windows.Forms.TextBox salarytextBox;
        private System.Windows.Forms.Label label1;
    }
}