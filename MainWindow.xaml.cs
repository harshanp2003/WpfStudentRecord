using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfStudentRecord
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<int,string> map = new Dictionary<int,string>();

        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int StudentId = int.Parse(id.Text);
            string name = student_name.Text;




            if (map.ContainsKey(StudentId))
            {
                MessageBox.Show("Student Already exists");
                id.Text = "";
                student_name.Text = "";
            }
            else
            {
                
                map.Add(StudentId, name);
                id.Text = "";
                student_name.Text = "";
            }







         
            // Clearing the Details TextBox to avoid duplicating previous data
            Details.Text = "";

            // Append all map details again (it will only display the current map contents)
            foreach (var x in map)
            {
                Details.Text += x.Key + " " + x.Value + "\n";
            }

           
        }

        private void Remove_Student(object sender, RoutedEventArgs e)
        {
            int student_id=int.Parse(sid.Text);
            if (map.ContainsKey(student_id))
            {
                map.Remove(student_id);
            }
            Details.Text = "";
            foreach (var x in map)
            {
                Details.Text += x.Key + " " + x.Value + "\n";
            }
        }
    }
}