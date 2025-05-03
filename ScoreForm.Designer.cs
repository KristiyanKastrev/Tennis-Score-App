using static System.Windows.Forms.ListViewItem;

namespace TennisProjectApp
{
    partial class ScoreForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        private void ViewProfileButtonClick(object sender, EventArgs e)
        {
            ListViewItem selectedRow = this.listViewRanking.SelectedItems[0];
            ListViewSubItem playerNameCell = selectedRow.SubItems[0];
            string playerName = playerNameCell.Text;

            using (PlayerInfoForm playerInfoForm = new PlayerInfoForm(playerName, GetPlayerGames(playerName), this))
            {
                playerInfoForm.ShowDialog();
            }
        }
        private Dictionary<(string, int), List<(string, int)>> GetPlayerGames(string playerName)
    => games.Where(x => x.Key.Item1 == playerName || x.Value.Any(y => y.Item1 == playerName))
            .ToDictionary(x => x.Key, x => x.Value.Where(y => y.Item1 == playerName || x.Key.Item1 == playerName)
            .ToList());

#region Windows Form Designer generated code

/// <summary>
///  Required method for Designer support - do not modify
///  the contents of this method with the code editor.
/// </summary>
private void InitializeComponent()
        {
            labelTennisScore = new Label();
            labelRanking = new Label();
            listViewRanking = new ListView();
            playerNameColumn = new ColumnHeader();
            scoreColumn = new ColumnHeader();
            label1 = new Label();
            labelClickOnName = new Label();
            buttonAddNewGame = new Button();
            labelLatestGames = new Label();
            listViewLastestGames = new ListView();
            firstPlayerColumn = new ColumnHeader();
            secondPlayerColumn = new ColumnHeader();
            winnerColumn = new ColumnHeader();
            totalScoreColumn = new ColumnHeader();
            SuspendLayout();
            // 
            // labelTennisScore
            // 
            labelTennisScore.AutoSize = true;
            labelTennisScore.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            labelTennisScore.Location = new Point(266, 9);
            labelTennisScore.Name = "labelTennisScore";
            labelTennisScore.Size = new Size(219, 46);
            labelTennisScore.TabIndex = 0;
            labelTennisScore.Text = "Tennis Score";
            // 
            // labelRanking
            // 
            labelRanking.AutoSize = true;
            labelRanking.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelRanking.Location = new Point(27, 73);
            labelRanking.Name = "labelRanking";
            labelRanking.Size = new Size(83, 28);
            labelRanking.TabIndex = 1;
            labelRanking.Text = "Ranking";
            // 
            // listViewRanking
            // 
            listViewRanking.Activation = ItemActivation.OneClick;
            listViewRanking.BackColor = Color.FromArgb(255, 192, 128);
            listViewRanking.Columns.AddRange(new ColumnHeader[] { playerNameColumn, scoreColumn });
            listViewRanking.HoverSelection = true;
            listViewRanking.Location = new Point(27, 104);
            listViewRanking.Name = "listViewRanking";
            listViewRanking.Size = new Size(710, 121);
            listViewRanking.TabIndex = 2;
            listViewRanking.UseCompatibleStateImageBehavior = false;
            listViewRanking.View = View.Details;
            // 
            // playerNameColumn
            // 
            playerNameColumn.Text = "PlayerName";
            playerNameColumn.Width = 350;
            // 
            // scoreColumn
            // 
            scoreColumn.Text = "Score";
            scoreColumn.Width = 350;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(329, 354);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 3;
            // 
            // labelClickOnName
            // 
            labelClickOnName.AutoSize = true;
            labelClickOnName.Location = new Point(27, 228);
            labelClickOnName.Name = "labelClickOnName";
            labelClickOnName.Size = new Size(422, 20);
            labelClickOnName.TabIndex = 4;
            labelClickOnName.Text = "*click on player's name to see information about their matches";
            labelClickOnName.Click += label2_Click;
            // 
            // buttonAddNewGame
            // 
            buttonAddNewGame.Anchor = AnchorStyles.Top;
            buttonAddNewGame.BackColor = Color.FromArgb(128, 128, 255);
            buttonAddNewGame.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddNewGame.ForeColor = SystemColors.ButtonFace;
            buttonAddNewGame.Location = new Point(560, 254);
            buttonAddNewGame.Name = "buttonAddNewGame";
            buttonAddNewGame.Size = new Size(190, 42);
            buttonAddNewGame.TabIndex = 5;
            buttonAddNewGame.Text = "Add New Game";
            buttonAddNewGame.UseVisualStyleBackColor = false;
            // 
            // labelLatestGames
            // 
            labelLatestGames.AutoSize = true;
            labelLatestGames.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelLatestGames.Location = new Point(27, 296);
            labelLatestGames.Name = "labelLatestGames";
            labelLatestGames.Size = new Size(127, 28);
            labelLatestGames.TabIndex = 6;
            labelLatestGames.Text = "Latest Games";
            // 
            // listViewLastestGames
            // 
            listViewLastestGames.BackColor = Color.FromArgb(255, 192, 128);
            listViewLastestGames.Columns.AddRange(new ColumnHeader[] { firstPlayerColumn, secondPlayerColumn, winnerColumn, totalScoreColumn });
            listViewLastestGames.Location = new Point(27, 327);
            listViewLastestGames.Name = "listViewLastestGames";
            listViewLastestGames.Size = new Size(710, 98);
            listViewLastestGames.TabIndex = 7;
            listViewLastestGames.UseCompatibleStateImageBehavior = false;
            listViewLastestGames.View = View.Details;
            // 
            // firstPlayerColumn
            // 
            firstPlayerColumn.Text = "First Player";
            firstPlayerColumn.Width = 280;
            // 
            // secondPlayerColumn
            // 
            secondPlayerColumn.Text = "Second Player";
            secondPlayerColumn.Width = 280;
            // 
            // winnerColumn
            // 
            winnerColumn.Text = "Winner";
            winnerColumn.Width = 90;
            // 
            // totalScoreColumn
            // 
            totalScoreColumn.Text = "Score";
            totalScoreColumn.Width = 55;
            // 
            // ScoreForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(listViewLastestGames);
            Controls.Add(labelLatestGames);
            Controls.Add(buttonAddNewGame);
            Controls.Add(labelClickOnName);
            Controls.Add(label1);
            Controls.Add(listViewRanking);
            Controls.Add(labelRanking);
            Controls.Add(labelTennisScore);
            Name = "ScoreForm";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTennisScore;
        private Label labelRanking;
        private ListView listViewRanking;
        private ColumnHeader playerNameColumn;
        private ColumnHeader scoreColumn;
        private Label label1;
        private Label labelClickOnName;
        private Button buttonAddNewGame;
        private Label labelLatestGames;
        private ListView listViewLastestGames;
        private ColumnHeader firstPlayerColumn;
        private ColumnHeader secondPlayerColumn;
        private ColumnHeader winnerColumn;
        private ColumnHeader totalScoreColumn;
    }
    }
