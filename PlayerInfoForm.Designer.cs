namespace Tennis_Score_App
{
    partial class PlayerInfoForm
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
            PlayerName = new Label();
            Victories = new Label();
            label3 = new Label();
            label4 = new Label();
            listViewVictories = new ListView();
            CompetitorHeader = new ColumnHeader();
            ScoreHeader = new ColumnHeader();
            listViewLosses = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            listViewDraw = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            SuspendLayout();
            // 
            // PlayerName
            // 
            PlayerName.AutoSize = true;
            PlayerName.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            PlayerName.Location = new Point(270, 50);
            PlayerName.Name = "PlayerName";
            PlayerName.Size = new Size(257, 54);
            PlayerName.TabIndex = 0;
            PlayerName.Text = "Player Name";
            // 
            // Victories
            // 
            Victories.AutoSize = true;
            Victories.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Victories.Location = new Point(70, 160);
            Victories.Name = "Victories";
            Victories.Size = new Size(102, 31);
            Victories.TabIndex = 1;
            Victories.Text = "Victories";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(356, 160);
            label3.Name = "label3";
            label3.Size = new Size(80, 31);
            label3.TabIndex = 2;
            label3.Text = "Losses";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(647, 160);
            label4.Name = "label4";
            label4.Size = new Size(67, 31);
            label4.TabIndex = 3;
            label4.Text = "Draw";
            // 
            // listViewVictories
            // 
            listViewVictories.BackColor = Color.FromArgb(255, 128, 0);
            listViewVictories.Columns.AddRange(new ColumnHeader[] { CompetitorHeader, ScoreHeader });
            listViewVictories.Location = new Point(23, 238);
            listViewVictories.Name = "listViewVictories";
            listViewVictories.Size = new Size(238, 152);
            listViewVictories.TabIndex = 4;
            listViewVictories.UseCompatibleStateImageBehavior = false;
            listViewVictories.View = View.Details;
            // 
            // CompetitorHeader
            // 
            CompetitorHeader.Text = "Competitor";
            CompetitorHeader.Width = 110;
            // 
            // ScoreHeader
            // 
            ScoreHeader.Text = "Score";
            ScoreHeader.Width = 120;
            // 
            // listViewLosses
            // 
            listViewLosses.BackColor = Color.FromArgb(255, 128, 0);
            listViewLosses.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listViewLosses.Location = new Point(287, 238);
            listViewLosses.Name = "listViewLosses";
            listViewLosses.Size = new Size(238, 152);
            listViewLosses.TabIndex = 5;
            listViewLosses.UseCompatibleStateImageBehavior = false;
            listViewLosses.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Competitor";
            columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Score";
            columnHeader2.Width = 120;
            // 
            // listViewDraw
            // 
            listViewDraw.BackColor = Color.FromArgb(255, 128, 0);
            listViewDraw.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4 });
            listViewDraw.Location = new Point(550, 238);
            listViewDraw.Name = "listViewDraw";
            listViewDraw.Size = new Size(238, 152);
            listViewDraw.TabIndex = 6;
            listViewDraw.UseCompatibleStateImageBehavior = false;
            listViewDraw.View = View.Details;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Competitor";
            columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Score";
            columnHeader4.Width = 120;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(listViewDraw);
            Controls.Add(listViewLosses);
            Controls.Add(listViewVictories);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Victories);
            Controls.Add(PlayerName);
            Name = "Form3";
            Text = "PlayerInfoForm";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PlayerName;
        private Label Victories;
        private Label label3;
        private Label label4;
        private ListView listViewVictories;
        private ColumnHeader CompetitorHeader;
        private ColumnHeader ScoreHeader;
        private ListView listViewLosses;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ListView listViewDraw;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}