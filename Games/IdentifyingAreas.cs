using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dewey_Decimal_System.Forms_Models;
using Dewey_Decimal_System_Revised.Gamification;
using Dewey_Decimal_System_Library.Logic;
using Dewey_Decimal_System_Library.Other;
using Dewey_Decimal_System_Library.JSON;

namespace Dewey_Decimal_System_Revised.Games
{
    public partial class IdentifyingAreas : Form
    {
        static int count = 0;


        // instantiate object
        //MatchingCallDescription matching = new MatchingCallDescription();
        MatchingCallDescription matching = new MatchingCallDescription();

        // instantiate timer object
        CountDownTimer timer = new CountDownTimer();


        // flag bool for testing if the game has started
        bool gameBegin = false;


        #region Constructor
        public IdentifyingAreas()
        {
            InitializeComponent();
        }
        #endregion

        #region Button Check Answer
        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            // declare variables 
            string callNumber = null, description = null;


            // check ff the user has selected an item from the listbox
            if (lstBoxCallNo.SelectedItem != null)
            {
                // get the user input from the list box
                callNumber = lstBoxCallNo.SelectedItem.ToString();

                if (lstBoxDescription.SelectedItem != null)
                {
                    // get the user input from the list box
                    description = lstBoxDescription.SelectedItem.ToString();

                    // check ff the user has selected an item from the listbox
                    if (matching.CheckAnswer(callNumber, description, Univ.isAltGame))
                    {
                        // if the matching pair is correct remove it from the listbox 
                        lstBoxCallNo.Items.RemoveAt(lstBoxCallNo.SelectedIndex);
                        lstBoxDescription.Items.RemoveAt(lstBoxDescription.SelectedIndex);

                        // increment count 
                        count++;

                        // check if the game has been completed
                        if (matching.isGameFinished(lstBoxCallNo.Items.Count))
                        {
                            updatedScore();
                        }
                    }
                    else
                    {
                        ClearSelectedItems();
                        MessageBox.Show("Whoops! Incorrect match. Have another go!\n Press 'enter' on your keyboard or select 'OK' to continue", "Invalid Match", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                { MessageBox.Show("Please select a description", "Invalid Responce", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            { MessageBox.Show("Please select a call number", "Invalid Responce", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion

        #region Mouse down
        private void lstboxCallNo_MouseDown(object sender, MouseEventArgs e)
        {
            if (!gameBegin)
            {
                StartTimer();
                gameBegin = true;
            }

            // check if the game has been completed
            if (matching.isGameFinished(lstBoxCallNo.Items.Count))
            {
                updatedScore();
            }


        }

        private void lstboxDescription_MouseDown(object sender, MouseEventArgs e)
        {
            if (!gameBegin)
            {
                StartTimer();
                gameBegin = true;
            }
            // check if the game has been completed
            if (matching.isGameFinished(lstBoxCallNo.Items.Count))
            {
                updatedScore();
            }
        }
        #endregion

        #region Form Load
        private void IdentifyingAreas_Load(object sender, EventArgs e)
        {
            // clear lists
            Univ.listDescription.Clear();
            Univ.listCallNos.Clear();
            Univ.dictCallNoDescription.Clear();

            // clear list view
            lstBoxCallNo.Items.Clear();
            lstBoxDescription.Items.Clear();

            // check if json file exists - if !true create json file 
            if (!JsonFileWorker.CallNumFileExists()) { JsonFileWorker.CreateCallNumFile(); }

            // get list values
            Univ.listDescription = matching.GetDescription();
            Univ.listCallNos = matching.GetCallNos();

            // alternate displays
            Alternate(Univ.countAlt);

            // initialise game start to false
            gameBegin = false;

            // initialise game mode
            Univ.Game1 = false;
            Univ.Game2 = true;
            Univ.Game3 = false;

            // initialise counter 
            count = 0;

            // game instructions
            MessageBox.Show("When the descriptions (left) and the call numbers (right) load\n" +
                "the user is required to guess and select one call number and one description " +
                "from each side and then select 'Check Answer' to see if the answer is correct.\n\n" +
                "Upon guessing the correct answer, the items will be removed from the list box." +
                "The user is required to guess all correct matching pairs before the time runs out.\n\n Goodluck!!", "Identify Areas - Instructions");
        }
        #endregion

        #region Other
        // method to un select the item selected by the user in the listbox
        private void ClearSelectedItems()
        {
            lstBoxCallNo.ClearSelected();
            lstBoxDescription.ClearSelected();
        }
        private void Alternate(int count)
        {
            // instantiate random object
            Random rnd = new Random();

            int check = count % 2;


            if (check == 0)
            {
                Univ.isAltGame = true;

                // populate list view
                Univ.listCallNos.ToList().ForEach(x => lstBoxCallNo.Items.Add(x));

                // shuffled list again
                Univ.listDescription.ToList().OrderBy(x => rnd.Next()).ToList().ForEach(x => lstBoxDescription.Items.Add(x.Value));
            }
            else
            {
                Univ.isAltGame = false;

                // populate list view
                Univ.listCallNos.ToList().ForEach(x => lstBoxDescription.Items.Add(x));

                // shuffled list again
                Univ.listDescription.ToList().OrderBy(x => rnd.Next()).ToList().ForEach(x => lstBoxCallNo.Items.Add(x.Value));
            }
        }
        #endregion

        #region Start Timer

        // method that sets the time on the timer and starts the count down
        public void StartTimer()
        {
            //set time dependent on difficulty 
            timer.SetTime(0, Univ.CountdownTime); // 30s

            timer.Start();

            //update label text
            timer.TimeChanged += () => lblTimer.Text = timer.TimeLeftMsStr;

            //timer step. By default is 1 second
            timer.StepMs = 77;
        }
        #endregion

        #region Updated the score
        private void updatedScore()
        {
            // stop timer
            timer.Pause();

            // save the score 
            Univ.Points = ScoreSystem.CalculateScore(Convert.ToInt32(timer.TimeLeft.Seconds), count);

            Univ.UpdateUserControl = true;

            // show user details and score
            Scores scoreAndDetails = new Scores("Congratulations! You Solved Correctly 👑 ");
            this.Hide();
            scoreAndDetails.Show();
        }
        #endregion

        #region Form Closed
        private void IdentifyingAreas_FormClosed(object sender, FormClosedEventArgs e)
        {
            // form navigation
            DifficultyLevel frmDifficultyLevel = new DifficultyLevel();
            this.Hide();
            frmDifficultyLevel.ShowDialog();
        }
        #endregion


        #region Mouse Hover
        private void IdentifyingAreas_MouseHover(object sender, EventArgs e)
        {
            // check if the game has been completed
            if (Convert.ToInt32(timer.TimeLeft.Seconds) == 0)
            {
                // incorrect sorting
                Univ.BonusPoints = 0;
                Univ.Points = ScoreSystem.CalculateScore(0, count);

                Univ.UpdateUserControl = true;

                // show user details and score
                Scores scores = new Scores("Unlucky! You Solved Incorrectly 😢 ");
                this.Hide();
                scores.Show();
            }
        }
        #endregion

    }
}
