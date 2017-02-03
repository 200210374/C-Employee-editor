namespace EmployeeFormCSharp
{
    partial class Paystub
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
            this.employeeLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.employeeDataRichTextBox = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // employeeLabel
            // 
            this.employeeLabel.AutoSize = true;
            this.employeeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.employeeLabel.Location = new System.Drawing.Point(221, 33);
            this.employeeLabel.Name = "employeeLabel";
            this.employeeLabel.Size = new System.Drawing.Size(108, 20);
            this.employeeLabel.TabIndex = 0;
            this.employeeLabel.Text = "Employee List";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Show records";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(386, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "&Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(254, 336);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // employeeDataRichTextBox
            // 
            this.employeeDataRichTextBox.Location = new System.Drawing.Point(98, 70);
            this.employeeDataRichTextBox.Name = "employeeDataRichTextBox";
            this.employeeDataRichTextBox.ReadOnly = true;
            this.employeeDataRichTextBox.Size = new System.Drawing.Size(378, 237);
            this.employeeDataRichTextBox.TabIndex = 11;
            this.employeeDataRichTextBox.Text = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Paystub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 400);
            this.Controls.Add(this.employeeDataRichTextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.employeeLabel);
            this.Name = "Paystub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label employeeLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.RichTextBox employeeDataRichTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

