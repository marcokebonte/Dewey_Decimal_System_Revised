
namespace Dewey_Decimal_System_Revised.Gamification
{
    partial class Leaderboard
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
            this.lvlLeaderboard = new System.Windows.Forms.ListView();
            this.lblLeaderBoard = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvlLeaderboard
            // 
            this.lvlLeaderboard.HideSelection = false;
            this.lvlLeaderboard.Location = new System.Drawing.Point(128, 138);
            this.lvlLeaderboard.Name = "lvlLeaderboard";
            this.lvlLeaderboard.Size = new System.Drawing.Size(614, 353);
            this.lvlLeaderboard.TabIndex = 0;
            this.lvlLeaderboard.UseCompatibleStateImageBehavior = false;
            // 
            // lblLeaderBoard
            // 
            this.lblLeaderBoard.AutoSize = true;
            this.lblLeaderBoard.BackColor = System.Drawing.Color.Transparent;
            this.lblLeaderBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaderBoard.ForeColor = System.Drawing.Color.White;
            this.lblLeaderBoard.Location = new System.Drawing.Point(295, 45);
            this.lblLeaderBoard.Name = "lblLeaderBoard";
            this.lblLeaderBoard.Size = new System.Drawing.Size(310, 55);
            this.lblLeaderBoard.TabIndex = 1;
            this.lblLeaderBoard.Text = "Leaderboard";
            // 
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dewey_Decimal_System_Revised.Properties.Resources.Butterfly_lifespan;
            this.ClientSize = new System.Drawing.Size(889, 503);
            this.Controls.Add(this.lblLeaderBoard);
            this.Controls.Add(this.lvlLeaderboard);
            this.Name = "Leaderboard";
            this.Text = "Leaderboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Leaderboard_FormClosed);
            this.Load += new System.EventHandler(this.Leaderboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvlLeaderboard;
        private System.Windows.Forms.Label lblLeaderBoard;
    }
}