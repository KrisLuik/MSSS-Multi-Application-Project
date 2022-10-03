using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApplication
{
    [Serializable]
    public class Information : IComparable<Information>
    {
        // Auto-implemented properties.
        private string starVelocity;
        private string starDistance;
        private string tempInKelvin;
        private string eventHorizon;
        public Information() { }

        public Information(string newstarVelocity, string newstarDistance, string newTempInKelvin, string newEventHorizon)
        {
            starVelocity = newstarVelocity;
            starDistance = newstarDistance;
            tempInKelvin = newTempInKelvin;
            eventHorizon = newEventHorizon;
        }
        public void SetStarVelocity(string newstarVelocity)
        {
            starVelocity = newstarVelocity;
        }
        public string GetStarVelocity()
        {
            return starVelocity;
        }
        public void SetStarDistance(string newstarDistance)
        {
            starDistance = newstarDistance;
        }
        public string GetStarDistance()
        {
            return starDistance;
        }
        public void SetTempInKelvin(string newTempInKelvin)
        {
            tempInKelvin = newTempInKelvin;
        }
        public string GetTempInKelvin()
        {
            return tempInKelvin;
        }
        public void SetEventHorizon(string newEventHorizon)
        {
            eventHorizon = newEventHorizon;
        }
        public string GetEventHorizon()
        {
            return eventHorizon;
        }
        public ListViewItem DisplayCalculations()
        {
            ListViewItem lvi = new ListViewItem(GetStarVelocity());
            lvi.SubItems.Add(GetStarDistance());
            lvi.SubItems.Add(GetTempInKelvin());    
            lvi.SubItems.Add(GetEventHorizon());    
            return lvi;
        }
        public int CompareTo(Information starVelocityObject)
        {
            return starVelocity.CompareTo(starVelocityObject.GetStarVelocity());
        }
    }
}
