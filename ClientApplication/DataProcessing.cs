using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO.Pipes;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ClientApplication
{
    public partial class DataProcessing : Form
    {
        public DataProcessing()
        {
            InitializeComponent();
        }
        #region Properties
        List<Information> astroCalculationsList = new List<Information>();
        #endregion
        #region Add button
        private void addButton_Click(object sender, EventArgs e)
        {
            // ClearStatusMessage();
            observedWavelengthTextbox.Focus();
            // if (!string.IsNullOrWhiteSpace(textboxStarVelocityReadOnly.Text) &&
            //    !string.IsNullOrWhiteSpace(textboxStarDistance.Text))
            // {
            Information info = new Information();
            info.SetStarVelocity(textboxStarVelocityReadOnly.Text);
            info.SetStarDistance(textboxStarDistanceReadOnly.Text);
            info.SetTempInKelvin(textboxTemperatureReadOnly.Text);
            info.SetEventHorizon(textboxEventHorizonReadOnly.Text);
            astroCalculationsList.Add(info);
            astroCalculationsList.Sort();
            Display();
            ClearAllTextBoxes();
            // toolStripStatusLabel.Text = "Calculations added.";
            //}
        }
        #endregion
        #region Display Data
        private void Display()
        {
            listViewItems.Items.Clear();
            foreach (var info in astroCalculationsList)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add(info.GetStarVelocity());
                lvi.SubItems.Add(info.GetStarDistance());
                lvi.SubItems.Add(info.GetTempInKelvin());
                lvi.SubItems.Add(info.GetEventHorizon());
                listViewItems.Items.Add(lvi);
            }
            // toolStripStatusLabel.Text = "Data items displayed.";
        }
        #endregion
        #region Highlight data from listview
        private void listViewItems_MouseClick(object sender, MouseEventArgs e)
        {
            // ClearStatusMessage();
            int currentItem = listViewItems.SelectedIndices[0];
            textboxStarVelocityReadOnly.Text = astroCalculationsList[currentItem].GetStarVelocity();
            textboxStarDistanceReadOnly.Text = astroCalculationsList[currentItem].GetStarDistance();
            textboxTemperatureReadOnly.Text = astroCalculationsList[currentItem].GetTempInKelvin();
            textboxEventHorizonReadOnly.Text = astroCalculationsList[currentItem].GetEventHorizon();
        }
        #endregion
        #region Delete button
        private void deleteButton_Click(object sender, EventArgs e)
        {
            // ClearStatusMessage();
            try
            {
                int currentItem = listViewItems.SelectedIndices[0];
                // Trace.WriteLine("Current item index: " + currentItem);
                if (currentItem >= 0)
                {
                    DialogResult delRecord = MessageBox.Show("Do you wish to delete this row?",
                     "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (delRecord == DialogResult.Yes)
                    {
                        astroCalculationsList.RemoveAt(currentItem);
                        astroCalculationsList.Sort();
                        // ClearAllTextBoxes();
                        Display();
                        //toolStripStatusLabel.Text = "Item deleted.";
                        // Trace.WriteLine("Selected item deleted.");
                    }
                    else
                    {
                        MessageBox.Show("Item NOT Deleted", "Delete Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Trace.WriteLine("Item NOT deleted.");
                    }
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                // Trace.WriteLine("Error! Not a valid action!");
                // toolStripStatusLabel.Text = "Error: Not a valid action.";
            }
        }
        #endregion
        #region Calculate button
        private void calculateButton_Click(object sender, EventArgs e)
        {
            string address = "net.pipe://localhost/AstroServer";
            NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            EndpointAddress ep = new EndpointAddress(address);
            IAstroContract channel = ChannelFactory<IAstroContract>.CreateChannel(binding, ep);

            if (string.IsNullOrWhiteSpace(observedWavelengthTextbox.Text) &&
                string.IsNullOrWhiteSpace(restWavelengthTextbox.Text) &&
                string.IsNullOrWhiteSpace(textboxStarDistance.Text) &&
                string.IsNullOrWhiteSpace(textboxTemperature.Text) &&
                string.IsNullOrWhiteSpace(textboxEventHorizon.Text) &&
                eventHorizonPower.Value == 0)
            {
                MessageBox.Show("textboxes are empty");
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(observedWavelengthTextbox.Text) &&
                    !string.IsNullOrWhiteSpace(restWavelengthTextbox.Text))
                {
                    double observedeWavelength = double.Parse(observedWavelengthTextbox.Text);
                    double restWavelength = double.Parse(restWavelengthTextbox.Text);
                    var starVelocityCalculation = channel.StarVelocity(observedeWavelength, restWavelength);
                    textboxStarVelocityReadOnly.Text = starVelocityCalculation.ToString();
                    ClearTextBox(observedWavelengthTextbox);
                    restWavelengthTextbox.Clear();
                }
                if (!string.IsNullOrWhiteSpace(textboxStarDistance.Text))
                {
                    double starDistanceData = double.Parse(textboxStarDistance.Text);
                    var starDistanceCalculation = channel.StarDistance(starDistanceData);
                    textboxStarDistanceReadOnly.Text = starDistanceCalculation.ToString();
                    ClearTextBox(textboxStarDistance);
                }
                if (!string.IsNullOrWhiteSpace(textboxTemperature.Text))
                {
                    double tempCelcius = double.Parse(textboxTemperature.Text);
                    var result = channel.TempInKelvin(tempCelcius);
                    textboxTemperatureReadOnly.Text = result.ToString();
                    ClearTextBox(textboxTemperature);
                }
                if (!string.IsNullOrWhiteSpace(textboxEventHorizon.Text) && eventHorizonPower.Value > 0)
                {
                    double eventHorizonData = double.Parse(textboxEventHorizon.Text);
                    double powerOfEventHorizon = double.Parse(eventHorizonPower.Value.ToString());
                    double eventResult = eventHorizonData * powerOfEventHorizon;
                    var eventHorizonResult = channel.EventHorizon(eventResult);
                    textboxEventHorizonReadOnly.Text = eventHorizonResult.ToString();
                    ClearTextBox(textboxEventHorizon);
                }
            }
        }
        #endregion
        #region Language Setting
        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CultureInfo.CurrentUICulture = CultureInfo.CreateSpecificCulture("en");
            Controls.Clear();
            InitializeComponent();
            Display();
        }
        private void frenchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CultureInfo.CurrentUICulture = CultureInfo.CreateSpecificCulture("fr");
            Controls.Clear();
            InitializeComponent();
            Display();

        }
        private void germanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CultureInfo.CurrentUICulture = CultureInfo.CreateSpecificCulture("de");
            Controls.Clear();
            InitializeComponent();
            Display();
        }
        #endregion
        #region Style Settings
        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                BackgroundImage = null;
                BackColor = colorDlg.Color;
                byte r = (byte)(255 - BackColor.R);
                byte g = (byte)(255 - BackColor.G);
                byte b = (byte)(255 - BackColor.B);
                ForeColor = Color.FromArgb(r, g, b);
                foreach (var textBox in Controls.OfType<TextBox>())
                {
                    textBox.ForeColor = Color.FromArgb(r, g, b);
                }
            }
        }
        private void nightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImage = null;
            BackColor = Color.MidnightBlue;
            ForeColor = Color.LavenderBlush;
            foreach (var button in Controls.OfType<Button>())
            {
                button.BackColor = Color.SteelBlue;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderColor = Color.SlateBlue;

            }
            foreach (var label in Controls.OfType<Label>())
            {
                label.ForeColor = Color.LavenderBlush;
            }
            foreach (var textBox in Controls.OfType<TextBox>())
            {
                textBox.ForeColor = Color.LightYellow;
            }
        }

        private void lightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackgroundImage = null;
            BackColor = Color.LightSalmon;
            ForeColor = Color.Yellow;
            foreach (var button in Controls.OfType<Button>())
            {
                button.BackColor = Color.Firebrick;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderColor = Color.OrangeRed;
            }
            foreach (var label in Controls.OfType<Label>())
            {
                label.ForeColor = Color.Goldenrod;
            }
            foreach (var textBox in Controls.OfType<TextBox>())
            {
                textBox.ForeColor = Color.Magenta;
            }
        }
        #endregion
        #region Clear TextBoxes Method
        private void ClearTextBox(TextBox textbox)
        {
            textbox.Clear();
            textbox.Focus();
        }
        private void ClearAllTextBoxes()
        {
            observedWavelengthTextbox.Clear();
            restWavelengthTextbox.Clear();
            textboxStarVelocityReadOnly.Clear();
            observedWavelengthTextbox.Focus();

            textboxStarDistance.Clear();
            textboxStarDistanceReadOnly.Clear();

            textboxTemperature.Clear();
            textboxTemperatureReadOnly.Clear();

            textboxEventHorizon.Clear();
            textboxEventHorizonReadOnly.Clear();
        }

        #endregion
        #region TextBoxes Input Handling
        private void KeyPressAction(Object sender, KeyPressEventArgs e)
        {
            // "sender" stands for the object that raises the event.
            // I am casting the sender using "as" keyword to avoid runtime exception
            // that would occur if I used "Textbox tb = Textbox(sender)".
            TextBox tb = sender as TextBox;

            if (tb == null)
            {
                MessageBox.Show("Keypress event was not fired by a textbox.");
                e.Handled = true;
            }

            if ((tb.Text.IndexOf('-') > -1) && tb.SelectionStart == 0 && !tb.SelectedText.Contains('-'))
            {
                e.Handled = true;
            }
            // Do not accept a character that is not included in the following.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
            // Only allow one decimal point.
            if ((e.KeyChar == '.') && (tb.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            // The negative sign can only be at the start.
            if ((e.KeyChar == '-'))
            {
                // If the cursor is not at the start of the text, the key press is not valid.
                if (tb.SelectionStart > 0)
                {
                    e.Handled = true;
                }
                // If there is already a negative sign and the negative sign is not selected, the key press is not valid
                // This allows the user to highlight some of the text and replace it with a negative sign.
                if (tb.Text.IndexOf('-') > -1 && !tb.SelectedText.Contains('-'))
                {
                    e.Handled = true;
                }
            }
        }
        #endregion
    }
}