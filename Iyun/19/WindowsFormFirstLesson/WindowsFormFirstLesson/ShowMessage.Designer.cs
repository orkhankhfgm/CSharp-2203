namespace WindowsFormFirstLesson
{
    partial class ShowMessage
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
            this.textMessage = new System.Windows.Forms.Label();
            this.showMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textMessage
            // 
            this.textMessage.AutoSize = true;
            this.textMessage.Location = new System.Drawing.Point(96, 45);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(0, 13);
            this.textMessage.TabIndex = 0;
            // 
            // showMessageLabel
            // 
            this.showMessageLabel.AutoSize = true;
            this.showMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showMessageLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.showMessageLabel.Location = new System.Drawing.Point(61, 67);
            this.showMessageLabel.Name = "showMessageLabel";
            this.showMessageLabel.Size = new System.Drawing.Size(64, 25);
            this.showMessageLabel.TabIndex = 1;
            this.showMessageLabel.Text = "label1";
            // 
            // ShowMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 498);
            this.Controls.Add(this.showMessageLabel);
            this.Controls.Add(this.textMessage);
            this.Name = "ShowMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesaj göstəriləcək form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textMessage;
        private System.Windows.Forms.Label showMessageLabel;
    }
}