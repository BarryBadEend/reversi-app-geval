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
            this.Message = new System.Windows.Forms.Label();
            this.Board_Width = new System.Windows.Forms.TextBox();
            this.x_Label = new System.Windows.Forms.Label();
            this.Board_Height = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(13, 13);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(83, 13);
            this.Message.TabIndex = 0;
            this.Message.Text = "[uitleg message]";
            // 
            // Board_Width
            // 
            this.Board_Width.Location = new System.Drawing.Point(60, 97);
            this.Board_Width.Name = "Board_Width";
            this.Board_Width.Size = new System.Drawing.Size(30, 20);
            this.Board_Width.TabIndex = 1;
            this.Board_Width.Text = "6";
            // 
            // x_Label
            // 
            this.x_Label.AutoSize = true;
            this.x_Label.Location = new System.Drawing.Point(96, 100);
            this.x_Label.Name = "x_Label";
            this.x_Label.Size = new System.Drawing.Size(14, 13);
            this.x_Label.TabIndex = 2;
            this.x_Label.Text = "X";
            // 
            // Board_Height
            // 
            this.Board_Height.Location = new System.Drawing.Point(116, 97);
            this.Board_Height.Name = "Board_Height";
            this.Board_Height.Size = new System.Drawing.Size(30, 20);
            this.Board_Height.TabIndex = 3;
            this.Board_Height.Text = "6";
            // 
            // NewGameConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Board_Height);
            this.Controls.Add(this.x_Label);
            this.Controls.Add(this.Board_Width);
            this.Controls.Add(this.Message);
            this.Name = "NewGameConfig";
            this.Text = "NewGameConfig";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.TextBox Board_Width;
        private System.Windows.Forms.Label x_Label;
        private System.Windows.Forms.TextBox Board_Height;
    }
}