namespace TennisProjectApp
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
            labelPlayerName = new Label();
            labelVictories = new Label();
            labelLosses = new Label();
            labelDraw = new Label();
            listViewVictories = new ListView();
            listViewLosses = new ListView();
            listViewDraw = new ListView();
            competitorVictories = new ColumnHeader();
            scoreVictories = new ColumnHeader();
            competitorLosses = new ColumnHeader();
            scoreLosses = new ColumnHeader();
            competitorDraw = new ColumnHeader();
            scoreDraw = new ColumnHeader();
            SuspendLayout();
            // 
            // labelPlayerName
            // 
            labelPlayerName.AutoSize = true;
            labelPlayerName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelPlayerName.Location = new Point(261, 9);
            labelPlayerName.Name = "labelPlayerName";
            labelPlayerName.Size = new Size(196, 41);
            labelPlayerName.TabIndex = 0;
            labelPlayerName.Text = "Player Name";
            // 
            // labelVictories
            // 
            labelVictories.AutoSize = true;
            labelVictories.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelVictories.Location = new Point(75, 123);
            labelVictories.Name = "labelVictories";
            labelVictories.Size = new Size(90, 28);
            labelVictories.TabIndex = 1;
            labelVictories.Text = "Victories";
            // 
            // labelLosses
            // 
            labelLosses.AutoSize = true;
            labelLosses.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelLosses.Location = new Point(363, 123);
            labelLosses.Name = "labelLosses";
            labelLosses.Size = new Size(72, 28);
            labelLosses.TabIndex = 2;
            labelLosses.Text = "Losses";
            // 
            // labelDraw
            // 
            labelDraw.AutoSize = true;
            labelDraw.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelDraw.Location = new Point(632, 123);
            labelDraw.Name = "labelDraw";
            labelDraw.Size = new Size(58, 28);
            labelDraw.TabIndex = 3;
            labelDraw.Text = "Draw";
            // 
            // listViewVictories
            // 
            listViewVictories.BackColor = Color.FromArgb(255, 192, 128);
            listViewVictories.Columns.AddRange(new ColumnHeader[] { competitorVictories, scoreVictories });
            listViewVictories.Location = new Point(36, 185);
            listViewVictories.Name = "listViewVictories";
            listViewVictories.Size = new Size(207, 121);
            listViewVictories.TabIndex = 4;
            listViewVictories.UseCompatibleStateImageBehavior = false;
            listViewVictories.View = View.Details;
            listViewVictories.SelectedIndexChanged += listViewVictories_SelectedIndexChanged;
            // 
            // listViewLosses
            // 
            listViewLosses.BackColor = Color.FromArgb(255, 192, 128);
            listViewLosses.Columns.AddRange(new ColumnHeader[] { competitorLosses, scoreLosses });
            listViewLosses.Location = new Point(306, 185);
            listViewLosses.Name = "listViewLosses";
            listViewLosses.Size = new Size(204, 121);
            listViewLosses.TabIndex = 5;
            listViewLosses.UseCompatibleStateImageBehavior = false;
            listViewLosses.View = View.Details;
            // 
            // listViewDraw
            // 
            listViewDraw.BackColor = Color.FromArgb(255, 192, 128);
            listViewDraw.Columns.AddRange(new ColumnHeader[] { competitorDraw, scoreDraw });
            listViewDraw.Location = new Point(567, 185);
            listViewDraw.Name = "listViewDraw";
            listViewDraw.Size = new Size(205, 121);
            listViewDraw.TabIndex = 6;
            listViewDraw.UseCompatibleStateImageBehavior = false;
            listViewDraw.View = View.Details;
            // 
            // competitorVictories
            // 
            competitorVictories.Text = "Competitor";
            competitorVictories.Width = 140;
            // 
            // scoreVictories
            // 
            scoreVictories.Text = "Score";
            // 
            // competitorLosses
            // 
            competitorLosses.Text = "Competitor";
            competitorLosses.Width = 140;
            // 
            // scoreLosses
            // 
            scoreLosses.Text = "Score";
            // 
            // competitorDraw
            // 
            competitorDraw.Text = "Competitor";
            competitorDraw.Width = 140;
            // 
            // scoreDraw
            // 
            scoreDraw.Text = "Score";
            // 
            // PlayerInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(listViewDraw);
            Controls.Add(listViewLosses);
            Controls.Add(listViewVictories);
            Controls.Add(labelDraw);
            Controls.Add(labelLosses);
            Controls.Add(labelVictories);
            Controls.Add(labelPlayerName);
            Name = "PlayerInfoForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPlayerName;
        private Label labelVictories;
        private Label labelLosses;
        private Label labelDraw;
        private ListView listViewVictories;
        private ListView listViewLosses;
        private ListView listViewDraw;
        private ColumnHeader competitorVictories;
        private ColumnHeader scoreVictories;
        private ColumnHeader competitorLosses;
        private ColumnHeader scoreLosses;
        private ColumnHeader competitorDraw;
        private ColumnHeader scoreDraw;
    }
}