using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace App1.ViewModels
{
    public class XTasks_mvvm : INotifyPropertyChanged
    {

        private XTask _selectedTask;
        public ObservableCollection<XTask> tasks;

        public XTasks_mvvm() { }

        public XTask SelectedTask { get { return _selectedTask; } set { _selectedTask = SelectedTask; OnPropertyChanged(nameof(SelectedTask)); } }



        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }


    public class XTask : INotifyPropertyChanged
    {

        private string _name;
        private string _description;
        private bool _status;

        public string Name { get { return _name; } set { _name = value; OnPropertyChanged(nameof(Name)); } }
        public string Description { get { return _description; } set { _description = value; OnPropertyChanged(nameof(Description)); } }
        public bool Status { get { return _status; } set { _status = value; OnPropertyChanged(nameof(Status)); } }

        public XTask(string name, string description, bool status) 
        {
            Name = name;
            Description = description;
            Status = status;
        }
        
        
        
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    
    }
}



