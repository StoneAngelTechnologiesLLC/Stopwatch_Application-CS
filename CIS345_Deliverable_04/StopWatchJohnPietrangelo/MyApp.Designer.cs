//John Pietrangelo CIS345 Tues/Thurs 9am
namespace StopWatchJohnPietrangelo
{
    partial class MyApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyApp));
            this.minutesLbl = new System.Windows.Forms.Label();
            this.secondsLbl = new System.Windows.Forms.Label();
            this.tenthsLbl = new System.Windows.Forms.Label();
            this.minutesTxBx = new System.Windows.Forms.TextBox();
            this.colon0Lbl = new System.Windows.Forms.Label();
            this.colon1Lbl = new System.Windows.Forms.Label();
            this.secondsTxBx = new System.Windows.Forms.TextBox();
            this.tenthsTxBx = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.stopWatchTmr = new System.Windows.Forms.Timer(this.components);
            this.dateTimeLbl = new System.Windows.Forms.TextBox();
            this.dateTimeTmr = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // minutesLbl
            // 
            this.minutesLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minutesLbl.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesLbl.ForeColor = System.Drawing.Color.Maroon;
            this.minutesLbl.Location = new System.Drawing.Point(14, 100);
            this.minutesLbl.Name = "minutesLbl";
            this.minutesLbl.Size = new System.Drawing.Size(118, 33);
            this.minutesLbl.TabIndex = 0;
            this.minutesLbl.Text = "Minutes";
            this.minutesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondsLbl
            // 
            this.secondsLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.secondsLbl.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsLbl.ForeColor = System.Drawing.Color.Maroon;
            this.secondsLbl.Location = new System.Drawing.Point(153, 100);
            this.secondsLbl.Name = "secondsLbl";
            this.secondsLbl.Size = new System.Drawing.Size(111, 33);
            this.secondsLbl.TabIndex = 1;
            this.secondsLbl.Text = "Seconds";
            this.secondsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tenthsLbl
            // 
            this.tenthsLbl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tenthsLbl.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenthsLbl.ForeColor = System.Drawing.Color.Maroon;
            this.tenthsLbl.Location = new System.Drawing.Point(293, 100);
            this.tenthsLbl.Name = "tenthsLbl";
            this.tenthsLbl.Size = new System.Drawing.Size(112, 33);
            this.tenthsLbl.TabIndex = 2;
            this.tenthsLbl.Text = "Tenths";
            this.tenthsLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minutesTxBx
            // 
            this.minutesTxBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.minutesTxBx.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesTxBx.ForeColor = System.Drawing.Color.Maroon;
            this.minutesTxBx.Location = new System.Drawing.Point(14, 136);
            this.minutesTxBx.Name = "minutesTxBx";
            this.minutesTxBx.Size = new System.Drawing.Size(118, 50);
            this.minutesTxBx.TabIndex = 3;
            this.minutesTxBx.Text = "00";
            this.minutesTxBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colon0Lbl
            // 
            this.colon0Lbl.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colon0Lbl.ForeColor = System.Drawing.Color.Maroon;
            this.colon0Lbl.Location = new System.Drawing.Point(129, 116);
            this.colon0Lbl.Name = "colon0Lbl";
            this.colon0Lbl.Size = new System.Drawing.Size(34, 72);
            this.colon0Lbl.TabIndex = 4;
            this.colon0Lbl.Text = ":";
            this.colon0Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // colon1Lbl
            // 
            this.colon1Lbl.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colon1Lbl.ForeColor = System.Drawing.Color.Maroon;
            this.colon1Lbl.Location = new System.Drawing.Point(261, 116);
            this.colon1Lbl.Name = "colon1Lbl";
            this.colon1Lbl.Size = new System.Drawing.Size(36, 72);
            this.colon1Lbl.TabIndex = 5;
            this.colon1Lbl.Text = ".";
            this.colon1Lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // secondsTxBx
            // 
            this.secondsTxBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.secondsTxBx.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondsTxBx.ForeColor = System.Drawing.Color.Maroon;
            this.secondsTxBx.Location = new System.Drawing.Point(153, 136);
            this.secondsTxBx.Name = "secondsTxBx";
            this.secondsTxBx.Size = new System.Drawing.Size(111, 50);
            this.secondsTxBx.TabIndex = 6;
            this.secondsTxBx.Text = "00";
            this.secondsTxBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tenthsTxBx
            // 
            this.tenthsTxBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tenthsTxBx.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenthsTxBx.ForeColor = System.Drawing.Color.Maroon;
            this.tenthsTxBx.Location = new System.Drawing.Point(291, 137);
            this.tenthsTxBx.Name = "tenthsTxBx";
            this.tenthsTxBx.ReadOnly = true;
            this.tenthsTxBx.Size = new System.Drawing.Size(114, 50);
            this.tenthsTxBx.TabIndex = 7;
            this.tenthsTxBx.Text = "0";
            this.tenthsTxBx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(122, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // startBtn
            // 
            this.startBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startBtn.BackColor = System.Drawing.Color.Maroon;
            this.startBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.startBtn.FlatAppearance.BorderSize = 4;
            this.startBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.startBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ForeColor = System.Drawing.Color.Gold;
            this.startBtn.Location = new System.Drawing.Point(14, 249);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(101, 44);
            this.startBtn.TabIndex = 9;
            this.startBtn.Text = "START";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.resetBtn.BackColor = System.Drawing.Color.Maroon;
            this.resetBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resetBtn.FlatAppearance.BorderSize = 4;
            this.resetBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.resetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.ForeColor = System.Drawing.Color.Gold;
            this.resetBtn.Location = new System.Drawing.Point(304, 249);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(101, 44);
            this.resetBtn.TabIndex = 10;
            this.resetBtn.Text = "RESET";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // stopWatchTmr
            // 
            this.stopWatchTmr.Enabled = true;
            this.stopWatchTmr.Tick += new System.EventHandler(this.StopWatch_Tick);
            // 
            // dateTimeLbl
            // 
            this.dateTimeLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dateTimeLbl.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLbl.ForeColor = System.Drawing.Color.Maroon;
            this.dateTimeLbl.Location = new System.Drawing.Point(-3, 47);
            this.dateTimeLbl.Name = "dateTimeLbl";
            this.dateTimeLbl.ReadOnly = true;
            this.dateTimeLbl.Size = new System.Drawing.Size(420, 50);
            this.dateTimeLbl.TabIndex = 11;
            this.dateTimeLbl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimeTmr
            // 
            this.dateTimeTmr.Tick += new System.EventHandler(this.DateTimer_Tick);
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(14, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 44);
            this.label1.TabIndex = 12;
            this.label1.Text = "!!! GO DEVILS !!!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(419, 342);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimeLbl);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tenthsTxBx);
            this.Controls.Add(this.secondsTxBx);
            this.Controls.Add(this.colon1Lbl);
            this.Controls.Add(this.colon0Lbl);
            this.Controls.Add(this.minutesTxBx);
            this.Controls.Add(this.tenthsLbl);
            this.Controls.Add(this.secondsLbl);
            this.Controls.Add(this.minutesLbl);
            this.Name = "MyApp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MyApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label minutesLbl;
        private System.Windows.Forms.Label secondsLbl;
        private System.Windows.Forms.Label tenthsLbl;
        private System.Windows.Forms.TextBox minutesTxBx;
        private System.Windows.Forms.Label colon0Lbl;
        private System.Windows.Forms.Label colon1Lbl;
        private System.Windows.Forms.TextBox secondsTxBx;
        private System.Windows.Forms.TextBox tenthsTxBx;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Timer stopWatchTmr;
        private System.Windows.Forms.TextBox dateTimeLbl;
        private System.Windows.Forms.Timer dateTimeTmr;
        private System.Windows.Forms.Label label1;
    }
}

