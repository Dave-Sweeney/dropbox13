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
    }
}
