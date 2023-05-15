namespace ReservationFI
{
    partial class CreateOrManage
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
            this.btnCreateRes = new System.Windows.Forms.Button();
            this.btnManageRes = new System.Windows.Forms.Button();
            this.lblClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbGreetings = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateRes
            // 
            this.btnCreateRes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCreateRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateRes.Font = new System.Drawing.Font("Muni Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateRes.ForeColor = System.Drawing.Color.White;
            this.btnCreateRes.Location = new System.Drawing.Point(105, 136);
            this.btnCreateRes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCreateRes.Name = "btnCreateRes";
            this.btnCreateRes.Size = new System.Drawing.Size(315, 138);
            this.btnCreateRes.TabIndex = 30;
            this.btnCreateRes.Text = "CREATE RESERVATION";
            this.btnCreateRes.UseVisualStyleBackColor = false;
            this.btnCreateRes.Click += new System.EventHandler(this.btnCreateRes_Click);
            // 
            // btnManageRes
            // 
            this.btnManageRes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnManageRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageRes.Font = new System.Drawing.Font("Muni Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnManageRes.ForeColor = System.Drawing.Color.White;
            this.btnManageRes.Location = new System.Drawing.Point(105, 324);
            this.btnManageRes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnManageRes.Name = "btnManageRes";
            this.btnManageRes.Size = new System.Drawing.Size(317, 137);
            this.btnManageRes.TabIndex = 31;
            this.btnManageRes.Text = "MANAGE EXISTING RESERVATIONS";
            this.btnManageRes.UseVisualStyleBackColor = false;
            this.btnManageRes.Click += new System.EventHandler(this.btnManageRes_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblClose.Location = new System.Drawing.Point(488, 9);
            this.lblClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(20, 24);
            this.lblClose.TabIndex = 52;
            this.lblClose.Text = "x";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Muni Bold", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(247, 291);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "OR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Muni Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(115, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 18);
            this.label2.TabIndex = 55;
            this.label2.Text = "What would you like to do?";
            // 
            // tbGreetings
            // 
            this.tbGreetings.BackColor = System.Drawing.Color.White;
            this.tbGreetings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbGreetings.Font = new System.Drawing.Font("Muni Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbGreetings.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tbGreetings.Location = new System.Drawing.Point(0, 45);
            this.tbGreetings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbGreetings.Name = "tbGreetings";
            this.tbGreetings.ReadOnly = true;
            this.tbGreetings.Size = new System.Drawing.Size(525, 29);
            this.tbGreetings.TabIndex = 56;
            this.tbGreetings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbGreetings.Visible = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Muni Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(193, 501);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(142, 40);
            this.btnLogout.TabIndex = 57;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // CreateOrManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(525, 565);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tbGreetings);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.btnManageRes);
            this.Controls.Add(this.btnCreateRes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "CreateOrManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateRes;
        private System.Windows.Forms.Button btnManageRes;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbGreetings;
        private Button btnLogout;
    }
}