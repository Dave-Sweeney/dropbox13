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
    public partial class DisplayForm : Form
    {
        // A list that includes all students
        List<Student> allStudent = new List<Student>();
        public DisplayForm()
        {
            InitializeComponent();
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader("student.txt"))
            {
                string id;
                while ((id = sr.ReadLine()) != null)
                {
                    string name = sr.ReadLine();
                    int score = int.Parse(sr.ReadLine());
                    // create the student
                    Student s = new Student(id, name, score);
                    // add the student to the list
                    allStudent.Add(s);
                    // add the student to the listbox
                    allStudentListBox.Items.Add(s);
                }
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // print a header
            e.Graphics.DrawString("Grade Report",
                new Font("Courier New", 24, FontStyle.Bold),
                Brushes.Black, 200, 100);

            // print date and time
            e.Graphics.DrawString(DateTime.Now.ToString(),
                new Font("Courier New", 10, FontStyle.Italic),
                Brushes.Black, 240, 150);

            // print each student in a loop
            int x = 100, y = 200;
            foreach (Student s in allStudent)
            {
                e.Graphics.DrawString(s.ToString(),
                    new Font("Courier New", 10, FontStyle.Regular),
                    Brushes.Black, x, y);
                y += 15;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
