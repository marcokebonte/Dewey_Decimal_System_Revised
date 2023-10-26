
namespace Dewey_Decimal_System.Games
{
    partial class ReplacingBooks
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
            this.listBoxRand = new System.Windows.Forms.ListBox();
            this.listBoxSorted = new System.Windows.Forms.ListBox();
            this.Upbtn = new System.Windows.Forms.Button();
            this.DownBtn = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblTimer2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxRand
            // 
            this.listBoxRand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxRand.FormattingEnabled = true;
            this.listBoxRand.ItemHeight = 29;
            this.listBoxRand.Location = new System.Drawing.Point(76, 176);
            this.listBoxRand.Name = "listBoxRand";
            this.listBoxRand.Size = new System.Drawing.Size(248, 352);
            this.listBoxRand.TabIndex = 2;
            this.listBoxRand.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBoxRand_MouseDown);
            // 
            // listBoxSorted
            // 
            this.listBoxSorted.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSorted.FormattingEnabled = true;
            this.listBoxSorted.ItemHeight = 29;
            this.listBoxSorted.Location = new System.Drawing.Point(510, 176);
            this.listBoxSorted.Name = "listBoxSorted";
            this.listBoxSorted.Size = new System.Drawing.Size(248, 352);
            this.listBoxSorted.TabIndex = 3;
            this.listBoxSorted.DragDrop += new System.Windows.Forms.DragEventHandler(this.listboxSorted_DragDrop);
            this.listBoxSorted.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBoxSorted_DragEnter);
            // 
            // Upbtn
            // 
            this.Upbtn.AutoSize = true;
            this.Upbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Upbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Upbtn.Location = new System.Drawing.Point(855, 194);
            this.Upbtn.Name = "Upbtn";
            this.Upbtn.Size = new System.Drawing.Size(101, 85);
            this.Upbtn.TabIndex = 4;
            this.Upbtn.Text = "Up";
            this.Upbtn.UseVisualStyleBackColor = true;
            this.Upbtn.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // DownBtn
            // 
            this.DownBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownBtn.Location = new System.Drawing.Point(855, 340);
            this.DownBtn.Name = "DownBtn";
            this.DownBtn.Size = new System.Drawing.Size(101, 85);
            this.DownBtn.TabIndex = 5;
            this.DownBtn.Text = "Down";
            this.DownBtn.UseVisualStyleBackColor = true;
            this.DownBtn.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(140, 101);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(150, 46);
            this.lblTimer.TabIndex = 6;
            this.lblTimer.Text = "Timer: ";
            // 
            // lblTimer2
            // 
            this.lblTimer2.AutoSize = true;
            this.lblTimer2.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer2.ForeColor = System.Drawing.Color.White;
            this.lblTimer2.Location = new System.Drawing.Point(640, 101);
            this.lblTimer2.Name = "lblTimer2";
            this.lblTimer2.Size = new System.Drawing.Size(66, 46);
            this.lblTimer2.TabIndex = 7;
            this.lblTimer2.Text = "00";
            // 
            // ReplacingBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dewey_Decimal_System_Revised.Properties.Resources.Butterfly_lifespan;
            this.ClientSize = new System.Drawing.Size(1000, 579);
            this.Controls.Add(this.lblTimer2);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.DownBtn);
            this.Controls.Add(this.Upbtn);
            this.Controls.Add(this.listBoxSorted);
            this.Controls.Add(this.listBoxRand);
            this.Name = "ReplacingBooks";
            this.Text = "ReplacingBooks";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReplacingBooks_FormClosed);
            this.Load += new System.EventHandler(this.ReplacingBooks_Load);
            this.MouseHover += new System.EventHandler(this.ReplacingBooks_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxRand;
        private System.Windows.Forms.ListBox listBoxSorted;
        private System.Windows.Forms.Button Upbtn;
        private System.Windows.Forms.Button DownBtn;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblTimer2;
    }
}