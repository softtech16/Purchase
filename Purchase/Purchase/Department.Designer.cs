namespace Purchase
{
    partial class Department
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
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_cmg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_admin
            // 
            this.btn_admin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_admin.Location = new System.Drawing.Point(30, 45);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(90, 50);
            this.btn_admin.TabIndex = 0;
            this.btn_admin.Text = "ADMIN";
            this.btn_admin.UseVisualStyleBackColor = true;
            // 
            // btn_cmg
            // 
            this.btn_cmg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cmg.Location = new System.Drawing.Point(160, 45);
            this.btn_cmg.Name = "btn_cmg";
            this.btn_cmg.Size = new System.Drawing.Size(90, 50);
            this.btn_cmg.TabIndex = 1;
            this.btn_cmg.Text = "CMG";
            this.btn_cmg.UseVisualStyleBackColor = true;
            // 
            // Department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.btn_cmg);
            this.Controls.Add(this.btn_admin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Department";
            this.Text = "Department";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Button btn_cmg;
    }
}