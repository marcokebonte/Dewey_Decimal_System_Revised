
namespace Dewey_Decimal_System_Revised
{
    partial class Home
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
            this.btnReplaceBook = new System.Windows.Forms.Button();
            this.btnIdenAreas = new System.Windows.Forms.Button();
            this.btnFindingCallNos = new System.Windows.Forms.Button();
            this.btnLeaderReplace = new System.Windows.Forms.Button();
            this.btnLeaderIden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(826, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dewey Decimal System Learner\'s Software";
            // 
            // btnReplaceBook
            // 
            this.btnReplaceBook.BackColor = System.Drawing.Color.White;
            this.btnReplaceBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplaceBook.Location = new System.Drawing.Point(58, 204);
            this.btnReplaceBook.Name = "btnReplaceBook";
            this.btnReplaceBook.Size = new System.Drawing.Size(177, 132);
            this.btnReplaceBook.TabIndex = 2;
            this.btnReplaceBook.Text = "Replacing Books";
            this.btnReplaceBook.UseVisualStyleBackColor = false;
            this.btnReplaceBook.Click += new System.EventHandler(this.btnReplaceBook_Click);
            // 
            // btnIdenAreas
            // 
            this.btnIdenAreas.BackColor = System.Drawing.Color.White;
            this.btnIdenAreas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdenAreas.Location = new System.Drawing.Point(342, 200);
            this.btnIdenAreas.Name = "btnIdenAreas";
            this.btnIdenAreas.Size = new System.Drawing.Size(189, 132);
            this.btnIdenAreas.TabIndex = 3;
            this.btnIdenAreas.Text = "Identifying Areas";
            this.btnIdenAreas.UseVisualStyleBackColor = false;
            this.btnIdenAreas.Click += new System.EventHandler(this.btnIdenAreas_Click);
            // 
            // btnFindingCallNos
            // 
            this.btnFindingCallNos.BackColor = System.Drawing.Color.White;
            this.btnFindingCallNos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindingCallNos.Location = new System.Drawing.Point(637, 200);
            this.btnFindingCallNos.Name = "btnFindingCallNos";
            this.btnFindingCallNos.Size = new System.Drawing.Size(177, 132);
            this.btnFindingCallNos.TabIndex = 4;
            this.btnFindingCallNos.Text = "Finding Call Numbers";
            this.btnFindingCallNos.UseVisualStyleBackColor = false;
            // 
            // btnLeaderReplace
            // 
            this.btnLeaderReplace.BackColor = System.Drawing.Color.White;
            this.btnLeaderReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaderReplace.Location = new System.Drawing.Point(58, 375);
            this.btnLeaderReplace.Name = "btnLeaderReplace";
            this.btnLeaderReplace.Size = new System.Drawing.Size(177, 47);
            this.btnLeaderReplace.TabIndex = 5;
            this.btnLeaderReplace.Text = "Leaderboard";
            this.btnLeaderReplace.UseVisualStyleBackColor = false;
            this.btnLeaderReplace.Click += new System.EventHandler(this.btnLeaderReplace_Click);
            // 
            // btnLeaderIden
            // 
            this.btnLeaderIden.BackColor = System.Drawing.Color.White;
            this.btnLeaderIden.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaderIden.Location = new System.Drawing.Point(342, 375);
            this.btnLeaderIden.Name = "btnLeaderIden";
            this.btnLeaderIden.Size = new System.Drawing.Size(177, 47);
            this.btnLeaderIden.TabIndex = 6;
            this.btnLeaderIden.Text = "Leaderboard";
            this.btnLeaderIden.UseVisualStyleBackColor = false;
            this.btnLeaderIden.Click += new System.EventHandler(this.btnLeaderIden_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dewey_Decimal_System_Revised.Properties.Resources.Butterfly_lifespan;
            this.ClientSize = new System.Drawing.Size(872, 532);
            this.Controls.Add(this.btnLeaderIden);
            this.Controls.Add(this.btnLeaderReplace);
            this.Controls.Add(this.btnFindingCallNos);
            this.Controls.Add(this.btnIdenAreas);
            this.Controls.Add(this.btnReplaceBook);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReplaceBook;
        private System.Windows.Forms.Button btnIdenAreas;
        private System.Windows.Forms.Button btnFindingCallNos;
        private System.Windows.Forms.Button btnLeaderReplace;
        private System.Windows.Forms.Button btnLeaderIden;
    }
}

