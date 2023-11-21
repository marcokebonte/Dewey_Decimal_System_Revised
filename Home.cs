using Dewey_Decimal_System_Library.Other;
using Dewey_Decimal_System_Revised.Gamification;
using System;
using System.Windows.Forms;

namespace Dewey_Decimal_System_Revised
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }


        private void btnReplaceBook_Click(object sender, EventArgs e)
        {
            Univ.ReplacingBooks = true;

            // initialise game mode
            Univ.Game1 = true;
            Univ.Game2 = false;
            Univ.Game3 = false;


            // form navigation
            DifficultyLevel DifficultyL = new DifficultyLevel();
            this.Hide();
            try
            {
                DifficultyL.ShowDialog();
            }
            catch (System.NullReferenceException) { throw; }
        }



        private void btnLeaderReplace_Click(object sender, EventArgs e)
        {
            // initialise game mode
            Univ.Game1 = true;
            Univ.Game2 = false;
            Univ.Game3 = false;

            // form navigation
            Leaderboard Leader = new Leaderboard();
            this.Hide();
            Leader.ShowDialog();
        }



        private void btnIdenAreas_Click(object sender, EventArgs e)
        {
            //initialise game mode
            Univ.Game1 = false;
            Univ.Game2 = true;
            Univ.Game3 = false;

            DifficultyLevel DifficultyL = new DifficultyLevel();
            this.Hide();
            DifficultyL.ShowDialog();

        }


        private void btnLeaderIden_Click(object sender, EventArgs e)
        {
            // initialise game mode
            Univ.Game1 = false;
            Univ.Game2 = true;
            Univ.Game3 = false;

            // navigation to new form 
            Leaderboard IdentifyLeaderboard = new Leaderboard();
            this.Hide();
            IdentifyLeaderboard.ShowDialog();
        }




        private void btnFindingCallNumbers_Click(object sender, EventArgs e)
        {
            // initialise game mode
            Univ.Game1 = false;
            Univ.Game2 = false;
            Univ.Game3 = true;

            DifficultyLevel DifficultyL = new DifficultyLevel();
            this.Hide();
            DifficultyL.ShowDialog();
        }

        private void FindingCallNumbersLeaderboard_Click(object sender, EventArgs e)
        {
            // initialise game mode
            Univ.Game1 = false;
            Univ.Game2 = false;
            Univ.Game3 = true;

            // navigation to new form 
            Leaderboard sortingLeaderboard = new Leaderboard();
            this.Hide();
            sortingLeaderboard.ShowDialog();
        }
    }//End of Class



}//End of Namespace

