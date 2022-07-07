
namespace Contact_tracing_app__vs_2k19_FINAL_
{
    partial class FrmQrScanner
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
            this.components = new System.ComponentModel.Container();
            this.btnScan = new System.Windows.Forms.Button();
            this.pbScanner = new System.Windows.Forms.PictureBox();
            this.lblDirections = new System.Windows.Forms.Label();
            this.cbxDevices = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.lbl1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbScanner)).BeginInit();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(140)))), ((int)(((byte)(64)))));
            this.btnScan.FlatAppearance.BorderSize = 0;
            this.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScan.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnScan.ForeColor = System.Drawing.Color.White;
            this.btnScan.Location = new System.Drawing.Point(136, 314);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(90, 25);
            this.btnScan.TabIndex = 25;
            this.btnScan.Text = "&Start";
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // pbScanner
            // 
            this.pbScanner.Location = new System.Drawing.Point(39, 44);
            this.pbScanner.Name = "pbScanner";
            this.pbScanner.Size = new System.Drawing.Size(309, 236);
            this.pbScanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbScanner.TabIndex = 26;
            this.pbScanner.TabStop = false;
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.Location = new System.Drawing.Point(90, 283);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(214, 15);
            this.lblDirections.TabIndex = 27;
            this.lblDirections.Text = "Place your QrCode in front of WebCam";
            // 
            // cbxDevices
            // 
            this.cbxDevices.FormattingEnabled = true;
            this.cbxDevices.Location = new System.Drawing.Point(100, 15);
            this.cbxDevices.Name = "cbxDevices";
            this.cbxDevices.Size = new System.Drawing.Size(186, 23);
            this.cbxDevices.TabIndex = 28;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(140)))), ((int)(((byte)(64)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(320, 314);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(56, 25);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "&back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // tmr1
            // 
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(376, 55);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 15);
            this.lbl1.TabIndex = 29;
            // 
            // FrmQrScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(242)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.cbxDevices);
            this.Controls.Add(this.lblDirections);
            this.Controls.Add(this.pbScanner);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnScan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmQrScanner";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmQrScanner_FormClosing);
            this.Load += new System.EventHandler(this.FrmQrScanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbScanner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.PictureBox pbScanner;
        private System.Windows.Forms.Label lblDirections;
        private System.Windows.Forms.ComboBox cbxDevices;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.Label lbl1;
    }
}