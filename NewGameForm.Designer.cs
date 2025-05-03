namespace TennisProjectApp
{
    partial class NewGameForm
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
            textBoxFirstPlayerName = new TextBox();
            textBoxSecondPlayerName = new TextBox();
            labelFirstPlayerPoints = new Label();
            labelSecondPlayerPoints = new Label();
            labelVs = new Label();
            numericUpDownFirstPlayerPoints = new NumericUpDown();
            numericUpDownSecondPlayerPoints = new NumericUpDown();
            buttonSaveGame = new Button();
            errorProvider1 = new ErrorProvider(components);
            Error = new Label();
            Error2 = new Label();
            errorProvider2 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDownFirstPlayerPoints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSecondPlayerPoints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // labelNewGame
            // 
            labelNewGame.AutoSize = true;
            labelNewGame.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelNewGame.Location = new Point(292, 9);
            labelNewGame.Name = "labelNewGame";
            labelNewGame.Size = new Size(157, 38);
            labelNewGame.TabIndex = 0;
            labelNewGame.Text = "New game";
            // 
            // labelFirstPlayerName
            // 
            labelFirstPlayerName.AutoSize = true;
            labelFirstPlayerName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelFirstPlayerName.Location = new Point(21, 89);
            labelFirstPlayerName.Name = "labelFirstPlayerName";
            labelFirstPlayerName.Size = new Size(107, 28);
            labelFirstPlayerName.TabIndex = 1;
            labelFirstPlayerName.Text = "First Player";
            // 
            // labelSecondPlayerName
            // 
            labelSecondPlayerName.AutoSize = true;
            labelSecondPlayerName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSecondPlayerName.Location = new Point(433, 89);
            labelSecondPlayerName.Name = "labelSecondPlayerName";
            labelSecondPlayerName.Size = new Size(135, 28);
            labelSecondPlayerName.TabIndex = 2;
            labelSecondPlayerName.Text = "Second Player";
            // 
            // textBoxFirstPlayerName
            // 
            textBoxFirstPlayerName.BackColor = Color.FromArgb(255, 192, 128);
            textBoxFirstPlayerName.Location = new Point(21, 120);
            textBoxFirstPlayerName.Name = "textBoxFirstPlayerName";
            textBoxFirstPlayerName.Size = new Size(283, 27);
            textBoxFirstPlayerName.TabIndex = 1;
            // 
            // textBoxSecondPlayerName
            // 
            textBoxSecondPlayerName.BackColor = Color.FromArgb(255, 192, 128);
            textBoxSecondPlayerName.Location = new Point(433, 120);
            textBoxSecondPlayerName.Name = "textBoxSecondPlayerName";
            textBoxSecondPlayerName.Size = new Size(326, 27);
            textBoxSecondPlayerName.TabIndex = 2;
            // 
            // labelFirstPlayerPoints
            // 
            labelFirstPlayerPoints.AutoSize = true;
            labelFirstPlayerPoints.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelFirstPlayerPoints.Location = new Point(75, 221);
            labelFirstPlayerPoints.Name = "labelFirstPlayerPoints";
            labelFirstPlayerPoints.Size = new Size(65, 28);
            labelFirstPlayerPoints.TabIndex = 5;
            labelFirstPlayerPoints.Text = "Points";
            // 
            // labelSecondPlayerPoints
            // 
            labelSecondPlayerPoints.AutoSize = true;
            labelSecondPlayerPoints.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSecondPlayerPoints.Location = new Point(609, 222);
            labelSecondPlayerPoints.Name = "labelSecondPlayerPoints";
            labelSecondPlayerPoints.Size = new Size(65, 28);
            labelSecondPlayerPoints.TabIndex = 6;
            labelSecondPlayerPoints.Text = "Points";
            // 
            // labelVs
            // 
            labelVs.AutoSize = true;
            labelVs.Font = new Font("Snap ITC", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelVs.Location = new Point(312, 222);
            labelVs.Name = "labelVs";
            labelVs.Size = new Size(103, 61);
            labelVs.TabIndex = 7;
            labelVs.Text = "VS";
            // 
            // numericUpDownFirstPlayerPoints
            // 
            numericUpDownFirstPlayerPoints.BackColor = Color.FromArgb(255, 192, 128);
            numericUpDownFirstPlayerPoints.Location = new Point(75, 271);
            numericUpDownFirstPlayerPoints.Name = "numericUpDownFirstPlayerPoints";
            numericUpDownFirstPlayerPoints.Size = new Size(43, 27);
            numericUpDownFirstPlayerPoints.TabIndex = 3;
            // 
            // numericUpDownSecondPlayerPoints
            // 
            numericUpDownSecondPlayerPoints.BackColor = Color.FromArgb(255, 192, 128);
            numericUpDownSecondPlayerPoints.Location = new Point(619, 271);
            numericUpDownSecondPlayerPoints.Name = "numericUpDownSecondPlayerPoints";
            numericUpDownSecondPlayerPoints.Size = new Size(43, 27);
            numericUpDownSecondPlayerPoints.TabIndex = 4;
            // 
            // buttonSaveGame
            // 
            buttonSaveGame.BackColor = Color.FromArgb(128, 128, 255);
            buttonSaveGame.Location = new Point(310, 361);
            buttonSaveGame.Name = "buttonSaveGame";
            buttonSaveGame.Size = new Size(139, 37);
            buttonSaveGame.TabIndex = 5;
            buttonSaveGame.Text = "Save";
            buttonSaveGame.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Error
            // 
            Error.AutoSize = true;
            Error.Location = new Point(29, 156);
            Error.Name = "Error";
            Error.Size = new Size(0, 20);
            Error.TabIndex = 8;
            Error.Validating += errorProvider1;
            // 
            // Error2
            // 
            Error2.AutoSize = true;
            Error2.Location = new Point(438, 155);
            Error2.Name = "Error2";
            Error2.Size = new Size(0, 20);
            Error2.TabIndex = 9;
            Error2.Validating += errorProvider2;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // NewGameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(Error2);
            Controls.Add(Error);
            Controls.Add(buttonSaveGame);
            Controls.Add(numericUpDownSecondPlayerPoints);
            Controls.Add(numericUpDownFirstPlayerPoints);
            Controls.Add(labelVs);
            Controls.Add(labelSecondPlayerPoints);
            Controls.Add(labelFirstPlayerPoints);
            Controls.Add(textBoxSecondPlayerName);
            Controls.Add(textBoxFirstPlayerName);
            Controls.Add(labelSecondPlayerName);
            Controls.Add(labelFirstPlayerName);
            Controls.Add(labelNewGame);
            Name = "NewGameForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDownFirstPlayerPoints).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSecondPlayerPoints).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNewGame;
        private Label labelFirstPlayerName;
        private Label labelSecondPlayerName;
        private TextBox textBoxFirstPlayerName;
        private TextBox textBoxSecondPlayerName;
        private Label labelFirstPlayerPoints;
        private Label labelSecondPlayerPoints;
        private Label labelVs;
        private NumericUpDown numericUpDownFirstPlayerPoints;
        private NumericUpDown numericUpDownSecondPlayerPoints;
        private Button buttonSaveGame;
        private Label Error2;
        private Label Error;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider1;
    }
}