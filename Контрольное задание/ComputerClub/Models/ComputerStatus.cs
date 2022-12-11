using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace ComputerClub.Models
{
    public class ComputerStatus : INotifyPropertyChanged
    {
        private int statusID;
        private string computerStatusName;

        [Key]
        public int StatusID
        {
            get { return statusID; }
            set
            {
                statusID = value;
                OnPropertyChanged("StatusID");
            }
        }

        public string ComputerStatusName
        {
            get { return computerStatusName; }
            set
            {
                computerStatusName = value;
                OnPropertyChanged("ComputerStatus");
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