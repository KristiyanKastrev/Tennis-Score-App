using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TennisProjectApp
{
    public partial class NewGameForm : Form
    {
        public NewGameForm()
        {
            InitializeComponent();
        }
        public (string, int) FirstPlayer { get; set; }
        public (string, int) SecondPlayer { get; set; }

        private void ButtonSaveGameClick(object sender, EventArgs e)
        {
            string firstPlayerName = textBoxFirstPlayerName.Text.Trim();
            int firstPlayerPoints = (int)numericUpDownFirstPlayerPoints.Value;

            string secondPlayerName = textBoxSecondPlayerName.Text.Trim();
            int secondPlayerPoints = (int)numericUpDownSecondPlayerPoints.Value;

            if (!CheckIfInputsAreValid())
            {
                ValidateChildren(ValidationConstraints.Enabled);
                return;
            }

            this.DialogResult = DialogResult.OK;
        }

        private bool CheckIfInputsAreValid()
     => !CheckIfPlayerNamesAreEmpty() && !CheckIfPlayerNamesAreSame();

        private bool CheckIfPlayerNamesAreEmpty()
            => string.IsNullOrEmpty(this.FirstPlayer.Item1) || string.IsNullOrEmpty(this.SecondPlayer.Item1);

        private bool CheckIfPlayerNamesAreSame()
            => string.IsNullOrEmpty(this.FirstPlayer.Item1) || string.IsNullOrEmpty(this.SecondPlayer.Item1);

        private void errorProvider1(object sender, CancelEventArgs e)
        {

        }

        private void errorProvider2(object sender, CancelEventArgs e)
        {

        }
        private void ValidatePlayerName(object sender, CancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                e.Cancel = true;
                textBox.Focus();
                ShowEmptyNameErrorMessage(textBox);
            }
            else
            {
                e.Cancel = false;
                RemoveErrorMessages(textBox);
                ShowErrorOnSameNames();
            }
        }
        private void ShowEmptyNameErrorMessage(TextBox textBox)
        {
            var errorText = "Player Name should not be left blank!";

            if (textBox == this.textBox1)
            {
                this.errorProvider1.SetError(textBox, errorText);
                this.Error.Text = "First " + errorText;
            }
            else if (textBox == this.textBox2)
            {
                this.errorProvider2.SetError(textBox, errorText);
                this.labelError.Text = "Second " + errorText;
            }
        }
        private void RemoveErrorMessages(TextBox textBox)
        {
            if (textBox == this.textBox1)
            {
                this.errorProvider1.SetError(textBox, "");
                this.Error.Text = string.Empty;
            }
            else if (textBox == this.textBox2)
            {
                this.errorProvider2.SetError(textBox, "");
                this.labelError.Text = string.Empty;
            }
        }
        private void ShowErrorOnSameNames()
        {
            if (CheckIfPlayerNamesAreSame())
            {
                this.Error.Text = "First Player name should not be same as Second Player name!";
            }
            else
            {
                this.labelError.Text = string.Empty;
            }
        }
    }
}
