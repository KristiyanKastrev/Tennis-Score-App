namespace TennisProjectApp
{
    public partial class ScoreForm : Form
    {
        public ScoreForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        

        private void OnLoad(object sender, EventArgs e)
        {
            FillRankingListView();
            FillLatestGamesListView();
        }
        private void FillRankingListView()
        {
            this.listViewRanking.Items.Clear();

            foreach (var player in playersWithPoints.OrderByDescending(p => p.Value))
            {
                string playerName = player.Key;
                string playerPoints = player.Value.ToString();

                ListViewItem rollInRankingListView = new();
                rollInRankingListView.SubItems[0].Text = playerName;
                rollInRankingListView.SubItems.Add(playerPoints);

                this.listViewRanking.Items.Add(rollInRankingListView);
            }
        }

        private static Dictionary<string, int> playersWithPoints = new()
        {
          { "R. Federer", 4 },
          { "G. Dimitrov", 5 },
          { "R. Nadal", 5 }
        };

        private void FillLatestGamesListView()
        {
            this.listViewLastestGames.Items.Clear();

            foreach (var game in games.Reverse())
            {
                foreach (var item in game.Value)
                {
                    FillListView((game.Key, item.Item2), item);
                }
            }
        }

        private void FillListView((string, int) firstPlayer, (string, int) secondPlayer)
        {
            string winner = GetWinner(firstPlayer, secondPlayer);

            ListViewItem rollInLastestGamesListView = new ListViewItem();

            rollInLastestGamesListView.SubItems[0].Text = firstPlayer.Item1;
            rollInLastestGamesListView.SubItems.Add(secondPlayer.Item1);
            rollInLastestGamesListView.SubItems.Add(winner);
            rollInLastestGamesListView.SubItems.Add(firstPlayer.Item2 > secondPlayer.Item2 ? firstPlayer.Item2.ToString() : secondPlayer.Item2.ToString());

            this.listViewLastestGames.Items.Add(rollInLastestGamesListView);
        }
        private string GetWinner((string, int) firstPlayer, (string, int) secondPlayer)
        {
            if (firstPlayer.Item2 > secondPlayer.Item2)
            {
                return firstPlayer.Item1;
            }
            else if (firstPlayer.Item2 < secondPlayer.Item2)
            {
                return secondPlayer.Item1;
            }

            return "Draw";
        }

        private static Dictionary<string, List<(string, int)>> games = new()
        {
        { "G. Dimitrov", new List<(string, int)>{ ("R. Nadal", 2) } },
        { "R. Nadal", new List<(string, int)>{ ("R. Federer", 1) } },
        { "G. Dimitrov", new List<(string, int)>{ ("R. Federer", 3) } }
        };

        private void AddNewGameButtonClick(object sender, EventArgs e)
        {
            using (NewGameForm newGameForm = new NewGameForm())
            {
                if (newGameForm.ShowDialog() == DialogResult.OK)
                {
                    AddNewGame(newGameForm.FirstPlayer, newGameForm.SecondPlayer);
                }
            }
        }
        private void AddNewGame((string, int) firstPlayer, (string, int) secondPlayer)
        {
            FillGamesData(firstPlayer, secondPlayer);

            FillPlayerWithPoints(firstPlayer);
            FillPlayerWithPoints(secondPlayer);

            FillRankingListView();
            FillLatestGamesListView();
        }
        private void FillGamesData((string, int) firstPlayer, (string, int) secondPlayer)
        {
            if (games.ContainsKey(firstPlayer.Item1))
            {
                games[firstPlayer.Item1].Add(secondPlayer);
            }
            else if (games.ContainsKey(secondPlayer.Item1))
            {
                games[secondPlayer.Item1].Add(firstPlayer);
            }
            else
            {
                games.Add(firstPlayer.Item1, new List<(string, int)> { secondPlayer });
            }
        }
        private void FillPlayerWithPoints((string, int) player)
        {
            if (playersWithPoints.ContainsKey(player.Item1))
            {
                playersWithPoints[player.Item1] += player.Item2;
            }
            else
            {
                playersWithPoints.Add(player.Item1, player.Item2);
            }
        }




    }
}
