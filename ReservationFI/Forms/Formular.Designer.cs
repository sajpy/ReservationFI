namespace ReservationFI
{
    partial class Formular
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
            this.lbl_hello = new System.Windows.Forms.Label();
            this.dpDate = new System.Windows.Forms.DateTimePicker();
            this.lblBack = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbRooms = new System.Windows.Forms.ComboBox();
            this.btnCreateRes = new System.Windows.Forms.Button();
            this.lblClose = new System.Windows.Forms.Label();
            this.tbError = new System.Windows.Forms.TextBox();
            this.cbStartingAt = new System.Windows.Forms.ComboBox();
            this.cbEndingAt = new System.Windows.Forms.ComboBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_hello
            // 
            this.lbl_hello.AutoSize = true;
            this.lbl_hello.Location = new System.Drawing.Point(247, 387);
            this.lbl_hello.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hello.Name = "lbl_hello";
            this.lbl_hello.Size = new System.Drawing.Size(0, 15);
            this.lbl_hello.TabIndex = 1;
            // 
            // dpDate
            // 
            this.dpDate.CalendarFont = new System.Drawing.Font("Muni Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dpDate.CalendarForeColor = System.Drawing.Color.White;
            this.dpDate.CalendarMonthBackground = System.Drawing.Color.White;
            this.dpDate.CalendarTitleForeColor = System.Drawing.SystemColors.HotTrack;
            this.dpDate.CalendarTrailingForeColor = System.Drawing.SystemColors.HotTrack;
            this.dpDate.Checked = false;
            this.dpDate.Font = new System.Drawing.Font("Muni Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpDate.Location = new System.Drawing.Point(209, 212);
            this.dpDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dpDate.MinDate = new System.DateTime(2022, 4, 27, 0, 0, 0, 0);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(168, 25);
            this.dpDate.TabIndex = 14;
            this.dpDate.CloseUp += new System.EventHandler(this.dpDate_CloseUp);
            this.dpDate.ValueChanged += new System.EventHandler(this.dpDate_ValueChanged);
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBack.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBack.Location = new System.Drawing.Point(6, 9);
            this.lblBack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(22, 24);
            this.lblBack.TabIndex = 35;
            this.lblBack.Text = "<";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Muni Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(78, 59);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(375, 35);
            this.label7.TabIndex = 36;
            this.label7.Text = "CREATE RESERVATION";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(88, 178);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(350, 1);
            this.flowLayoutPanel3.TabIndex = 37;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(88, 247);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(350, 1);
            this.flowLayoutPanel1.TabIndex = 38;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(88, 318);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(350, 1);
            this.flowLayoutPanel2.TabIndex = 40;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(88, 387);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(350, 1);
            this.flowLayoutPanel4.TabIndex = 39;
            // 
            // cbRooms
            // 
            this.cbRooms.BackColor = System.Drawing.Color.White;
            this.cbRooms.DropDownHeight = 200;
            this.cbRooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRooms.DropDownWidth = 100;
            this.cbRooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbRooms.Font = new System.Drawing.Font("Muni Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbRooms.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cbRooms.IntegralHeight = false;
            this.cbRooms.ItemHeight = 23;
            this.cbRooms.Location = new System.Drawing.Point(209, 134);
            this.cbRooms.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbRooms.Name = "cbRooms";
            this.cbRooms.Size = new System.Drawing.Size(174, 31);
            this.cbRooms.TabIndex = 20;
            // 
            // btnCreateRes
            // 
            this.btnCreateRes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCreateRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateRes.Font = new System.Drawing.Font("Muni Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateRes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreateRes.Location = new System.Drawing.Point(88, 448);
            this.btnCreateRes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCreateRes.Name = "btnCreateRes";
            this.btnCreateRes.Size = new System.Drawing.Size(350, 69);
            this.btnCreateRes.TabIndex = 50;
            this.btnCreateRes.Text = "CREATE";
            this.btnCreateRes.UseVisualStyleBackColor = false;
            this.btnCreateRes.Click += new System.EventHandler(this.btnCreateRes_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblClose.Location = new System.Drawing.Point(496, 6);
            this.lblClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(20, 24);
            this.lblClose.TabIndex = 51;
            this.lblClose.Text = "x";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // tbError
            // 
            this.tbError.BackColor = System.Drawing.Color.White;
            this.tbError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbError.Font = new System.Drawing.Font("Muni Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbError.ForeColor = System.Drawing.Color.Red;
            this.tbError.Location = new System.Drawing.Point(0, 411);
            this.tbError.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbError.Name = "tbError";
            this.tbError.ReadOnly = true;
            this.tbError.Size = new System.Drawing.Size(525, 18);
            this.tbError.TabIndex = 52;
            this.tbError.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbError.Visible = false;
            // 
            // cbStartingAt
            // 
            this.cbStartingAt.BackColor = System.Drawing.Color.White;
            this.cbStartingAt.DropDownHeight = 200;
            this.cbStartingAt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStartingAt.DropDownWidth = 100;
            this.cbStartingAt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbStartingAt.Font = new System.Drawing.Font("Muni Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbStartingAt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cbStartingAt.IntegralHeight = false;
            this.cbStartingAt.ItemHeight = 23;
            this.cbStartingAt.Location = new System.Drawing.Point(209, 275);
            this.cbStartingAt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbStartingAt.Name = "cbStartingAt";
            this.cbStartingAt.Size = new System.Drawing.Size(168, 31);
            this.cbStartingAt.TabIndex = 53;
            this.cbStartingAt.SelectedIndexChanged += new System.EventHandler(this.cbStartingAt_SelectedIndexChanged);
            // 
            // cbEndingAt
            // 
            this.cbEndingAt.BackColor = System.Drawing.Color.White;
            this.cbEndingAt.DropDownHeight = 200;
            this.cbEndingAt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEndingAt.DropDownWidth = 100;
            this.cbEndingAt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbEndingAt.Font = new System.Drawing.Font("Muni Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbEndingAt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cbEndingAt.IntegralHeight = false;
            this.cbEndingAt.ItemHeight = 23;
            this.cbEndingAt.Location = new System.Drawing.Point(209, 344);
            this.cbEndingAt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbEndingAt.MaxDropDownItems = 2;
            this.cbEndingAt.Name = "cbEndingAt";
            this.cbEndingAt.Size = new System.Drawing.Size(168, 31);
            this.cbEndingAt.TabIndex = 54;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::ReservationFI.Properties.Resources.date22;
            this.pictureBox7.Location = new System.Drawing.Point(135, 200);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(64, 40);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 49;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::ReservationFI.Properties.Resources.timestart;
            this.pictureBox6.Location = new System.Drawing.Point(135, 270);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(64, 40);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 48;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ReservationFI.Properties.Resources.timestop;
            this.pictureBox5.Location = new System.Drawing.Point(135, 340);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(64, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 47;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ReservationFI.Properties.Resources.choose1;
            this.pictureBox3.Location = new System.Drawing.Point(135, 130);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 45;
            this.pictureBox3.TabStop = false;
            // 
            // Formular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(525, 565);
            this.Controls.Add(this.cbEndingAt);
            this.Controls.Add(this.cbStartingAt);
            this.Controls.Add(this.tbError);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.btnCreateRes);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.cbRooms);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.dpDate);
            this.Controls.Add(this.lbl_hello);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Formular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Formular_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_hello;
        private System.Windows.Forms.DateTimePicker dpDate;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.ComboBox cbRooms;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button btnCreateRes;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.TextBox tbError;
        private System.Windows.Forms.ComboBox cbStartingAt;
        private System.Windows.Forms.ComboBox cbEndingAt;
    }
}