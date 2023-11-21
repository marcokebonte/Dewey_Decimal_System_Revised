using Dewey_Decimal_System.Games;
using Dewey_Decimal_System_Library.Other;
using Dewey_Decimal_System_Revised.Games;
using System;
using System.Windows.Forms;

namespace Dewey_Decimal_System_Revised.Gamification
{
    public partial class DifficultyLevel : Form
    {


        #region Constructor

        public DifficultyLevel()
        {
            InitializeComponent();
        }

        #endregion


        #region Form Load

        private void DifficultyLevel_Load(object sender, EventArgs e)
        {
        }

        #endregion


        #region Form Closed
        private void DifficultyLevel_FormClosed(object sender, FormClosedEventArgs e)
        {
            // navigate back to the homescreen
            this.Hide();
            Home home = new Home();
            home.Show();
        }
        #endregion

        #region Select Difficulty
        private void btnEasy_Click(object sender, EventArgs e)
        {
            // assign time and bonus points
            Univ.CountdownTime = 60;
            Univ.BonusPoints = 0;

            NavigateToGame();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            // assign time and bonus points
            Univ.CountdownTime = 45;
            Univ.BonusPoints = 25;

            NavigateToGame();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            // assign time and bonus points
            Univ.CountdownTime = 30;
            Univ.BonusPoints = 50;

            NavigateToGame();
        }
        #endregion

        #region Game Navigation

        public void NavigateToGame()
        {
            if (Univ.Game1)
            {
                // Game 1
                ReplacingBooks replaceBook = new ReplacingBooks();
                this.Hide();
                try
                {
                    replaceBook.ShowDialog();
                }
                catch (System.NullReferenceException) { throw; }
            }
            else if (Univ.Game2)
            {
                // Game 2
                IdentifyingAreas identifyingAreas = new IdentifyingAreas();
                this.Hide();
                identifyingAreas.ShowDialog();

            }
            else if (Univ.Game3)
            {
                // Game 3
                FindingCallNumbers finding = new FindingCallNumbers();
                this.Hide();
                finding.ShowDialog();

            }
            #endregion

        }
    }
}
