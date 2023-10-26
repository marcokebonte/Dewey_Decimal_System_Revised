using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dewey_Decimal_System.Games;
using Dewey_Decimal_System_Library.Model;
using Dewey_Decimal_System_Library.Other;
using System;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Dewey_Decimal_System_Revised.Gamification
{
    public partial class Scores : Form
    {

        #region Constructor
        public Scores(string info)
        {
            InitializeComponent();


            lblUserMessage.Text = info;
        }
        #endregion



        #region Form Load
        private void ScoreAndDetails_Load(object sender, EventArgs e)
        {
            RefreshUI();

            if (Univ.UpdateUserControl)
            {
                // update ui values
                textBoxYS.Text = Univ.Points.ToString();
                textBoxBP.Text = Univ.BonusPoints.ToString();
                textBoxTotalScore.Text = (Univ.BonusPoints + Univ.Points).ToString();

            }
        }
        #endregion




        #region Refresh UI
        public void RefreshUI()
        {
            // clear componenets
            textBoxUsername.Clear();
            textBoxYS.Clear();
            textBoxTotalScore.Clear();
            textBoxBP.Clear();
        }
        #endregion



        #region Play Again 
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            if (Univ.Game1)
            {
                // Game 1
                ReplacingBooks sortingCall = new ReplacingBooks();
                this.Hide();
                sortingCall.ShowDialog();

            }
            else if (Univ.Game2)
            {

                //Game 2

            }
            else if (Univ.Game3)
            {

                //Game 3
            }

        }

        #endregion





        #region Save Score
        //This method uses embedded text files to serialize user scores
        private void btnSaveScore_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxUsername.Text))
            {
                MessageBox.Show("Please enter a valid name", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Create a game identifier based on your game mode (e.g., "Game1")
                string gameIdentifier;
                if (Univ.Game1)
                {
                    gameIdentifier = "Game1";
                }
                else if (Univ.Game2)
                {
                    gameIdentifier = "Game2";
                }
                else if (Univ.Game3)
                {
                    gameIdentifier = "Game3";
                }
                else
                {
                    // Set a default game identifier if needed
                    gameIdentifier = "Default";
                }

                // Load existing high scores for the selected game mode
                List<HighScoreModel> existingHighScores = LoadHighScores(gameIdentifier);

                // Create a new high score entry
                HighScoreModel modelHighScore = new HighScoreModel
                {
                    Username = textBoxUsername.Text,
                    Score = Univ.Points + Univ.BonusPoints
                };

                // Add the new high score to the existing list
                existingHighScores.Add(modelHighScore);

                // Sort and limit the high scores list if needed
                existingHighScores = existingHighScores.OrderByDescending(score => score.Score).Take(10).ToList();

                // Save the updated high scores for the selected game mode
                SaveHighScoresToTextResource(existingHighScores, gameIdentifier);

                // Message to the user
                MessageBox.Show($"{textBoxUsername.Text} score of : {textBoxTotalScore.Text} has been saved successfully", "Score Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Navigate back to the home screen
                RefreshUI();

                // Back to the home page
                Home home = new Home();
                this.Hide();
                home.Show();
            }
        }
        #endregion



        #region Save Score ext - Serialization
        // Define a dictionary to store high scores for different games
        private Dictionary<string, List<HighScoreModel>> highScoresByGame = new Dictionary<string, List<HighScoreModel>>();

        #region Save High Scores to Text Resource
        private void SaveHighScoresToTextResource(List<HighScoreModel> highScores, string gameIdentifier)
        {
            // Add or update high scores in the dictionary
            highScoresByGame[gameIdentifier] = highScores;

            // Serialize and save the entire dictionary to text files
            SaveHighScoresDictionaryToFiles();
        }
        #endregion


        #region Save High Scores Dictionary
        private void SaveHighScoresDictionaryToFiles()
        {
            // Loop through the dictionary and save each game's high scores to a separate text file
            foreach (var game in highScoresByGame)
            {
                string gameIdentifier = game.Key;
                List<HighScoreModel> highScores = game.Value;

                // Serialize the high scores to a text format (e.g., JSON)
                string serializedData = JsonConvert.SerializeObject(highScores);

                // Define the file path based on the game identifier
                string filePath = $"{gameIdentifier}HighScores.txt";

                // Ensure that the directory exists before writing the file
                string directoryPath = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                // Write data to the file
                File.WriteAllText(filePath, serializedData);
            }
        }
        #endregion

        #region Load High Scores from Text Resource
        private List<HighScoreModel> LoadHighScores(string gameIdentifier)
        {
            // Check if the game has high scores in the dictionary
            if (highScoresByGame.ContainsKey(gameIdentifier))
            {
                return highScoresByGame[gameIdentifier];
            }

            // If not found in the dictionary, attempt to load from a text file
            string filePath = $"{gameIdentifier}HighScores.txt";

            if (File.Exists(filePath))
            {
                string serializedData = File.ReadAllText(filePath);

                if (!string.IsNullOrWhiteSpace(serializedData))
                {
                    return JsonConvert.DeserializeObject<List<HighScoreModel>>(serializedData);
                }
            }

            // Handle cases where high scores are not found
            return new List<HighScoreModel>();
        }
        #endregion


        #endregion




        #region Form Close Method
        private void Scores_FormClosed(object sender, FormClosedEventArgs e)
        {
            // navigate back to the homescreen
            this.Hide();
            Home home = new Home();
            home.Show();

        }


        #endregion


    }



}





    

