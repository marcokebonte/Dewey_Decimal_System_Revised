namespace Dewey_Decimal_System_Revised.Games
{
    partial class FindingCallNumbers
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.btnChoice4 = new System.Windows.Forms.Button();
            this.btnChoice3 = new System.Windows.Forms.Button();
            this.btnChoice2 = new System.Windows.Forms.Button();
            this.btnChoice1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(398, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 60);
            this.label1.TabIndex = 11;
            this.label1.Text = "Timer :";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 21.75F);
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(577, 69);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(131, 60);
            this.lblTimer.TabIndex = 12;
            this.lblTimer.Text = "00:00";
            // 
            // txbDescription
            // 
            this.txbDescription.BackColor = System.Drawing.Color.White;
            this.txbDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txbDescription.Location = new System.Drawing.Point(188, 238);
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.ReadOnly = true;
            this.txbDescription.Size = new System.Drawing.Size(643, 56);
            this.txbDescription.TabIndex = 13;
            this.txbDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnChoice4
            // 
            this.btnChoice4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnChoice4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btnChoice4.Location = new System.Drawing.Point(817, 379);
            this.btnChoice4.Name = "btnChoice4";
            this.btnChoice4.Size = new System.Drawing.Size(191, 146);
            this.btnChoice4.TabIndex = 17;
            this.btnChoice4.Text = "button4";
            this.btnChoice4.UseVisualStyleBackColor = false;
            this.btnChoice4.Click += new System.EventHandler(this.btnChoice4_Click);
            // 
            // btnChoice3
            // 
            this.btnChoice3.BackColor = System.Drawing.Color.Bisque;
            this.btnChoice3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btnChoice3.Location = new System.Drawing.Point(562, 379);
            this.btnChoice3.Name = "btnChoice3";
            this.btnChoice3.Size = new System.Drawing.Size(191, 146);
            this.btnChoice3.TabIndex = 16;
            this.btnChoice3.Text = "button3";
            this.btnChoice3.UseVisualStyleBackColor = false;
            this.btnChoice3.Click += new System.EventHandler(this.btnChoice3_Click);
            // 
            // btnChoice2
            // 
            this.btnChoice2.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnChoice2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btnChoice2.Location = new System.Drawing.Point(323, 379);
            this.btnChoice2.Name = "btnChoice2";
            this.btnChoice2.Size = new System.Drawing.Size(191, 146);
            this.btnChoice2.TabIndex = 15;
            this.btnChoice2.Text = "button2";
            this.btnChoice2.UseVisualStyleBackColor = false;
            this.btnChoice2.Click += new System.EventHandler(this.btnChoice2_Click);
            // 
            // btnChoice1
            // 
            this.btnChoice1.BackColor = System.Drawing.Color.Moccasin;
            this.btnChoice1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.btnChoice1.Location = new System.Drawing.Point(84, 379);
            this.btnChoice1.Name = "btnChoice1";
            this.btnChoice1.Size = new System.Drawing.Size(191, 146);
            this.btnChoice1.TabIndex = 14;
            this.btnChoice1.Text = "button1";
            this.btnChoice1.UseVisualStyleBackColor = false;
            this.btnChoice1.Click += new System.EventHandler(this.btnChoice1_Click);
            // 
            // FindingCallNumbers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dewey_Decimal_System_Revised.Properties.Resources.Butterfly_lifespan;
            this.ClientSize = new System.Drawing.Size(1088, 588);
            this.Controls.Add(this.btnChoice4);
            this.Controls.Add(this.btnChoice3);
            this.Controls.Add(this.btnChoice2);
            this.Controls.Add(this.btnChoice1);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.label1);
            this.Name = "FindingCallNumbers";
            this.Text = "FindingCallNumbers";
            this.Load += new System.EventHandler(this.FindingCallNumbers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.Button btnChoice4;
        private System.Windows.Forms.Button btnChoice3;
        private System.Windows.Forms.Button btnChoice2;
        private System.Windows.Forms.Button btnChoice1;
    }
}