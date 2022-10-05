using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Name: Kristiin Tribbeck
// Student ID: 30045325
// Development of a multi-application system that will connect several clients with a remote server. 

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
            observedWavelengthTextbox.Focus();
            Information info = new Information();
            if (string.IsNullOrWhiteSpace(textboxStarVelocityReadOnly.Text) &&
                string.IsNullOrWhiteSpace(textboxStarDistanceReadOnly.Text) &&
                string.IsNullOrWhiteSpace(textboxTemperatureReadOnly.Text) &&
                string.IsNullOrWhiteSpace(textboxEventHorizonReadOnly.Text) &&
                eventHorizonPower.Value == 0)
            {
                MessageBox.Show("Error! Textboxes are emtpy, add data.");
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(textboxStarVelocityReadOnly.Text))
                {
                    info.SetStarVelocity(textboxStarVelocityReadOnly.Text);
                    ClearTextBox(observedWavelengthTextbox);
                    restWavelengthTextbox.Clear();
                }
                if (!string.IsNullOrWhiteSpace(textboxStarDistanceReadOnly.Text))
                {
                    info.SetStarDistance(textboxStarDistanceReadOnly.Text);
                    ClearTextBox(textboxStarDistance);
                }
                if (!string.IsNullOrWhiteSpace(textboxTemperatureReadOnly.Text))
                {
                    info.SetTempInKelvin(textboxTemperatureReadOnly.Text);
                    ClearTextBox(textboxTemperature);
                }
                if (!string.IsNullOrWhiteSpace(textboxEventHorizonReadOnly.Text) && eventHorizonPower.Value > 0)
                {
                    info.SetEventHorizon(textboxEventHorizonReadOnly.Text);
                    ClearTextBox(textboxEventHorizon);
                }
                else
                {
                    MessageBox.Show("Error! Numeric Up/Down. Cannot be 0");
                }
            }
            astroCalculationsList.Add(info);
            Display();
            ClearAllTextBoxes();
        }
        #endregion
        #region Delete button
        private void deleteButton_Click(object sender, EventArgs e)
        {
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
                        ClearAllTextBoxes();
                        Display();
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
                MessageBox.Show("Error! Textboxes are emtpy, add data.");
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
        }
        #endregion
        #region Highlight Data from Listview
        private void listViewItems_MouseClick(object sender, MouseEventArgs e)
        {
            int currentItem = listViewItems.SelectedIndices[0];
            textboxStarVelocityReadOnly.Text = astroCalculationsList[currentItem].GetStarVelocity();
            textboxStarDistanceReadOnly.Text = astroCalculationsList[currentItem].GetStarDistance();
            textboxTemperatureReadOnly.Text = astroCalculationsList[currentItem].GetTempInKelvin();
            textboxEventHorizonReadOnly.Text = astroCalculationsList[currentItem].GetEventHorizon();
        }
        #endregion
        #region Language and Theme ToolstripMenuItems Click Event
        // Languages.
        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("en");
        }
        private void frenchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("fr");
        }
        private void germanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeLanguage("de");
        }
        // Themes.
        private void nightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTheme("NightMode");
        }
        private void lightModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTheme("DayMode");
        }
        private void colourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTheme("ColorWheelStyle");
        }
        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeTheme("DefaultMode");
        }
        #endregion
        #region Language Setting Switch Case
        private void ChangeLanguage(string language)
        {
            switch (language)
            {
                case "en":
                    CultureInfo.CurrentUICulture = CultureInfo.CreateSpecificCulture("en");
                    break;
                case "fr":
                    CultureInfo.CurrentUICulture = CultureInfo.CreateSpecificCulture("fr");
                    break;
                case "de":
                    CultureInfo.CurrentUICulture = CultureInfo.CreateSpecificCulture("de");
                    break;
            }
            Controls.Clear();
            InitializeComponent();
            Display();
        }
        #endregion
        #region Theme Setting Switch Case
        private void ChangeTheme(string theme)
        {
            switch (theme)
            {
                case "NightMode":
                    NightMode();
                    break;
                case "DayMode":
                    DayMode();
                    break;
                case "ColorWheelStyle":
                    ColorWheelStyle();
                    break;
                case "DefaultMode":
                    DefaultMode();
                    break;
            }
            Controls.Clear();
            InitializeComponent();
            Display();
        }
        #endregion
        #region Theme and Style Setting Methods
        private void ColorWheelStyle()
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
        private void NightMode()
        {
            BackgroundImage = null;
            BackColor = Color.MidnightBlue;
            ForeColor = Color.Thistle;
            foreach (var button in Controls.OfType<Button>())
            {
                button.BackColor = Color.SteelBlue;
               // button.FlatStyle = FlatStyle.Flat;
                //button.FlatAppearance.BorderColor = Color.SlateBlue;

            }
            foreach (var label in Controls.OfType<Label>())
            {
                label.ForeColor = Color.White;
            }
            foreach (var textBox in Controls.OfType<TextBox>())
            {
                textBox.ForeColor = Color.LightYellow;
            }
        }
        private void DayMode()
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
                label.ForeColor = Color.Black;
            }
            foreach (var textBox in Controls.OfType<TextBox>())
            {
                textBox.ForeColor = Color.Magenta;
            }
        }
        private void DefaultMode()
        {
            BackgroundImage = null;
            BackColor = SystemColors.Control;
            ForeColor = SystemColors.ControlText;
            foreach (var button in Controls.OfType<Button>())
            {
                button.BackColor = Color.White;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderColor = Color.LightGray;
            }
            foreach (var label in Controls.OfType<Label>())
            {
                label.ForeColor = Color.Black;
            }
            foreach (var textBox in Controls.OfType<TextBox>())
            {
                textBox.ForeColor = Color.WhiteSmoke;
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
        #region Form Load
        private void DataProcessing_Load(object sender, EventArgs e)
        {
            observedWavelengthTextbox.Focus();
        }
        #endregion
    }
}