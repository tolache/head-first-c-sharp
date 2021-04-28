using System;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;

namespace Chapter_11_Excuse_Manager
{
    [DataContract (Namespace = "Chapter_11_Excuse_Manager")]
    public class Excuse : INotifyPropertyChanged
    {
        [DataMember]
        private DateTime lastUsed = DateTime.MinValue;

        public string LastUsed
        {
            get
            {
                if (lastUsed == DateTime.MinValue)
                    return String.Empty;
                return lastUsed.ToString(CultureInfo.InvariantCulture);
            }
            set
            {
                DateTime dateTime = DateTime.MinValue;
                bool dateIsValid = DateTime.TryParse(value, out dateTime);
                lastUsed = dateTime;
                if (!String.IsNullOrEmpty(value) && !dateIsValid)
                {
                    DateWarning = "Invalid date: " + value;
                }
                else
                {
                    DateWarning = String.Empty;
                }
                OnPropertyChanged("DateWarning");
            }
        }

        [DataMember] public string Description { get; set; }

        [DataMember] public string Results { get; set; }

        public string DateWarning { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChangedEvent = PropertyChanged;
            propertyChangedEvent?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}