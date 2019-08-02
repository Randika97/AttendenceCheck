namespace AttendanceProject
{
    partial class checkAttendance
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkout = new System.Windows.Forms.Button();
            this.id2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.id1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(126, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1632, 893);
            this.panel2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Arial", 22.2F);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(438, 774);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(813, 69);
            this.button1.TabIndex = 2;
            this.button1.Text = "Check Working Hours";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.checkout);
            this.panel3.Controls.Add(this.id2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Font = new System.Drawing.Font("Arial", 22.2F);
            this.panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(857, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(733, 710);
            this.panel3.TabIndex = 1;
            // 
            // checkout
            // 
            this.checkout.Location = new System.Drawing.Point(240, 476);
            this.checkout.Name = "checkout";
            this.checkout.Size = new System.Drawing.Size(264, 78);
            this.checkout.TabIndex = 4;
            this.checkout.Text = "Check Out";
            this.checkout.UseVisualStyleBackColor = true;
            this.checkout.Click += new System.EventHandler(this.Checkout_Click);
            // 
            // id2
            // 
            this.id2.Location = new System.Drawing.Point(251, 270);
            this.id2.Name = "id2";
            this.id2.Size = new System.Drawing.Size(390, 50);
            this.id2.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 43);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "Check Out";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.checkin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.id1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Arial", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(37, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 710);
            this.panel1.TabIndex = 0;
            // 
            // checkin
            // 
            this.checkin.Location = new System.Drawing.Point(223, 476);
            this.checkin.Name = "checkin";
            this.checkin.Size = new System.Drawing.Size(264, 78);
            this.checkin.TabIndex = 3;
            this.checkin.Text = "Check In";
            this.checkin.UseVisualStyleBackColor = true;
            this.checkin.Click += new System.EventHandler(this.Checkin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 43);
            this.label3.TabIndex = 2;
            this.label3.Text = "ID No.";
            // 
            // id1
            // 
            this.id1.Location = new System.Drawing.Point(242, 266);
            this.id1.Name = "id1";
            this.id1.Size = new System.Drawing.Size(390, 50);
            this.id1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Check In";
            // 
            // checkAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "checkAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button checkout;
        private System.Windows.Forms.TextBox id2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button checkin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox id1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

