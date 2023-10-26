using Dewey_Decimal_System.Forms_Models;
using Dewey_Decimal_System_Revised.Gamification;
using Dewey_Decimal_System_Library.Logic;
using Dewey_Decimal_System_Library.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Dewey_Decimal_System.Games
{
    public partial class ReplacingBooks : Form
    {




        //Declaring lists
        List<String> sortedList;
        List<String> shuffledList;
        List<String> userInputList;


        //Instantiating a timer object
        CountDownTimer timer = new CountDownTimer();



        public bool gameBegin { get; set; } = false;



        #region Constructor
        public ReplacingBooks()
        {

            // display instructions to the user
            MessageBox.Show(null,
                " For this game we are going to SORT IN ASCENDING ORDER (Smallest to Biggest)\n" +
                "----------------------------------------------------------\n" +
                "To start the game, \n\n" +
                "1. Click on any Call number (eg. 222.97 JAM) \n" +
                "   and drag it over to the box that's empty.\n\n" +
                "2. Once the first call number is entered, the timer will begin and\n" +
                "   the game will continue, until all the numbers have been moved.\n" +
                "   The the game will then come to an end.\n\n" +
                "Remember, you're working against the timer.\n\n" +
                "-----------------------------------------------------\n" +
                "GOODLUCK!", "Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InitializeComponent();
            LoadCallNos();

        }
        #endregion



        #region Loading Call Numbers
        public void LoadCallNos()
        {

            //Clear the component
            listBoxRand.Items.Clear();


            //Shuffle the list and store
            ReplacingBooksLogic r = new ReplacingBooksLogic();
            sortedList = r.GenerateCallNos();
            shuffledList = r.ShuffleList(sortedList);

            //Populate the list
            foreach (var callNo in shuffledList)
            {
                listBoxRand.Items.Add(callNo);
            }

        }
        #endregion



        #region Drag and Drop 
        private void ListBoxRand_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                listBoxSorted.DoDragDrop(listBoxRand.SelectedItem.ToString(), DragDropEffects.Copy);
            }
            catch (System.NullReferenceException ex)
            {
                MessageBox.Show("Please select a call number from the list");
                throw ex;
            }

            if (StartGame())
            {
                StartTimer();
                gameBegin = false;
            }

            if (EndGame())
            {


                // get the data of the users from the list box
                userInputList = listBoxSorted.Items.Cast<String>().ToList();

                bool isCorrectAnswer = userInputList.SequenceEqual(sortedList);

                if (isCorrectAnswer)
                {
                    // save the score 
                    Univ.Points = ScoreSystem.CalculateScore(Convert.ToInt32(timer.TimeLeft.Seconds));

                    Univ.UpdateUserControl = true;

                    // show user details and score
                    Scores scoreD = new Scores("Congratulations! You Solved Correctly 👑 ");
                    this.Hide();
                    scoreD.Show();
                }
                else
                {
                    // incorrect sorting
                    Univ.Points = 0;
                    Univ.BonusPoints = 0;

                    Univ.UpdateUserControl = true;

                    // show user details and score
                    Scores scoreD = new Scores("Unlucky! You Solved Incorrectly 😢 ");
                    this.Hide();
                    scoreD.Show();

                }
            }
        }

        private void listBoxSorted_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listboxSorted_DragDrop(object sender, DragEventArgs e)
        {
            listBoxSorted.Items.Add(e.Data.GetData(DataFormats.Text));
            listBoxRand.Items.Remove(e.Data.GetData(DataFormats.Text));

            // initialise game mode
            Univ.Game1 = true;
            Univ.Game2 = false;
            Univ.Game3 = false;

        }
        #endregion


        private void listBoxRand_DragLeave(object sender, EventArgs e)
        {

        }


        #region Start Game
        public bool StartGame()
        {
            if (listBoxSorted.Items.Count > 0 || listBoxRand.Items.Count < 10)
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }
        #endregion


        #region Start Timer
        public void StartTimer()
        {
            //set time dependent on difficulty 
            timer.SetTime(0, Univ.CountdownTime);

            timer.Start();

            //update label text
            timer.TimeChanged += () => lblTimer2.Text = timer.TimeLeftMsStr;

            //timer step. By default is 1 second
            timer.StepMs = 77;
        }
        #endregion


        #region End Game
        public bool EndGame()
        {
            if ((listBoxSorted.Items.Count.Equals(10) || listBoxRand.Items.Count.Equals(0)))
            {
                timer.Pause();
                lblTimer2.Text = timer.TimeLeftStr;

                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion



        #region Form Load
        private void ReplacingBooks_Load(object sender, EventArgs e)
        {
            // set time on ui
            lblTimer2.Text = Univ.CountdownTime.ToString();
        }
        #endregion



        #region Form Closed
        private void ReplacingBooks_FormClosed(object sender, FormClosedEventArgs e)
        {
            // navigate back
            this.Hide();
            DifficultyLevel difficultyL = new DifficultyLevel();
            difficultyL.Show();
        }
        #endregion


        #region Button Up Click
        private void btnUp_Click(object sender, EventArgs e)
        {
            // declare variables
            string selected = null;
            int index = 0;

            // error handling
            try
            {
                index = listBoxSorted.SelectedIndex;

                // error handling
                if (listBoxSorted.SelectedItem != null)
                {
                    selected = listBoxSorted.SelectedItem.ToString();

                    // moves the selected item up
                    if (index > 0)
                    {
                        listBoxSorted.Items.RemoveAt(index);
                        listBoxSorted.Items.Insert(index - 1, selected);
                        listBoxSorted.SetSelected(index - 1, true);
                    }
                }
                else { MessageBox.Show("Please select an item to move "); }
            }
            catch (System.NullReferenceException) { MessageBox.Show("Please select an item to move "); }
        }
        #endregion



        #region Button Down Click
        private void btnDown_Click(object sender, EventArgs e)
        {
            // decalre variables
            string selected = null;
            int index = 0;

            // error handling 
            try
            {
                index = listBoxSorted.SelectedIndex;

                // error handling
                if (listBoxSorted.SelectedItem != null)
                {
                    selected = listBoxSorted.SelectedItem.ToString();

                    // moves the selected item down
                    if (index < listBoxSorted.Items.Count - 1)
                    {
                        listBoxSorted.Items.RemoveAt(index);
                        listBoxSorted.Items.Insert(index + 1, selected);
                        listBoxSorted.SetSelected(index + 1, true);
                    }
                }
                else
                { MessageBox.Show("Please select an item to move "); }

            }
            catch (System.NullReferenceException) { throw; }
        }
        #endregion



        #region Mouse Hover
        private void ReplacingBooks_MouseHover(object sender, EventArgs e)
        {
            // check if the game has been completed
            if (Convert.ToInt32(timer.TimeLeft.Seconds) == 0 && listBoxRand.Items.Count > 0)
            {

                // incorrect sorting
                Univ.Points = 0;
                Univ.BonusPoints = 0;

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

