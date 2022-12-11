using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace ComputerClub.Models
{
    public class Visit : INotifyPropertyChanged
    {
        private int visitID;
        private int visitorID;
        private Visitor visitor;
        private int computerID;
        private Computer computer;
        private DateTime visitDate;
        private double visitLenght;
        private double pay;

        [Key]
        public int VisitID
        {
            get { return visitID; }
            set
            {
                visitID = value;
                OnPropertyChanged("VisitID");
            }
        }

        public int VisitorID
        {
            get { return visitorID; }
            set
            {
                visitorID = value;
                OnPropertyChanged("VisitorID");
            }
        }

        public Visitor Visitor
        {
            get { return visitor; }
            set
            {
                visitor = value;
                OnPropertyChanged("Visitor");
            }
        }

        public int ComputerID
        {
            get { return computerID; }
            set
            {
                computerID = value;
                OnPropertyChanged("ComputerID");
            }
        }

        public Computer Computer
        {
            get { return computer; }
            set
            {
                computer = value;
                OnPropertyChanged("Computer");
            }
        }

        public DateTime VisitDate
        {
            get { return visitDate; }
            set
            {
                visitDate = value;
                OnPropertyChanged("VisitDate");
            }
        }

        public double VisitLenght
        {
            get { return visitLenght; }
            set
            {
                visitLenght = value;
                OnPropertyChanged("VisitLenght");
            }
        }

        public double Pay
        {
            get { return pay; }
            set
            {
                pay = value;
                OnPropertyChanged("Pay");
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