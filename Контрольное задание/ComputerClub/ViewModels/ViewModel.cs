using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using ComputerClub.Models;
using ComputerClub.View;
using Microsoft.EntityFrameworkCore;

namespace ComputerClub.ViewModels
{
    class ViewModel : INotifyPropertyChanged
    {
        ApplicationContext db = new ApplicationContext();

        public ViewModel()
        {
            db.Database.EnsureCreated();

            db.Computers.Load();
            Computers = db.Computers.Local.ToObservableCollection();

            db.Visitors.Load();
            Visitors = db.Visitors.Local.ToObservableCollection();

            db.Visits.Load();
            Visits = db.Visits.Local.ToObservableCollection();

            db.ComputersStatuses.Load();
            ComputerStatuses = db.ComputersStatuses.Local.ToObservableCollection();
        }

        //Компьютеры
        RelayCommand addComputer;
        RelayCommand editComputer;
        RelayCommand deleteComputer;
        private Computer selectedComputer;

        public Computer SelectedComputer
        {
            get { return selectedComputer; }
            set
            {
                selectedComputer = value;
                OnPropertyChanged("SelectedComputer");
            }
        }

        public ObservableCollection<Computer> Computers { get; set; }

        public RelayCommand AddComputer
        {
            get
            {
                return addComputer ??
                (addComputer = new RelayCommand((o) =>
                {
                    ComputerView ComputerWindow = new ComputerView(new Computer(), ComputerStatuses);
                    if (ComputerWindow.ShowDialog() == true)
                    {
                        Computer Computer = ComputerWindow.Computer;
                        db.Computers.Add(Computer);
                        db.SaveChanges();
                    }
                }));
            }
        }

        public RelayCommand EditComputer
        {
            get
            {
                return editComputer ??
                (editComputer = new RelayCommand((selectedItem) =>
                {
    
                        Computer computer = selectedItem as Computer;
                    if (computer is null) return;

                    ComputerView ComputerWindow = new ComputerView(new Computer
                    {
                        ComputerID = computer.ComputerID,
                        ComputerName = computer.ComputerName,
                        ComputerDescription = computer.ComputerDescription,
                        ComputerStatus = computer.ComputerStatus,
                        StatusID = computer.StatusID
                    }, ComputerStatuses);

                    if (ComputerWindow.ShowDialog() == true)
                    {
                        computer = db.Computers.Find(ComputerWindow.Computer.ComputerID);
                        if (computer != null)
                        {
                            computer.ComputerID = ComputerWindow.Computer.ComputerID;
                            computer.ComputerName = ComputerWindow.Computer.ComputerName;
                            computer.ComputerDescription = ComputerWindow.Computer.ComputerDescription;
                            computer.ComputerStatus = ComputerWindow.Computer.ComputerStatus;
                            computer.StatusID = ComputerWindow.Computer.StatusID;
                            db.SaveChanges();
                        }
                    }
                }));
            }
        }

        public RelayCommand DeleteComputer
        {
            get
            {
                return deleteComputer ??
                (deleteComputer = new RelayCommand((selectedItem) =>
                {
                    Computer computer = selectedItem as Computer;
                    if (computer is null) return;
                    db.Computers.Remove(computer);
                    db.SaveChanges();
                }));
            }
        }

        //Посетители
        RelayCommand addVisitor;
        RelayCommand editVisitor;
        RelayCommand deleteVisitor;
        private Visitor selectedVisitor;

        public Visitor SelectedVisitor
        {
            get { return selectedVisitor; }
            set
            {
                selectedVisitor = value;
                OnPropertyChanged("SelectedVisitor");
            }
        }

        public ObservableCollection<Visitor> Visitors { get; set; }

        public RelayCommand AddVisitor
        {
            get
            {
                return addVisitor ??
                (addVisitor = new RelayCommand((o) =>
                {
                    VisitorView VisitorWindow = new VisitorView(new Visitor());
                    if (VisitorWindow.ShowDialog() == true)
                    {
                        Visitor Visitor = VisitorWindow.Visitor;
                        db.Visitors.Add(Visitor);
                        db.SaveChanges();
                    }
                }));
            }
        }

        public RelayCommand EditVisitor
        {
            get
            {
                return editVisitor ??
                (editVisitor = new RelayCommand((selectedItem) =>
                {

                    Visitor visitor = selectedItem as Visitor;
                    if (visitor is null) return;

                    VisitorView VisitorWindow = new VisitorView(new Visitor
                    {
                        VisitorID = visitor.VisitorID,
                        FirstName = visitor.FirstName,
                        SurName = visitor.SurName,
                        Patronymic = visitor.Patronymic,
                        IdentityDocument = visitor.IdentityDocument,
                        Adress = visitor.Adress,
                        Phone = visitor.Phone
                    });

                    if (VisitorWindow.ShowDialog() == true)
                    {
                        visitor = db.Visitors.Find(VisitorWindow.Visitor.VisitorID);
                        if (visitor != null)
                        {
                            visitor.VisitorID = VisitorWindow.Visitor.VisitorID;
                            visitor.FirstName = VisitorWindow.Visitor.FirstName;
                            visitor.SurName = VisitorWindow.Visitor.SurName;
                            visitor.Patronymic = VisitorWindow.Visitor.Patronymic;
                            visitor.IdentityDocument = VisitorWindow.Visitor.IdentityDocument;
                            visitor.Adress = VisitorWindow.Visitor.Adress;
                            visitor.Phone = VisitorWindow.Visitor.Phone;
                            db.SaveChanges();
                        }
                    }
                }));
            }
        }

        public RelayCommand DeleteVisitor
        {
            get
            {
                return deleteVisitor ??
                (deleteVisitor = new RelayCommand((selectedItem) =>
                {
                    Visitor computer = selectedItem as Visitor;
                    if (computer is null) return;
                    db.Visitors.Remove(computer);
                    db.SaveChanges();
                }));
            }
        }

        //Посещения
        RelayCommand addVisit;
        RelayCommand editVisit;
        RelayCommand deleteVisit;
        private Visit selectedVisit;

        public Visit SelectedVisit
        {
            get { return selectedVisit; }
            set
            {
                selectedVisit = value;
                OnPropertyChanged("SelectedVisit");
            }
        }

        public ObservableCollection<Visit> Visits { get; set; }


        public RelayCommand AddVisit
        {
            get
            {
                return addVisit ??
                (addVisit = new RelayCommand((o) =>
                {
                    VisitView VisitWindow = new VisitView(new Visit(), Computers ,Visitors);
                    if (VisitWindow.ShowDialog() == true)
                    {
                        Visit Visit = VisitWindow.Visit;
                        db.Visits.Add(Visit);
                        db.SaveChanges();
                    }
                }));
            }
        }

        public RelayCommand EditVisit
        {
            get
            {
                return editVisit ??
                (editVisit = new RelayCommand((selectedItem) =>
                {

                    Visit visit = selectedItem as Visit;
                    if (visit is null) return;

                    VisitView VisitWindow = new VisitView(new Visit
                    {
                        ComputerID = visit.ComputerID,
                        Computer = visit.Computer,
                        VisitorID = visit.VisitorID,
                        Visitor = visit.Visitor,
                        VisitID = visit.VisitID,
                        VisitDate = visit.VisitDate,
                        VisitLenght = visit.VisitLenght,
                        Pay = visit.Pay
                    }, Computers, Visitors);

                    if (VisitWindow.ShowDialog() == true)
                    {
                        visit = db.Visits.Find(VisitWindow.Visit.VisitID);
                        if (visit != null)
                        {
                            visit.VisitID = VisitWindow.Visit.VisitID;
                            visit.ComputerID = VisitWindow.Visit.ComputerID;
                            visit.Computer = VisitWindow.Visit.Computer;
                            visit.VisitorID = VisitWindow.Visit.VisitorID;
                            visit.Visitor = VisitWindow.Visit.Visitor;
                            visit.VisitDate = VisitWindow.Visit.VisitDate;
                            visit.VisitLenght = VisitWindow.Visit.VisitLenght;
                            visit.Pay = VisitWindow.Visit.Pay;
                            db.SaveChanges();
                        }
                    }
                }));
            }
        }

        public RelayCommand DeleteVisit
        {
            get
            {
                return deleteVisit ??
                (deleteVisit = new RelayCommand((selectedItem) =>
                {
                    Visit computer = selectedItem as Visit;
                    if (computer is null) return;
                    db.Visits.Remove(computer);
                    db.SaveChanges();
                }));
            }
        }

        //Статусы компьютеров
        RelayCommand addComputerStatus;
        RelayCommand editComputerStatus;
        RelayCommand deleteComputerStatus;
        private ComputerStatus selectedComputerStatus;

        public ComputerStatus SelectedComputerStatus
        {
            get { return selectedComputerStatus; }
            set
            {
                selectedComputerStatus = value;
                OnPropertyChanged("SelectedComputerStatus");
            }
        }

        public ObservableCollection<ComputerStatus> ComputerStatuses { get; set; }


        public RelayCommand AddComputerStatus
        {
            get
            {
                return addComputerStatus ??
                (addComputerStatus = new RelayCommand((o) =>
                {
                    ComputerStatusView ComputerStatusWindow = new ComputerStatusView(new ComputerStatus());
                    if (ComputerStatusWindow.ShowDialog() == true)
                    {
                        ComputerStatus ComputerStatus = ComputerStatusWindow.ComputerStatus;
                        db.ComputersStatuses.Add(ComputerStatus);
                        db.SaveChanges();
                    }
                }));
            }
        }

        public RelayCommand EditComputerStatus
        {
            get
            {
                return editComputerStatus ??
                (editComputerStatus = new RelayCommand((selectedItem) =>
                {

                    ComputerStatus computer = selectedItem as ComputerStatus;
                    if (computer is null) return;

                    ComputerStatusView ComputerStatusWindow = new ComputerStatusView(new ComputerStatus
                    {
                        ComputerStatusName = computer.ComputerStatusName,
                        StatusID = computer.StatusID
                    });

                    if (ComputerStatusWindow.ShowDialog() == true)
                    {
                        computer = db.ComputersStatuses.Find(ComputerStatusWindow.ComputerStatus.StatusID);
                        if (computer != null)
                        {
                            computer.ComputerStatusName = ComputerStatusWindow.ComputerStatus.ComputerStatusName;
                            computer.StatusID = ComputerStatusWindow.ComputerStatus.StatusID;
                            db.SaveChanges();
                        }
                    }
                }));
            }
        }

        public RelayCommand DeleteComputerStatus
        {
            get
            {
                return deleteComputerStatus ??
                (deleteComputerStatus = new RelayCommand((selectedItem) =>
                {
                    ComputerStatus computer = selectedItem as ComputerStatus;
                    if (computer is null) return;
                    db.ComputersStatuses.Remove(computer);
                    db.SaveChanges();
                }));
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