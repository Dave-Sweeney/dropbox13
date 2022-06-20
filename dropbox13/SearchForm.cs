using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dropbox13
{
    public partial class SearchForm : Form
    {
        List<Student> allStudent = new List<Student>();
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("student.txt"))
            {
                string id;
                while ((id = sr.ReadLine()) != null)
                {
                    string name = sr.ReadLine();
                    int score = int.Parse(sr.ReadLine());
                    // create a student object
                    Student s = new Student(id, name, score);
                    // add to the List
                    allStudent.Add(s);
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // search the list, find the student by id
            Student s = allStudent.Find(x => x.StudentId == searchTextBox.Text);
            if (s != null)
            {
                idLabel.Text = s.StudentId;
                nameLabel.Text = s.StudentName;
                gradeLabel.Text = s.GetLetterGrade().ToString();
            }
            else
            {
                MessageBox.Show("No student found.");
                idLabel.Text = String.Empty;
                nameLabel.Text = String.Empty;
                gradeLabel.Text = String.Empty;
            }
        }
    }
}
