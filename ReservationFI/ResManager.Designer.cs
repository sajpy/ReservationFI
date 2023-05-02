namespace ReservationFI
{
    partial class ResManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.dgReservations = new System.Windows.Forms.DataGridView();
            this.CheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnDeleteRes = new System.Windows.Forms.Button();
            this.tbError = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBack.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBack.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblBack.Location = new System.Drawing.Point(6, 9);
            this.lblBack.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(22, 24);
            this.lblBack.TabIndex = 36;
            this.lblBack.Text = "<";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
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
            this.lblClose.TabIndex = 53;
            this.lblClose.Text = "x";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // dgReservations
            // 
            this.dgReservations.AllowUserToAddRows = false;
            this.dgReservations.AllowUserToDeleteRows = false;
            this.dgReservations.AllowUserToResizeColumns = false;
            this.dgReservations.AllowUserToResizeRows = false;
            this.dgReservations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgReservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgReservations.BackgroundColor = System.Drawing.Color.White;
            this.dgReservations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgReservations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgReservations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Muni Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgReservations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBox});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Muni Bold", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgReservations.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgReservations.GridColor = System.Drawing.Color.Black;
            this.dgReservations.Location = new System.Drawing.Point(41, 40);
            this.dgReservations.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgReservations.Name = "dgReservations";
            this.dgReservations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgReservations.RowHeadersVisible = false;
            this.dgReservations.ShowCellErrors = false;
            this.dgReservations.ShowCellToolTips = false;
            this.dgReservations.ShowEditingIcon = false;
            this.dgReservations.ShowRowErrors = false;
            this.dgReservations.Size = new System.Drawing.Size(443, 404);
            this.dgReservations.TabIndex = 54;
            // 
            // CheckBox
            // 
            this.CheckBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CheckBox.FalseValue = "false";
            this.CheckBox.FillWeight = 50F;
            this.CheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckBox.HeaderText = "";
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CheckBox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CheckBox.TrueValue = "true";
            this.CheckBox.Width = 30;
            // 
            // btnDeleteRes
            // 
            this.btnDeleteRes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDeleteRes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteRes.FlatAppearance.BorderSize = 0;
            this.btnDeleteRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRes.Font = new System.Drawing.Font("Muni Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteRes.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDeleteRes.Location = new System.Drawing.Point(146, 496);
            this.btnDeleteRes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteRes.Name = "btnDeleteRes";
            this.btnDeleteRes.Size = new System.Drawing.Size(233, 58);
            this.btnDeleteRes.TabIndex = 73;
            this.btnDeleteRes.Text = "DELETE";
            this.btnDeleteRes.UseVisualStyleBackColor = false;
            // 
            // tbError
            // 
            this.tbError.BackColor = System.Drawing.Color.White;
            this.tbError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbError.Font = new System.Drawing.Font("Muni Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbError.ForeColor = System.Drawing.Color.Red;
            this.tbError.Location = new System.Drawing.Point(0, 462);
            this.tbError.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbError.Name = "tbError";
            this.tbError.ReadOnly = true;
            this.tbError.Size = new System.Drawing.Size(525, 18);
            this.tbError.TabIndex = 74;
            this.tbError.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbError.Visible = false;
            // 
            // ResManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(525, 565);
            this.Controls.Add(this.tbError);
            this.Controls.Add(this.btnDeleteRes);
            this.Controls.Add(this.dgReservations);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.lblBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ResManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dgReservations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.DataGridView dgReservations;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBox;
        private System.Windows.Forms.Button btnDeleteRes;
        private System.Windows.Forms.TextBox tbError;
    }
}