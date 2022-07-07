
namespace Contact_tracing_app__vs_2k19_FINAL_
{
    partial class FrmRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecords));
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.dtpDov = new System.Windows.Forms.DateTimePicker();
            this.lvRecords = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.lblDetailOfPerson = new System.Windows.Forms.Label();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(27, 4);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(73, 84);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 2;
            this.pbLogo.TabStop = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Bahnschrift SemiBold SemiConden", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location = new System.Drawing.Point(114, 21);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(145, 42);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "RECORDS";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(140)))), ((int)(((byte)(64)))));
            this.pnlHeader.Controls.Add(this.pbLogo);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.lblClose);
            this.pnlHeader.Location = new System.Drawing.Point(0, -1);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(697, 88);
            this.pnlHeader.TabIndex = 2;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClose.ForeColor = System.Drawing.Color.White;
            this.lblClose.Location = new System.Drawing.Point(653, 10);
            this.lblClose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(30, 32);
            this.lblClose.TabIndex = 0;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // dtpDov
            // 
            this.dtpDov.Location = new System.Drawing.Point(89, 379);
            this.dtpDov.Name = "dtpDov";
            this.dtpDov.Size = new System.Drawing.Size(195, 23);
            this.dtpDov.TabIndex = 3;
            // 
            // lvRecords
            // 
            this.lvRecords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvRecords.GridLines = true;
            this.lvRecords.HideSelection = false;
            this.lvRecords.Location = new System.Drawing.Point(39, 112);
            this.lvRecords.Name = "lvRecords";
            this.lvRecords.Size = new System.Drawing.Size(288, 251);
            this.lvRecords.TabIndex = 7;
            this.lvRecords.UseCompatibleStateImageBehavior = false;
            this.lvRecords.View = System.Windows.Forms.View.Details;
            this.lvRecords.SelectedIndexChanged += new System.EventHandler(this.lvRecords_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Date of  Visit";
            this.columnHeader2.Width = 130;
            // 
            // lblDetailOfPerson
            // 
            this.lblDetailOfPerson.AutoSize = true;
            this.lblDetailOfPerson.Location = new System.Drawing.Point(353, 133);
            this.lblDetailOfPerson.Name = "lblDetailOfPerson";
            this.lblDetailOfPerson.Size = new System.Drawing.Size(0, 15);
            this.lblDetailOfPerson.TabIndex = 8;
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(140)))), ((int)(((byte)(64)))));
            this.btnSort.FlatAppearance.BorderSize = 0;
            this.btnSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSort.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSort.ForeColor = System.Drawing.Color.White;
            this.btnSort.Location = new System.Drawing.Point(63, 426);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(88, 26);
            this.btnSort.TabIndex = 25;
            this.btnSort.Text = "&Sort";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(140)))), ((int)(((byte)(64)))));
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(239, 426);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(88, 26);
            this.btnReset.TabIndex = 25;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // FrmRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(694, 464);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.lblDetailOfPerson);
            this.Controls.Add(this.lvRecords);
            this.Controls.Add(this.dtpDov);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRecords";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repository_of_Forms";
            this.Load += new System.EventHandler(this.FrmRecords_Load);
            this.Shown += new System.EventHandler(this.FrmRecords_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.DateTimePicker dtpDov;
        private System.Windows.Forms.ListView lvRecords;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lblDetailOfPerson;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnReset;
    }
}