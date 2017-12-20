namespace WindowsFormsApp2
{
    partial class NewGameConfig
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
            this.Start_New_Button = new System.Windows.Forms.Button();
            this.Board_Width = new System.Windows.Forms.TextBox();
            this.X_Label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Message_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Start_New_Button
            // 
            this.Start_New_Button.Location = new System.Drawing.Point(197, 226);
            this.Start_New_Button.Name = "Start_New_Button";
            this.Start_New_Button.Size = new System.Drawing.Size(75, 23);
            this.Start_New_Button.TabIndex = 0;
            this.Start_New_Button.Text = "Start New";
            this.Start_New_Button.UseVisualStyleBackColor = true;
            // 
            // Board_Width
            // 
            this.Board_Width.Location = new System.Drawing.Point(58, 91);
            this.Board_Width.Name = "Board_Width";
            this.Board_Width.Size = new System.Drawing.Size(30, 20);
            this.Board_Width.TabIndex = 1;
            this.Board_Width.Text = "6";
            // 
            // X_Label
            // 
            this.X_Label.AutoSize = true;
            this.X_Label.Location = new System.Drawing.Point(94, 94);
            this.X_Label.Name = "X_Label";
            this.X_Label.Size = new System.Drawing.Size(14, 13);
            this.X_Label.TabIndex = 2;
            this.X_Label.Text = "X";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(30, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "6";
            // 
            // Message_Label
            // 
            this.Message_Label.AutoSize = true;
            this.Message_Label.Location = new System.Drawing.Point(33, 40);
            this.Message_Label.Name = "Message_Label";
            this.Message_Label.Size = new System.Drawing.Size(83, 13);
            this.Message_Label.TabIndex = 4;
            this.Message_Label.Text = "[uitleg message]";
            // 
            // NewGameConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Message_Label);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.X_Label);
            this.Controls.Add(this.Board_Width);
            this.Controls.Add(this.Start_New_Button);
            this.Name = "NewGameConfig";
            this.Text = "NewGameConfig";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_New_Button;
        private System.Windows.Forms.TextBox Board_Width;
        private System.Windows.Forms.Label X_Label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Message_Label;
    }
}