namespace Network_Coffee
{
    partial class SaveChanges
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
            this.Label_SaveChanges = new System.Windows.Forms.Label();
            this.Button_Yes = new System.Windows.Forms.Button();
            this.Button_No = new System.Windows.Forms.Button();
            this.Button_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_SaveChanges
            // 
            this.Label_SaveChanges.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_SaveChanges.Location = new System.Drawing.Point(0, 0);
            this.Label_SaveChanges.Name = "Label_SaveChanges";
            this.Label_SaveChanges.Size = new System.Drawing.Size(384, 111);
            this.Label_SaveChanges.TabIndex = 0;
            this.Label_SaveChanges.Text = "Do You Want To Save Your Unsaved Changes To The Following Path?\r\n\r\n\r\n\r\n ";
            this.Label_SaveChanges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_Yes
            // 
            this.Button_Yes.Location = new System.Drawing.Point(12, 74);
            this.Button_Yes.Name = "Button_Yes";
            this.Button_Yes.Size = new System.Drawing.Size(75, 25);
            this.Button_Yes.TabIndex = 1;
            this.Button_Yes.Text = "Yes";
            this.Button_Yes.UseVisualStyleBackColor = true;
            this.Button_Yes.Click += new System.EventHandler(this.Button_Yes_Click);
            // 
            // Button_No
            // 
            this.Button_No.Location = new System.Drawing.Point(93, 74);
            this.Button_No.Name = "Button_No";
            this.Button_No.Size = new System.Drawing.Size(75, 25);
            this.Button_No.TabIndex = 1;
            this.Button_No.Text = "No";
            this.Button_No.UseVisualStyleBackColor = true;
            this.Button_No.Click += new System.EventHandler(this.Button_No_Click);
            // 
            // Button_Cancel
            // 
            this.Button_Cancel.Location = new System.Drawing.Point(297, 74);
            this.Button_Cancel.Name = "Button_Cancel";
            this.Button_Cancel.Size = new System.Drawing.Size(75, 25);
            this.Button_Cancel.TabIndex = 1;
            this.Button_Cancel.Text = "Cancel";
            this.Button_Cancel.UseVisualStyleBackColor = true;
            this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
            // 
            // SaveChanges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 111);
            this.Controls.Add(this.Button_Cancel);
            this.Controls.Add(this.Button_No);
            this.Controls.Add(this.Button_Yes);
            this.Controls.Add(this.Label_SaveChanges);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaveChanges";
            this.Text = "Save Changes?";
            this.Load += new System.EventHandler(this.SaveChanges_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label_SaveChanges;
        private System.Windows.Forms.Button Button_Yes;
        private System.Windows.Forms.Button Button_No;
        private System.Windows.Forms.Button Button_Cancel;
    }
}