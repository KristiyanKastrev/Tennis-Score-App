namespace Tennis_App
{
    partial class PlayerIn
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
            labelPlayerName = new Label();
            labelVictories = new Label();
            labelLosses = new Label();
            labelDraw = new Label();
            listViewVictories = new ListView();
            competitorVictories = new ColumnHeader();
            scoreVictories = new ColumnHeader();
            listViewLosses = new ListView();
            competitorLosses = new ColumnHeader();
            scoreLosses = new ColumnHeader();
            listViewDraw = new ListView();
            competitorDraw = new ColumnHeader();
            scoreDraw = new ColumnHeader();
            SuspendLayout();
            // 
            // labelPlayerName
            // 
            labelPlayerName.AutoSize = true;
            labelPlayerName.Font = new Font("Segoe UI", 20F);
            labelPlayerName.Location = new Point(310, 40);
            labelPlayerName.Name = "labelPlayerName";
            labelPlayerName.Size = new Size(208, 46);
            labelPlayerName.TabIndex = 0;
            labelPlayerName.Text = "Player Name";
            labelPlayerName.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelVictories
            // 
            labelVictories.AutoSize = true;
            labelVictories.Font = new Font("Segoe UI", 13F);
            labelVictories.Location = new Point(70, 133);
            labelVictories.Name = "labelVictories";
            labelVictories.Size = new Size(96, 30);
            labelVictories.TabIndex = 1;
            labelVictories.Text = "Victories";
            labelVictories.Click += label1_Click;
            // 
            // labelLosses
            // 
            labelLosses.AutoSize = true;
            labelLosses.Font = new Font("Segoe UI", 13F);
            labelLosses.Location = new Point(365, 133);
            labelLosses.Name = "labelLosses";
            labelLosses.Size = new Size(75, 30);
            labelLosses.TabIndex = 2;
            labelLosses.Text = "Losses";
            // 
            // labelDraw
            // 
            labelDraw.AutoSize = true;
            labelDraw.Font = new Font("Segoe UI", 13F);
            labelDraw.Location = new Point(646, 133);
            labelDraw.Name = "labelDraw";
            labelDraw.Size = new Size(63, 30);
            labelDraw.TabIndex = 3;
            labelDraw.Text = "Draw";
            // 
            // listViewVictories
            // 
            listViewVictories.BackColor = Color.FromArgb(255, 128, 0);
            listViewVictories.Columns.AddRange(new ColumnHeader[] { competitorVictories, scoreVictories });
            listViewVictories.Location = new Point(46, 189);
            listViewVictories.Name = "listViewVictories";
            listViewVictories.Size = new Size(183, 163);
            listViewVictories.TabIndex = 4;
            listViewVictories.UseCompatibleStateImageBehavior = false;
            listViewVictories.View = View.Details;
            // 
            // competitorVictories
            // 
            competitorVictories.Text = "Competitor";
            competitorVictories.Width = 100;
            // 
            // scoreVictories
            // 
            scoreVictories.Text = "Score";
            scoreVictories.Width = 70;
            // 
            // listViewLosses
            // 
            listViewLosses.BackColor = Color.FromArgb(255, 128, 0);
            listViewLosses.Columns.AddRange(new ColumnHeader[] { competitorLosses, scoreLosses });
            listViewLosses.Location = new Point(310, 193);
            listViewLosses.Name = "listViewLosses";
            listViewLosses.Size = new Size(198, 163);
            listViewLosses.TabIndex = 5;
            listViewLosses.UseCompatibleStateImageBehavior = false;
            listViewLosses.View = View.Details;
            // 
            // competitorLosses
            // 
            competitorLosses.Text = "Competitor";
            competitorLosses.Width = 100;
            // 
            // scoreLosses
            // 
            scoreLosses.Text = "Score";
            scoreLosses.Width = 80;
            // 
            // listViewDraw
            // 
            listViewDraw.BackColor = Color.FromArgb(255, 128, 0);
            listViewDraw.Columns.AddRange(new ColumnHeader[] { competitorDraw, scoreDraw });
            listViewDraw.Location = new Point(581, 193);
            listViewDraw.Name = "listViewDraw";
            listViewDraw.Size = new Size(185, 163);
            listViewDraw.TabIndex = 6;
            listViewDraw.UseCompatibleStateImageBehavior = false;
            listViewDraw.View = View.Details;
            // 
            // competitorDraw
            // 
            competitorDraw.Text = "Competitor";
            competitorDraw.Width = 100;
            // 
            // scoreDraw
            // 
            scoreDraw.Text = "Score";
            scoreDraw.Width = 80;
            // 
            // PlayerIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(800, 451);
            Controls.Add(listViewDraw);
            Controls.Add(listViewLosses);
            Controls.Add(listViewVictories);
            Controls.Add(labelDraw);
            Controls.Add(labelLosses);
            Controls.Add(labelVictories);
            Controls.Add(labelPlayerName);
            Name = "PlayerIn";
            Text = "PlayerInfoForm";
            Load += PlayerInfoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPlayerName;
        private Label labelVictories;
        private Label labelLosses;
        private Label labelDraw;
        private ListView listViewVictories;
        private ColumnHeader competitorVictories;
        private ColumnHeader scoreVictories;
        private ListView listViewLosses;
        private ListView listViewDraw;
        private ColumnHeader competitorLosses;
        private ColumnHeader scoreLosses;
        private ColumnHeader competitorDraw;
        private ColumnHeader scoreDraw;
    }
}