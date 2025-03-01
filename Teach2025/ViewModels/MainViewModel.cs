using System.Collections.ObjectModel;
using System.ComponentModel;
using Teach2025.Models;

namespace Teach2025.ViewModels;

public class MainViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<question.Question> _questions;
        public ObservableCollection<question.Question> Questions
        {
            get { return _questions; }
            set
            {
                _questions = value;
                OnPropertyChanged(nameof(Questions));
            }
        }

        public MainViewModel()
        {
            Questions = new ObservableCollection<question.Question>();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
