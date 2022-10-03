using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            listViewItems.Sort();
            foreach (var info in astroCalculationsList)
            {
                listViewItems.Items.Add(info.DisplayCalculations());
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

            double tempCelcius = double.Parse(textboxTemperature.Text);
            if (!string.IsNullOrWhiteSpace(textboxTemperature.Text))
            {
               var result = channel.TempInKelvin(tempCelcius);
               textboxTemperatureReadOnly.Text = result.ToString(); 
            }
        }
        #endregion
    }
}
