using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HW_105_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    ///</summary>
    public partial class MainWindow : Window
    {
        static Task TaskSelected;
        static Task TaskToAdd;

        static User userSelected;
        static User deleteUser;
        int currentuserID;
        static User addUser;

        List<string> UsersTable;
        List<string> TaskTable;
        List<Task> TaskList;

        public MainWindow()
        {
            InitializeComponent();
            Initialize();
        }

        public void Initialize()
        {

            TextBox.Text = "Click on new to add a new item :)";
            TextBox.IsReadOnly = true;
            NewUserTextBox.IsReadOnly = true;

            using (var db = new ToDoDatabase())
            {
                var UsersTableName = db.Users.ToList(); //Get the users from the database 
                UsersTable = new List<string>(); // Create a list of strings 

                foreach (var item in UsersTableName)
                {
                    UsersTable.Add(item.UserName); // Put the name of the users in our string list 
                }
            }
            UserDropDown.ItemsSource = UsersTable; // Assigning the name of the users to the combobox
        }

        private void UserSelected(object sender, SelectionChangedEventArgs e)
        {
            UserTasksListBox.ItemsSource = null; // Remove tasks or previous user

            var selectedUser = UserDropDown.SelectedValue.ToString(); //

            using (var db = new ToDoDatabase())
            {
                currentuserID = db.Users.First(u => u.UserName == selectedUser).UserID; //The 'first' method returns the first item that meets the condition rather than a list of one item

                TaskList = db.Tasks.Where(t => t.UserID == currentuserID).ToList();
                TaskTable = new List<string>();

                foreach (var t in TaskList)
                {
                    TaskTable.Add(t.TaskDescription);
                }
                UserTasksListBox.ItemsSource = TaskList;
            }
        }

        private void NewButton_Click(object sender, RoutedEventArgs e)
        {
            if (NewButton.Content.ToString() == "New")
            {
                NewButton.Content = "Add";
                TextBox.IsReadOnly = false;
                TextBox.Text = "Start typing . . . .";
            }
            else if (NewButton.Content.ToString() == "Add")
            {
                NewButton.Content = "New";
                using (var db = new ToDoDatabase())
                {
                    TaskToAdd = new Task()
                    {
                        UserID = currentuserID,
                        TaskDescription = TextBox.Text,
                    };
                    db.Tasks.Add(TaskToAdd);
                    db.SaveChanges();
                    //refresh view
                    TaskList = db.Tasks.Where(t => t.UserID == currentuserID).ToList();
                    UserTasksListBox.ItemsSource = null;
                    UserTasksListBox.ItemsSource = TaskList;

                    MessageBox.Show("Your item has been added!");
                    TextBox.Text = "Click on new to add a new item :)";
                    TextBox.IsReadOnly = true;
                }
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var taskID = (UserTasksListBox.SelectedItem as Task).TaskID;

            using (var db = new ToDoDatabase())
            {
                var DeleteUserTask = db.Tasks.First(t => t.TaskID == taskID);
                db.Tasks.Remove(DeleteUserTask);
                db.SaveChanges();
                MessageBox.Show("Your item has been deleted");
                TaskList = db.Tasks.Where(T => T.UserID == currentuserID).ToList();
            }
            UserTasksListBox.ItemsSource = TaskList;
            UserTasksListBox.DisplayMemberPath = "TaskDescription";

        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            TextBox.IsReadOnly = false;
            TaskSelected = UserTasksListBox.SelectedItem as Task;

            using (var db = new ToDoDatabase())
            {

                if (EditButton.Content.ToString() == "Edit")
                {
                    EditButton.Content = "Save";
                    TextBox.IsReadOnly = false;
                }
                else if (EditButton.Content.ToString() == "Save")
                {
                    EditButton.Content = "Edit";
                    if (userSelected != null)
                    {
                        
                        TaskSelected = db.Tasks.Where(c => c.TaskID == TaskSelected.TaskID).FirstOrDefault();

                        TaskSelected.TaskDescription = TextBox.Text;
                        db.SaveChanges();
                    }

                }
            }
        }

        private void AddUserButton_Click(object sender, RoutedEventArgs e)
        {
            if (AddUserButton.Content.ToString() == "Add User")
            {
                AddUserButton.Content = "Add";
                NewUserTextBox.IsReadOnly = false;
                NewUserTextBox.Text = "";
            }
            else if (AddUserButton.Content.ToString() == "Add")
            {
                AddUserButton.Content = "Add User";

                using (var db = new ToDoDatabase())
                {
                    addUser = new User()
                    {
                        UserName = NewUserTextBox.Text
                    };

                    db.Users.Add(addUser);
                    db.SaveChanges();
                    NewUserTextBox.Text = null;
                    MessageBox.Show("New user has been added!");
                    //UserDropDown.DisplayMemberPath = "UserName";
                    //UserDropDown.ItemsSource = UsersTable; 
                    Initialize();
                }
            }

        }
       
    }
}