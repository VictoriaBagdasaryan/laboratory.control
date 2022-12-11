using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
 
namespace ComputerClub.Models
{
    public class Visitor : INotifyPropertyChanged
    {
        private int visitorID;
        private string firstName;
        private string surName;
        private string patronymic;
        private string identityDocument;
        private string adress;
        private string phone;

        [Key]
        public int VisitorID
        {
            get { return visitorID; }
            set
            {
                visitorID = value;
                OnPropertyChanged("VisitorID");
            }
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                OnPropertyChanged("FirstName");
            }
        }

        public string SurName
        {
            get { return surName; }
            set
            {
                surName = value;
                OnPropertyChanged("SurName");
            }
        }

        public string Patronymic
        {
            get { return patronymic; }
            set
            {
                patronymic = value;
                OnPropertyChanged("Patronymic");
            }
        }

        public string IdentityDocument
        {
            get { return identityDocument; }
            set
            {
                identityDocument = value;
                OnPropertyChanged("IdentityDocument");
            }
        }

        public string Adress
        {
            get { return adress; }
            set
            {
                adress = value;
                OnPropertyChanged("Adress");
            }
        }

        public string Phone
        {
            get { return phone; }
            set
            {
                phone = value;
                OnPropertyChanged("Phone");
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