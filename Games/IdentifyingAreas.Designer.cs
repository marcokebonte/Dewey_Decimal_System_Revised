
namespace Dewey_Decimal_System_Revised.Games
{
    partial class IdentifyingAreas
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
            this.lstBoxDescription = new System.Windows.Forms.ListBox();
            this.lstBoxCallNo = new System.Windows.Forms.ListBox();
            this.btnCheckAnswer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(303, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Timer: ";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(558, 40);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(66, 46);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "00";
            // 
            // lstBoxDescription
            // 
            this.lstBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxDescription.FormattingEnabled = true;
            this.lstBoxDescription.ItemHeight = 40;
            this.lstBoxDescription.Location = new System.Drawing.Point(112, 116);
            this.lstBoxDescription.Name = "lstBoxDescription";
            this.lstBoxDescription.Size = new System.Drawing.Size(444, 364);
            this.lstBoxDescription.TabIndex = 2;
            this.lstBoxDescription.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstboxDescription_MouseDown);
            // 
            // lstBoxCallNo
            // 
            this.lstBoxCallNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxCallNo.FormattingEnabled = true;
            this.lstBoxCallNo.ItemHeight = 40;
            this.lstBoxCallNo.Location = new System.Drawing.Point(593, 116);
            this.lstBoxCallNo.Name = "lstBoxCallNo";
            this.lstBoxCallNo.Size = new System.Drawing.Size(354, 364);
            this.lstBoxCallNo.TabIndex = 3;
            this.lstBoxCallNo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lstboxCallNo_MouseDown);
            // 
            // btnCheckAnswer
            // 
            this.btnCheckAnswer.Location = new System.Drawing.Point(311, 517);
            this.btnCheckAnswer.Name = "btnCheckAnswer";
            this.btnCheckAnswer.Size = new System.Drawing.Size(446, 59);
            this.btnCheckAnswer.TabIndex = 4;
            this.btnCheckAnswer.Text = "Check Answer";
            this.btnCheckAnswer.UseVisualStyleBackColor = true;
            this.btnCheckAnswer.Click += new System.EventHandler(this.btnCheckAnswer_Click);
            // 
            // IdentifyingAreas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dewey_Decimal_System_Revised.Properties.Resources.Butterfly_lifespan;
            this.ClientSize = new System.Drawing.Size(1073, 602);
            this.Controls.Add(this.btnCheckAnswer);
            this.Controls.Add(this.lstBoxCallNo);
            this.Controls.Add(this.lstBoxDescription);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.label1);
            this.Name = "IdentifyingAreas";
            this.Text = "IdentifyingAreas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.IdentifyingAreas_FormClosed);
            this.Load += new System.EventHandler(this.IdentifyingAreas_Load);
            this.MouseHover += new System.EventHandler(this.IdentifyingAreas_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.ListBox lstBoxDescription;
        private System.Windows.Forms.ListBox lstBoxCallNo;
        private System.Windows.Forms.Button btnCheckAnswer;
    }
}