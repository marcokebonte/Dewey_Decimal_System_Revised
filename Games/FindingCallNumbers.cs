﻿using Dewey_Decimal_System.Forms_Models;
using Dewey_Decimal_System_Library.JSON;
using Dewey_Decimal_System_Library.Logic;
using Dewey_Decimal_System_Library.Model;
using Dewey_Decimal_System_Library.Other;
using Dewey_Decimal_System_Library.Tree_Structure;
using Dewey_Decimal_System_Revised.Gamification;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dewey_Decimal_System_Revised.Games
{
    public partial class FindingCallNumbers : Form
    {
        // instantiate timer object
        CountDownTimer timer = new CountDownTimer();

        // instantiate tree game object
        private TreeGameLevel treeGameLevel;

        // decalre and initialise bool for game levels
        private bool lvl1 = true, lvl2 = false, lvl3 = false;

        public FindingCallNumbers()
        {
            InitializeComponent();
        }


        #region Form Load
        private void FindingCallNumbers_Load(object sender, EventArgs e)
        {
            // refesh the user interface to default values
            RefreshUI();

            // disable buttons 
            ButtonActions(false);

            // call method to check if files exist
            CheckFiles();

            // instantiate object
            FindingCallNo finding = new FindingCallNo();

            // save method call to instance
            treeGameLevel = finding.GetLevel();

            // write description to the user
            txbDescription.Text = treeGameLevel.AnswerPath[2].Description;

            // load buttons with descriptions
            PopulateChoice(1);

            // initialise game modes
            Univ.Game1 = false;
            Univ.Game2 = false;
            Univ.Game3 = true;


            // show timer
            lblTimer.Show();

        }
        #endregion

        #region Button Click Action
        private void btnChoice1_Click(object sender, EventArgs e)
        {
            CheckAnswer(btnChoice1.Text);
        }

        private void btnChoice2_Click(object sender, EventArgs e)
        {
            CheckAnswer(btnChoice2.Text);
        }

        private void btnChoice3_Click(object sender, EventArgs e)
        {
            CheckAnswer(btnChoice3.Text);
        }

        private void btnChoice4_Click(object sender, EventArgs e)
        {
            CheckAnswer(btnChoice4.Text);
        }
        #endregion

        #region Check if Files Exist
        private void CheckFiles()
        {
            //creates tree data file if it does not exist
            if (!JsonFileWorker.TreeGameDataExists())
            {
                JsonFileWorker.CreateTreeDataFile();
            }

            //creates the score file
            if (!JsonFileWorker.TreeGameScoresExists())
            {
                JsonFileWorker.CreateJsonFileCallNumber();
            }

            //loads the tree to a static value, better than reading the tree file every single time
            if (GlobalTree.Tree == null)
            {
                GlobalTree.Tree = JsonFileWorker.GetTree();
            }
        }
        #endregion

        #region Update UI
        private void PopulateChoice(int i)
        {
            if (i == 1)
            {
                // populate level one child node descriptions and call number options
                btnChoice1.Text = treeGameLevel.Level1Options[0].Description + "\n" + treeGameLevel.Level1Options[0].Number;
                btnChoice2.Text = treeGameLevel.Level1Options[1].Description + "\n" + treeGameLevel.Level1Options[1].Number;
                btnChoice3.Text = treeGameLevel.Level1Options[2].Description + "\n" + treeGameLevel.Level1Options[2].Number;
                btnChoice4.Text = treeGameLevel.Level1Options[3].Description + "\n" + treeGameLevel.Level1Options[3].Number;
            }
            else if (i == 2)
            {
                // populate level twoo child node descriptions and call number options
                RefreshUI();
                btnChoice1.Text = treeGameLevel.Level2Options[0].Description + "\n" + treeGameLevel.Level2Options[0].Number;
                btnChoice2.Text = treeGameLevel.Level2Options[1].Description + "\n" + treeGameLevel.Level2Options[1].Number;
                btnChoice3.Text = treeGameLevel.Level2Options[2].Description + "\n" + treeGameLevel.Level2Options[2].Number;
                btnChoice4.Text = treeGameLevel.Level2Options[3].Description + "\n" + treeGameLevel.Level2Options[3].Number;
            }
            else if (i == 3)
            {
                // populate level three child node descriptions and call number options
                RefreshUI();
                btnChoice1.Text = treeGameLevel.Level3Options[0].Description + "\n" + treeGameLevel.Level3Options[0].Number;
                btnChoice2.Text = treeGameLevel.Level3Options[1].Description + "\n" + treeGameLevel.Level3Options[1].Number;
                btnChoice3.Text = treeGameLevel.Level3Options[2].Description + "\n" + treeGameLevel.Level3Options[2].Number;
                btnChoice4.Text = treeGameLevel.Level3Options[3].Description + "\n" + treeGameLevel.Level3Options[3].Number;
            }
            else
            {
                Console.WriteLine("Populate Choice not found");
            }

        }

        private async void FindingCallNumbers_MouseMove(object sender, MouseEventArgs e)
        {
            StartTimer();

            // await 1.5 seconds before starting the game
            await Task.Delay(1500);
            // check if the timer has not run out
            if (TimeFinished())
            {
                this.Hide();
                EndGame();
            }

        }

        // method to initialise ui components back to default
        private void RefreshUI()
        {
            btnChoice1.Text = "Game";
            btnChoice2.Text = "Completed";
            btnChoice3.Text = "Please";
            btnChoice4.Text = "Wait...";
        }
        #endregion

        #region Game Logic
        // method to check if the users selected answer is correct to progress to the next round
        private void CheckAnswer(String text)
        {
            // extract the description from the concatenated call number in the button component
            string[] split = text.Split('\n');
            string newSplit = split[0];

            // declare temp bool
            bool isAnswerCorrect;

            // check the level the user is on
            if (lvl1)
            {
                // check if the user has selected the correct answer from the filtered tree nodes to progress through
                isAnswerCorrect = treeGameLevel.Level1Options.Where(x => x.Description.Equals(newSplit)).Select(x => x.Correct).FirstOrDefault();

                // if the answer is correct
                if (isAnswerCorrect)
                {
                    // populated the choices for the next round
                    PopulateChoice(2);
                    lvl1 = false;
                    lvl2 = true;
                }
                else
                {
                    // end game
                    //MessageBox.Show("Incorrect choice , Please try again", "Invalid Answer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    RefreshUI();
                    EndGame();
                }
            }
            else if (lvl2)
            {
                // check if the user has selected the correct answer from the filtered tree nodes to progress through
                isAnswerCorrect = treeGameLevel.Level2Options.Where(x => x.Description.Equals(newSplit)).Select(x => x.Correct).FirstOrDefault();

                // if the answer is correct
                if (isAnswerCorrect)
                {
                    // populated the choices for the next round
                    RefreshUI();
                    PopulateChoice(3);
                    lvl2 = false;
                    lvl3 = true;
                }
                else
                {
                    // end game
                    //MessageBox.Show("Incorrect choice , Please try again", "Invalid Answer", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    RefreshUI();
                    EndGame();
                }


            }
            else if (lvl3)
            {
                // check if the user has selected the correct answer from the filtered tree nodes to progress through
                isAnswerCorrect = treeGameLevel.Level3Options.Where(x => x.Description.Equals(newSplit)).Select(x => x.Correct).FirstOrDefault();

                // if the answer is correct
                if (isAnswerCorrect)
                {
                    // stop timer
                    timer.Pause();

                    // update the users score
                    updatedScore();
                }
                else
                {
                    // end game
                    RefreshUI();
                    EndGame();
                }
            }
        }
        #endregion

        #region Start Timer
        public bool StartTimer()
        {
            ButtonActions(true);

            //set time dependent on difficulty 
            timer.SetTime(0, Univ.CountdownTime);

            timer.Start();

            //update label text
            timer.TimeChanged += () => lblTimer.Text = timer.TimeLeftMsStr;

            //timer step. By default is 1 second
            timer.StepMs = 77;

            return true;
        }
        #endregion

        #region Update Score
        private async void updatedScore()
        {
            // stop timer
            timer.Pause();

            // for next game to be played
            lvl1 = true;
            lvl2 = false;
            lvl3 = false;
            lblTimer.Hide();
            RefreshUI();

            // save the score 
            Univ.Points = ScoreSystem.CalculateScore(Convert.ToInt32(timer.TimeLeft.Seconds));

            Univ.UpdateUserControl = true;

            // declay the current screen before showing the next view 
            await Task.Delay(3000);

            // show user details and score
            Scores scores = new Scores("Congratulations! You Solved Correctly 👑 ");
            this.Hide();
            scores.Show();



        }
        #endregion

        #region End Game
        private void EndGame()
        {
            timer.Pause();

            // incorrect sorting
            Univ.BonusPoints = 0;
            Univ.Points = 0;

            Univ.UpdateUserControl = true;

            // show user details and score
            Scores scoreAndDetails = new Scores("Unlucky! You Solved Incorrectly 😢 ");
            this.Hide();
            scoreAndDetails.Show();
        }
        #endregion

        #region Time Finished
        public bool TimeFinished()
        {
            // check if the game has been completed
            if (Convert.ToInt32(timer.TimeLeft.Seconds) == 0)
            {
                return true;
            }
            else { return false; }
        }
        #endregion

        #region Button ability
        // control the button action
        private void ButtonActions(bool isEnabled)
        {
            btnChoice1.Enabled = isEnabled;
            btnChoice2.Enabled = isEnabled;
            btnChoice3.Enabled = isEnabled;
            btnChoice4.Enabled = isEnabled;
        }
        #endregion
    }
}

