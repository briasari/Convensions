namespace Convensions
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.contextLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.conversionInput = new System.Windows.Forms.TextBox();
            this.valueInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.DarkViolet;
            this.titleLabel.Location = new System.Drawing.Point(103, 32);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(272, 31);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Linear Convensions";
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.Location = new System.Drawing.Point(146, 99);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(182, 140);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = "1. Inches to Centimetres\r\n\r\n2. Feet to Centimetres\r\n\r\n3. Yards to Metres\r\n\r\n4. Mi" +
    "les to Kilometre";
            // 
            // contextLabel
            // 
            this.contextLabel.AutoSize = true;
            this.contextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextLabel.Location = new System.Drawing.Point(87, 269);
            this.contextLabel.Name = "contextLabel";
            this.contextLabel.Size = new System.Drawing.Size(182, 48);
            this.contextLabel.TabIndex = 2;
            this.contextLabel.Text = "Enter conversion choice (1-4):\r\n\r\n   Enter value to be converted:";
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(91, 404);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(285, 32);
            this.outputLabel.TabIndex = 3;
            this.outputLabel.Text = "answer";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // convertButton
            // 
            this.convertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Location = new System.Drawing.Point(74, 353);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(324, 23);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // conversionInput
            // 
            this.conversionInput.Location = new System.Drawing.Point(275, 268);
            this.conversionInput.Name = "conversionInput";
            this.conversionInput.Size = new System.Drawing.Size(100, 20);
            this.conversionInput.TabIndex = 5;
            // 
            // valueInput
            // 
            this.valueInput.Location = new System.Drawing.Point(275, 299);
            this.valueInput.Name = "valueInput";
            this.valueInput.Size = new System.Drawing.Size(100, 20);
            this.valueInput.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 455);
            this.Controls.Add(this.valueInput);
            this.Controls.Add(this.conversionInput);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.contextLabel);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.Label contextLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TextBox conversionInput;
        private System.Windows.Forms.TextBox valueInput;
    }
}

