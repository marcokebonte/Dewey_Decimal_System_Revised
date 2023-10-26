using Dewey_Decimal_System_Library.JSON;
using Dewey_Decimal_System_Library.Model;
using Dewey_Decimal_System_Library.Other;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dewey_Decimal_System_Revised.Gamification
{
    public partial class Leaderboard : Form
    {
        public Leaderboard()
        {
            InitializeComponent();
        }




        #region Form Load
        private void Leaderboard_Load(object sender, EventArgs e)
        {

            // check if the json file exists
            if (!JsonFileWorker.FileExists(JsonFileWorker.ReplacingBooksFile))
            {
                // create the json file
                JsonFileWorker.CreateJsonFile(JsonFileWorker.ReplacingBooksFile);
            }

            // check if the json file exists
            if (!JsonFileWorker.FileExists(JsonFileWorker.IdentifyingAreasFile))
            {
                // create the json file
                JsonFileWorker.CreateJsonFile(JsonFileWorker.IdentifyingAreasFile);
            }

            //// check if the json file exists
            //if (!JsonFileWorker.FileExists(JsonFileWorker.TreeHighScoreFile))
            //{
            //    // create the json file
            //    JsonFileWorker.CreateCallNumFile();
            //    JsonFileWorker.CreateJsonFile(JsonFileWorker.TreeHighScoreFile);
            //}

            Console.WriteLine(Univ.Game1);
            Console.WriteLine(Univ.Game2);
            Console.WriteLine(Univ.Game3);

            if (Univ.Game1)
            {
                //lvlLeaderboard.Items.Clear();

                // retrieve data from json file
                List<HighScoreModel> lstModelHightScore = JsonFileWorker.GetAllScores(JsonFileWorker.ReplacingBooksFile);

                // populate list view
                lstModelHightScore.OrderByDescending(x => x.Score)
                    .ToList()
                    .ForEach(x => lvlLeaderboard.Items.Add(new ListViewItem(new string[] { x.Username, x.Score.ToString() })));

                Univ.Game1 = false;
            }
            else if (Univ.Game2)
            {
                lvlLeaderboard.Items.Clear();

                // retrieve data from json file
                List<HighScoreModel> lstModelHightScore = JsonFileWorker.GetAllScores(JsonFileWorker.IdentifyingAreasFile);

                // populate list view
                lstModelHightScore.OrderByDescending(x => x.Score)
                    .ToList()
                    .ForEach(x => lvlLeaderboard.Items.Add(new ListViewItem(new string[] { x.Username, x.Score.ToString() })));

                Univ.Game2 = false;
            }
            else if (Univ.Game3)
            {
                //lvlLeaderboard.Items.Clear();

                //// retrieve data from json file
                //List<HighScoreModel> lstModelHightScore = JsonFileWorker.GetAllScores(JsonFileWorker.TreeHighScoreFile);

                //// populate list view
                //lstModelHightScore.OrderByDescending(x => x.Score)
                //    .ToList()
                //    .ForEach(x => lvlLeaderboard.Items.Add(new ListViewItem(new string[] { x.Username, x.Score.ToString() })));

                //Univ.Game3 = false;
            }
        }
        #endregion


        #region Form Close
        private void Leaderboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            // navigate back to the homescreen
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        #endregion 
    }
}
    
