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
            // ClearAllTextBoxes();
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

            double observedeWavelength = double.Parse(observedWavelengthTextbox.Text);
            double restWavelength = double.Parse(restWavelengthTextbox.Text);

            double starDistanceData = double.Parse(textboxStarDistance.Text);
            double tempCelcius = double.Parse(textboxTemperature.Text);

            double eventHorizonData = double.Parse(textboxEventHorizon.Text);
            double powerOfEventHorizon = double.Parse(eventHorizonPower.Value.ToString());
            double eventResult = eventHorizonData * powerOfEventHorizon;

            if (!string.IsNullOrWhiteSpace(observedWavelengthTextbox.Text) &&
                !string.IsNullOrWhiteSpace(restWavelengthTextbox.Text))
            {
                var starVelocityCalculation = channel.StarVelocity(observedeWavelength, restWavelength);
                var resultSV = textboxStarVelocityReadOnly.Text;
            }
            else if (!string.IsNullOrWhiteSpace(textboxStarDistance.Text))
            {
                var starDistanceCalculation = channel.StarDistance(starDistanceData);
                var resultStarDistance = textboxStarDistanceReadOnly.Text;
            }
            else if (!string.IsNullOrWhiteSpace(textboxTemperature.Text))
            {
                var result = channel.TempInKelvin(tempCelcius);
                textboxTemperatureReadOnly.Text = result.ToString();

            }
            else if (!string.IsNullOrWhiteSpace(textboxEventHorizon.Text) && powerOfEventHorizon > 0)
            {
                var eventHorizonResult = channel.EventHorizon(eventResult);
                textboxEventHorizon.Text = eventHorizonResult.ToString();   

            }
            #endregion

        }
        #region Language setting
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
        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CultureInfo.CurrentUICulture = CultureInfo.CreateSpecificCulture("en");
            Controls.Clear();
            InitializeComponent();
            Display();
        }
        #endregion
    }
}