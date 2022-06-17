using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.ObjectModel;

namespace TODOList
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<string> TasksList { get; set; }
        public MainPage()
        {
            InitializeComponent();

            TasksList = new ObservableCollection<string>();

            this.BindingContext = this;
        }
        private void AddItem(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(taskText.Text))
                DisplayAlert("Error", "Write the text please", "OK");
            else
            {
                TasksList.Add(taskText.Text);
                taskText.Text = "";
            }
        }
        private void TasksListTapped(object sender, ItemTappedEventArgs e)
        {
            string goal = tasksList.SelectedItem.ToString();
            if (goal != null)
            {
                TasksList.Remove(goal);
                tasksList.SelectedItem = null;
            }
        }
    }
}
