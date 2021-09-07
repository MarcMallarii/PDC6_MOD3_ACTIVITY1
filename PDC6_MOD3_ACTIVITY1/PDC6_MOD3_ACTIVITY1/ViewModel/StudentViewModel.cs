using System;
using System.Collections.Generic;
using System.Text;
using PDC6_MOD3_ACTIVITY1.Model;
using Xamarin.Forms;
using System.ComponentModel;


namespace PDC6_MOD3_ACTIVITY1.ViewModel
{
    class StudentViewModel : INotifyPropertyChanged
    {
        public Student StudentSet { get; set; }

        // Action
        public Command SubmitEntry { get; set; }
        public Command ClearEntry { get; set; }

        // Entry
        public int IDEntry { get; set; }
        public string NameEntry { get; set; }
        public string CourseCodeEntry { get; set; }
        public string CourseTitleEntry { get; set; }
        public int NumberOfUnitsEntry { get; set; }
        public DateTime DateOfAttendanceEntry { get; set; }

        // Display
        public int IDDisplay { get; set; }
        public string NameDisplay { get; set; }
        public string CourseCodeDisplay { get; set; }
        public string CourseTitleDisplay { get; set; }
        public int NumberOfUnitsDisplay { get; set; }
        public DateTime DateOfAttendanceDisplay { get; set; }

        public StudentViewModel()
        {
            SubmitEntry = new Command(() =>
            {
                StudentSet = new Student()
                {
                    ID = IDEntry,
                };

                IDDisplay = IDEntry;
                NameDisplay = NameEntry;
                CourseCodeDisplay = CourseCodeEntry;
                CourseTitleDisplay = CourseTitleEntry;
                NumberOfUnitsDisplay = NumberOfUnitsEntry;
                DateOfAttendanceDisplay = DateOfAttendanceEntry;

                // Entry
                OnPropertyChanged(nameof(IDEntry));
                OnPropertyChanged(nameof(NameEntry));
                OnPropertyChanged(nameof(CourseCodeEntry));
                OnPropertyChanged(nameof(CourseTitleEntry));
                OnPropertyChanged(nameof(NumberOfUnitsEntry));
                OnPropertyChanged(nameof(DateOfAttendanceEntry));

                // Display
                OnPropertyChanged(nameof(IDDisplay));
                OnPropertyChanged(nameof(NameDisplay));
                OnPropertyChanged(nameof(CourseCodeDisplay));
                OnPropertyChanged(nameof(CourseTitleDisplay));
                OnPropertyChanged(nameof(NumberOfUnitsDisplay));
                OnPropertyChanged(nameof(DateOfAttendanceDisplay));
            });

            ClearEntry = new Command(() =>
            {
                IDEntry = 0;
                NameEntry = "";
                CourseCodeEntry = "";
                CourseTitleEntry = "";
                NumberOfUnitsEntry = 0;
                DateOfAttendanceEntry = DateTime.Now;

                IDDisplay = 0;
                NameDisplay = "";
                CourseCodeDisplay = "";
                CourseTitleDisplay = "";
                NumberOfUnitsDisplay = 0;
                DateOfAttendanceDisplay = DateTime.Now;

                OnPropertyChanged(nameof(IDEntry));
                OnPropertyChanged(nameof(NameEntry));
                OnPropertyChanged(nameof(CourseCodeEntry));
                OnPropertyChanged(nameof(CourseTitleEntry));
                OnPropertyChanged(nameof(NumberOfUnitsEntry));
                OnPropertyChanged(nameof(DateOfAttendanceEntry));

                OnPropertyChanged(nameof(IDDisplay));
                OnPropertyChanged(nameof(NameDisplay));
                OnPropertyChanged(nameof(CourseCodeDisplay));
                OnPropertyChanged(nameof(CourseTitleDisplay));
                OnPropertyChanged(nameof(NumberOfUnitsDisplay));
                OnPropertyChanged(nameof(DateOfAttendanceDisplay));
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
