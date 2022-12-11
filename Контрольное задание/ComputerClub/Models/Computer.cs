using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace ComputerClub.Models
{
    public class Computer : INotifyPropertyChanged
    {
        private int computerID;
        private int statusID;
        private ComputerStatus computerStatus;
        private string computerName;
        private string computerDescription;

        [Key]
        public int ComputerID
        {
            get { return computerID; }
            set
            {
                computerID = value;
                OnPropertyChanged("ComputerID");
            }
        }

        public ComputerStatus ComputerStatus
        {
            get { return computerStatus; }
            set
            {
                computerStatus = value;
                OnPropertyChanged("ComputerStatus");
            }
        }

        public int StatusID
        {
            get { return statusID; }
            set
            {
                statusID = value;
                OnPropertyChanged("StatusID");
            }
        }

        public string ComputerName
        {
            get { return computerName; }
            set
            {
                computerName = value;
                OnPropertyChanged("ComputerName");
            }
        }

        public string ComputerDescription
        {
            get { return computerDescription; }
            set
            {
                computerDescription = value;
                OnPropertyChanged("ComputerDescription");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}