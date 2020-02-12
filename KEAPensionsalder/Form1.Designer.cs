namespace KEAPensionsalder
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.buttonResult = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAgeError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(137, 114);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(196, 25);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "What\'s your name?";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(137, 213);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(179, 25);
            this.labelAge.TabIndex = 1;
            this.labelAge.Text = "How old are you?";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(392, 111);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(191, 31);
            this.textBoxName.TabIndex = 2;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(392, 210);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(191, 31);
            this.textBoxAge.TabIndex = 3;
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(392, 346);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(191, 44);
            this.buttonResult.TabIndex = 4;
            this.buttonResult.Text = "Calculate";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(142, 420);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(767, 31);
            this.textBoxResult.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(446, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Calculate how many years until your pension:";
            // 
            // labelAgeError
            // 
            this.labelAgeError.AutoSize = true;
            this.labelAgeError.Location = new System.Drawing.Point(619, 213);
            this.labelAgeError.Name = "labelAgeError";
            this.labelAgeError.Size = new System.Drawing.Size(0, 25);
            this.labelAgeError.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 552);
            this.Controls.Add(this.labelAgeError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelAgeError;
    }
}

