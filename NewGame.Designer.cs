namespace Tennis_App
{
    partial class NewGame
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
            components = new System.ComponentModel.Container();
            labelNewGame = new Label();
            labelFirstPlayerName = new Label();
            labelSecondPlayerName = new Label();
            labelFirstPlayerPoints = new Label();
            labelSecondPlayerPoints = new Label();
            buttonSaveGame = new Button();
            textBoxFirstPlayerName = new TextBox();
            textBoxSecondPlayerName = new TextBox();
            numericUpDownSecondPlayerPoints = new NumericUpDown();
            numericUpDownFirstPlayerPoints = new NumericUpDown();
            labelVs = new Label();
            firstPlayerNameErrorProvider = new ErrorProvider(components);
            secondPlayerNameErrorProvider = new ErrorProvider(components);
            labelErrorMessageFirstNameTextBox = new Label();
            labelErrorMessageSecondNameTextBox = new Label();
            labelSameNamesErrorMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSecondPlayerPoints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFirstPlayerPoints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)firstPlayerNameErrorProvider).BeginInit();
            ((System.ComponentModel.ISupportInitialize)secondPlayerNameErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // labelNewGame
            // 
            labelNewGame.AutoSize = true;
            labelNewGame.Font = new Font("Segoe UI", 29F);
            labelNewGame.Location = new Point(265, 12);
            labelNewGame.Name = "labelNewGame";
            labelNewGame.Size = new Size(266, 66);
            labelNewGame.TabIndex = 0;
            labelNewGame.Text = "New Game";
            labelNewGame.TextAlign = ContentAlignment.TopCenter;
            labelNewGame.Click += label1_Click;
            // 
            // labelFirstPlayerName
            // 
            labelFirstPlayerName.AutoSize = true;
            labelFirstPlayerName.Font = new Font("Segoe UI", 13F);
            labelFirstPlayerName.Location = new Point(87, 108);
            labelFirstPlayerName.Name = "labelFirstPlayerName";
            labelFirstPlayerName.Size = new Size(118, 30);
            labelFirstPlayerName.TabIndex = 1;
            labelFirstPlayerName.Text = "First Player";
            // 
            // labelSecondPlayerName
            // 
            labelSecondPlayerName.AutoSize = true;
            labelSecondPlayerName.Font = new Font("Segoe UI", 13F);
            labelSecondPlayerName.Location = new Point(467, 108);
            labelSecondPlayerName.Name = "labelSecondPlayerName";
            labelSecondPlayerName.Size = new Size(150, 30);
            labelSecondPlayerName.TabIndex = 2;
            labelSecondPlayerName.Text = "Second Player";
            // 
            // labelFirstPlayerPoints
            // 
            labelFirstPlayerPoints.AutoSize = true;
            labelFirstPlayerPoints.Font = new Font("Segoe UI", 13F);
            labelFirstPlayerPoints.Location = new Point(129, 212);
            labelFirstPlayerPoints.Name = "labelFirstPlayerPoints";
            labelFirstPlayerPoints.Size = new Size(70, 30);
            labelFirstPlayerPoints.TabIndex = 3;
            labelFirstPlayerPoints.Text = "Points";
            // 
            // labelSecondPlayerPoints
            // 
            labelSecondPlayerPoints.AutoSize = true;
            labelSecondPlayerPoints.Font = new Font("Segoe UI", 13F);
            labelSecondPlayerPoints.Location = new Point(550, 212);
            labelSecondPlayerPoints.Name = "labelSecondPlayerPoints";
            labelSecondPlayerPoints.Size = new Size(70, 30);
            labelSecondPlayerPoints.TabIndex = 4;
            labelSecondPlayerPoints.Text = "Points";
            // 
            // buttonSaveGame
            // 
            buttonSaveGame.BackColor = Color.FromArgb(128, 128, 255);
            buttonSaveGame.Font = new Font("Segoe UI", 13F);
            buttonSaveGame.ForeColor = SystemColors.ButtonFace;
            buttonSaveGame.Location = new Point(289, 365);
            buttonSaveGame.Name = "buttonSaveGame";
            buttonSaveGame.Size = new Size(184, 39);
            buttonSaveGame.TabIndex = 5;
            buttonSaveGame.Text = "Save";
            buttonSaveGame.UseVisualStyleBackColor = false;
            buttonSaveGame.Click += ButtonSaveGameClick;
            buttonSaveGame.MouseClick += ButtonSaveGameClick;
            // 
            // textBoxFirstPlayerName
            // 
            textBoxFirstPlayerName.BackColor = Color.FromArgb(255, 128, 0);
            textBoxFirstPlayerName.Location = new Point(91, 155);
            textBoxFirstPlayerName.Name = "textBoxFirstPlayerName";
            textBoxFirstPlayerName.Size = new Size(234, 27);
            textBoxFirstPlayerName.TabIndex = 6;
            textBoxFirstPlayerName.Validating += ValidatePlayerName;
            // 
            // textBoxSecondPlayerName
            // 
            textBoxSecondPlayerName.BackColor = Color.FromArgb(255, 128, 0);
            textBoxSecondPlayerName.Location = new Point(471, 155);
            textBoxSecondPlayerName.Name = "textBoxSecondPlayerName";
            textBoxSecondPlayerName.Size = new Size(239, 27);
            textBoxSecondPlayerName.TabIndex = 7;
            textBoxSecondPlayerName.Validating += ValidatePlayerName;
            // 
            // numericUpDownSecondPlayerPoints
            // 
            numericUpDownSecondPlayerPoints.BackColor = Color.FromArgb(255, 128, 0);
            numericUpDownSecondPlayerPoints.Location = new Point(560, 279);
            numericUpDownSecondPlayerPoints.Name = "numericUpDownSecondPlayerPoints";
            numericUpDownSecondPlayerPoints.Size = new Size(48, 27);
            numericUpDownSecondPlayerPoints.TabIndex = 1;
            // 
            // numericUpDownFirstPlayerPoints
            // 
            numericUpDownFirstPlayerPoints.BackColor = Color.FromArgb(255, 128, 0);
            numericUpDownFirstPlayerPoints.Location = new Point(141, 279);
            numericUpDownFirstPlayerPoints.Name = "numericUpDownFirstPlayerPoints";
            numericUpDownFirstPlayerPoints.Size = new Size(46, 27);
            numericUpDownFirstPlayerPoints.TabIndex = 1;
            // 
            // labelVs
            // 
            labelVs.AutoSize = true;
            labelVs.Font = new Font("Vivaldi", 30F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelVs.Location = new Point(313, 266);
            labelVs.Name = "labelVs";
            labelVs.Size = new Size(143, 59);
            labelVs.TabIndex = 8;
            labelVs.Text = "VS";
            labelVs.Click += labelVs_Click;
            // 
            // firstPlayerNameErrorProvider
            // 
            firstPlayerNameErrorProvider.ContainerControl = this;
            // 
            // secondPlayerNameErrorProvider
            // 
            secondPlayerNameErrorProvider.ContainerControl = this;
            // 
            // labelErrorMessageFirstNameTextBox
            // 
            labelErrorMessageFirstNameTextBox.AutoSize = true;
            labelErrorMessageFirstNameTextBox.ForeColor = Color.Red;
            labelErrorMessageFirstNameTextBox.Location = new Point(61, 189);
            labelErrorMessageFirstNameTextBox.Name = "labelErrorMessageFirstNameTextBox";
            labelErrorMessageFirstNameTextBox.Size = new Size(0, 20);
            labelErrorMessageFirstNameTextBox.TabIndex = 9;
            // 
            // labelErrorMessageSecondNameTextBox
            // 
            labelErrorMessageSecondNameTextBox.AutoSize = true;
            labelErrorMessageSecondNameTextBox.Location = new Point(471, 189);
            labelErrorMessageSecondNameTextBox.Name = "labelErrorMessageSecondNameTextBox";
            labelErrorMessageSecondNameTextBox.Size = new Size(0, 20);
            labelErrorMessageSecondNameTextBox.TabIndex = 10;
            // 
            // labelSameNamesErrorMessage
            // 
            labelSameNamesErrorMessage.AutoSize = true;
            labelSameNamesErrorMessage.ForeColor = Color.Red;
            labelSameNamesErrorMessage.Location = new Point(265, 212);
            labelSameNamesErrorMessage.Name = "labelSameNamesErrorMessage";
            labelSameNamesErrorMessage.Size = new Size(0, 20);
            labelSameNamesErrorMessage.TabIndex = 11;
            // 
            // NewGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(800, 451);
            Controls.Add(labelSameNamesErrorMessage);
            Controls.Add(labelErrorMessageSecondNameTextBox);
            Controls.Add(labelErrorMessageFirstNameTextBox);
            Controls.Add(labelVs);
            Controls.Add(numericUpDownFirstPlayerPoints);
            Controls.Add(numericUpDownSecondPlayerPoints);
            Controls.Add(textBoxSecondPlayerName);
            Controls.Add(textBoxFirstPlayerName);
            Controls.Add(buttonSaveGame);
            Controls.Add(labelSecondPlayerPoints);
            Controls.Add(labelFirstPlayerPoints);
            Controls.Add(labelSecondPlayerName);
            Controls.Add(labelFirstPlayerName);
            Controls.Add(labelNewGame);
            Name = "NewGame";
            Text = "NewGameForm";
            Load += NewGameForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownSecondPlayerPoints).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFirstPlayerPoints).EndInit();
            ((System.ComponentModel.ISupportInitialize)firstPlayerNameErrorProvider).EndInit();
            ((System.ComponentModel.ISupportInitialize)secondPlayerNameErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNewGame;
        private Label labelFirstPlayerName;
        private Label labelSecondPlayerName;
        private Label labelFirstPlayerPoints;
        private Label labelSecondPlayerPoints;
        private Button buttonSaveGame;
        private TextBox textBoxFirstPlayerName;
        private TextBox textBoxSecondPlayerName;
        private NumericUpDown numericUpDownSecondPlayerPoints;
        private NumericUpDown numericUpDownFirstPlayerPoints;
        private Label labelVs;
        private ErrorProvider firstPlayerNameErrorProvider;
        private ErrorProvider secondPlayerNameErrorProvider;
        private Label labelErrorMessageSecondNameTextBox;
        private Label labelErrorMessageFirstNameTextBox;
        private Label labelSameNamesErrorMessage;
    }
}